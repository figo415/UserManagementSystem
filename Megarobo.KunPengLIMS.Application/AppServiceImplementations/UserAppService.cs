using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Application.Exceptions;

namespace Megarobo.KunPengLIMS.Application.Services
{
    /// <summary>
    /// 用户管理服务
    /// </summary>
    public class UserAppService : IUserAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;
        private readonly IMenuAppService _menuAppService;

        public UserAppService(IRepositoryWrapper wrapper,IMapper mapper, IMenuAppService menuAppService)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
            _menuAppService = menuAppService;
        }

        public async Task<PagedList<UserDto>> GetUsersByPage(UserQueryParameters parameters)
        {
            var parametersext = new UserQueryParametersExt(parameters);
            if(parameters.DepartmentId!=null)
            {
                var children = await _repoWrapper.DepartmentRepo.GetChildrenOfDepartment(parameters.DepartmentId.Value);
                var guids = children.Select(d => d.Id).ToList();
                guids.Add(parameters.DepartmentId.Value);
                parametersext.DepartmentIds = guids;
            }
            var pagedUsers = await _repoWrapper.UserRepo.GetUsersByPage(parametersext);
            var pagedDtos = _mapper.Map<List<UserDto>>(pagedUsers);
            return new PagedList<UserDto>(pagedDtos, pagedUsers.TotalCount, pagedUsers.PageNumber, pagedUsers.PageSize);
        }

        public async Task<UserDto> GetUser(Guid userId)
        {
            var user = await _repoWrapper.UserRepo.GetByIdAsync(userId);
            var dto = _mapper.Map<UserDto>(user);
            return dto;
        }

        public async Task<IEnumerable<SkillDto>> GetSkillsForUser(Guid userId)
        {
            var user = await _repoWrapper.UserRepo.GetUserWithSkill(userId);
            var skills = user.Skills.Select(us => us.Skill);
            var dtos = _mapper.Map<IEnumerable<SkillDto>>(skills);
            return dtos;
        }

        public async Task<IEnumerable<UserDepartmentRoleDto>> GetDepartmentRolesForUser(Guid userId)
        {
            var user = await _repoWrapper.UserRepo.GetUserWithDepartmentRole(userId);
            var dtos = new List<UserDepartmentRoleDto>();
            foreach(var departmentrole in user.DepartmentRoles)
            {
                var departmentDto = _mapper.Map<DepartmentDto>(departmentrole.Department);
                var roleDto = _mapper.Map<RoleDto>(departmentrole.Role);
                dtos.Add(new UserDepartmentRoleDto() { Department = departmentDto, Role = roleDto });
            }
            return dtos;
        }

        public async Task<UserWithRightsDto> GetUserByToken(string userName)
        {
            var users = await _repoWrapper.UserRepo.GetUsersByName(userName);
            if(users.Any())
            {
                var user = await _repoWrapper.UserRepo.GetUserWithDepartmentRole(users.First().Id);
                if(user!=null)
                {
                    var result = _mapper.Map<UserWithRightsDto>(user);
                    var menus = new List<Menu>();
                    var buttons = new List<OpButton>();
                    foreach(var departmentRole in user.DepartmentRoles)
                    {
                        var rolewithmenu = await _repoWrapper.RoleRepo.GetRoleWithMenu(departmentRole.RoleId);
                        menus.AddRange(rolewithmenu.Menus.Select(rm => rm.Menu));
                        var rolewithbutton = await _repoWrapper.RoleRepo.GetRoleWithButton(departmentRole.RoleId);
                        buttons.AddRange(rolewithbutton.Buttons.Select(rb => rb.Button));
                    }
                    var menudtos= _mapper.Map<List<MenuDto>>(menus.OrderBy(m=>m.OrdinalNumber));
                    result.Menus = _menuAppService.GetTree(Guid.Empty, menudtos);
                    foreach(var menu in result.Menus)
                    {
                        TraverseTree(menu);
                    }
                    result.BtnList = buttons.Select(b => b.Name).ToList();
                    return result;
                }
            }
            return null;
        }

        private void TraverseTree(MenuDto root)
        {
            if (root.Children.Any())
            {
                foreach (var node in root.Children)
                {
                    TraverseTree(node);
                }
            }
            else
            {
                root.Children = null;
            }
        }

        public async Task<bool> InsertUser(UserCreationDto dto)
        {
            var existed = await _repoWrapper.UserRepo.GetUsersByName(dto.UserName);
            if (existed.Any())
            {
                throw new AlreadyExistedException("User with Name=" + dto.UserName + " is already existed");
            }
            var user = _mapper.Map<User>(dto);
            user.Id = Guid.NewGuid();
            user.CreatedAt = DateTime.Now;
            user.IsDeleted = false;
            _repoWrapper.UserRepo.Create(user);
            if (dto.SkillIds.Any())
            {
                foreach (var skillid in dto.SkillIds)
                {
                    var userskill = new UserSkill() { UserId = user.Id, SkillId = skillid };
                    _repoWrapper.UserSkillRepo.Create(userskill);
                }
            }
            if(dto.DepartmentRoleIds.Any())
            {
                foreach(var deptrole in dto.DepartmentRoleIds)
                {
                    var userdepartmentrole = new UserDepartmentRole() { UserId = user.Id, DepartmentId = deptrole.DepartmentId, RoleId = deptrole.RoleId };
                    _repoWrapper.UserDepartmentRoleRepo.Create(userdepartmentrole);
                }
            }
            var result = await _repoWrapper.UserRepo.SaveAsync();
            return result;
        }

        public async Task<bool> UpdateUser(Guid userId, UserUpdateDto dto)
        {
            var user = await _repoWrapper.UserRepo.GetByIdAsync(userId);
            if (user == null)
            {
                throw new NotExistedException("User with Guid=" + userId + " is not existed");
            }
            _mapper.Map(dto, user, typeof(UserUpdateDto), typeof(User));
            user.LastModifiedAt = DateTime.Now;
            _repoWrapper.UserRepo.Update(user);
            var userskills = await _repoWrapper.UserSkillRepo.GetUserSkillsByUser(userId);
            foreach(var userskill in userskills)
            {
                _repoWrapper.UserSkillRepo.Delete(userskill);
            }
            if(dto.SkillIds.Any())
            {
                foreach (var skillid in dto.SkillIds)
                {
                    var userskill = new UserSkill() { UserId = user.Id, SkillId = skillid };
                    _repoWrapper.UserSkillRepo.Create(userskill);
                }
            }
            var userdepartmentroles = await _repoWrapper.UserDepartmentRoleRepo.GetUserDepartmentRolesByUser(userId);
            foreach(var userdepartmentrole in userdepartmentroles)
            {
                _repoWrapper.UserDepartmentRoleRepo.Delete(userdepartmentrole);
            }
            if (dto.DepartmentRoleIds.Any())
            {
                foreach (var deptrole in dto.DepartmentRoleIds)
                {
                    var userdepartmentrole = new UserDepartmentRole() { UserId = user.Id, DepartmentId = deptrole.DepartmentId, RoleId = deptrole.RoleId };
                    _repoWrapper.UserDepartmentRoleRepo.Create(userdepartmentrole);
                }
            }
            var result = await _repoWrapper.UserRepo.SaveAsync();
            return result;
        }

        public async Task<bool> EnableUser(Guid userId, UserUpdateStatusDto dto)
        {
            var user = await _repoWrapper.UserRepo.GetByIdAsync(userId);
            if (user == null)
            {
                throw new NotExistedException("User with Guid=" + userId + " is not existed");
            }
            user.IsActive = dto.IsActive;
            user.LastModifiedAt = DateTime.Now;
            _repoWrapper.UserRepo.Update(user);
            var result = await _repoWrapper.UserRepo.SaveAsync();
            return result;
        }

        public async Task<bool> ResetPassword(Guid userId, UserUpdatePasswordDto dto)
        {
            var user = await _repoWrapper.UserRepo.GetByIdAsync(userId);
            if (user == null)
            {
                throw new NotExistedException("User with Guid=" + userId + " is not existed");
            }
            user.Password = dto.Password;
            user.LastModifiedAt = DateTime.Now;
            _repoWrapper.UserRepo.Update(user);
            var result = await _repoWrapper.UserRepo.SaveAsync();
            return result;
        }

        public async Task<bool> DeleteUsers(DeleteMultiDto dto)
        {
            foreach(var userId in dto.Guids)
            {
                var user = await _repoWrapper.UserRepo.GetByIdAsync(userId);
                if (user == null)
                {
                    continue;
                }
                user.IsDeleted = true;
                user.LastModifiedAt = DateTime.Now;
                _repoWrapper.UserRepo.Update(user);
            }
            var result = await _repoWrapper.UserRepo.SaveAsync();
            return result;
        }   
    }
}
