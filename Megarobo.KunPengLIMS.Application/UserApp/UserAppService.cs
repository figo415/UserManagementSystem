using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.IRepositories;
using Megarobo.KunPengLIMS.Application.UserApp.Dtos;
using Megarobo.KunPengLIMS.Application.SkillApp.Dtos;
using Megarobo.KunPengLIMS.Application.DepartmentApp.Dtos;
using Megarobo.KunPengLIMS.Application.RoleApp.Dtos;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.UserApp
{
    /// <summary>
    /// 用户管理服务
    /// </summary>
    public class UserAppService : IUserAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public UserAppService(IRepositoryWrapper wrapper,IMapper mapper)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
        }

        public List<UserDto> GetUserByDepartment(Guid departmentId, int startPage, int pageSize, out int rowCount)
        {
            //return _mapper.Map<List<UserDto>>(_repository.LoadPageList(startPage, pageSize, out rowCount, it => it.DepartmentId == departmentId, it => it.CreateTime));
            //return _mapper.Map<List<UserDto>>(_repository.LoadPageList(startPage, pageSize, out rowCount, it => it.DepartmentRoles.Select(ud=>ud.DepartmentID).Contains(departmentId), it => it.CreatedAt));
            throw new NotImplementedException();
        }

        public async Task<PagedList<UserDto>> GetUsersByPage(UserQueryParameters parameters)
        {
            var pagedUsers = await _repoWrapper.UserRepo.GetUsersByPage(parameters);
            var pagedDtos = _mapper.Map<IEnumerable<UserDto>>(pagedUsers);
            return new PagedList<UserDto>(pagedDtos.ToList(), pagedUsers.TotalCount, pagedUsers.CurrentPage, pagedUsers.PageSize);
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

        public async Task<bool> InsertUser(UserCreationDto dto)
        {
            var user = _mapper.Map<User>(dto);
            user.Id = Guid.NewGuid();
            user.CreatedAt = DateTime.Now;
            user.IsDeleted = false;
            _repoWrapper.UserRepo.Create(user);
            if (dto.SkillIds.Any())
            {
                foreach (var skillid in dto.SkillIds)
                {
                    var userskill = new UserSkill() { UserID = user.Id, SkillID = skillid };
                    _repoWrapper.UserSkillRepo.Create(userskill);
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
                return false;
            }
            _mapper.Map(dto, user, typeof(UserUpdateDto), typeof(User));
            _repoWrapper.UserRepo.Update(user);
            var result = await _repoWrapper.UserRepo.SaveAsync();
            return result;
        }

        public async Task<bool> EnableUser(Guid userId, UserUpdateStatusDto dto)
        {
            var user = await _repoWrapper.UserRepo.GetByIdAsync(userId);
            if (user == null)
            {
                return false;
            }
            user.IsActive = dto.IsActive;
            _repoWrapper.UserRepo.Update(user);
            var result = await _repoWrapper.UserRepo.SaveAsync();
            return result;
        }

        public async Task<bool> ResetPassword(Guid userId, UserUpdatePasswordDto dto)
        {
            var user = await _repoWrapper.UserRepo.GetByIdAsync(userId);
            if (user == null)
            {
                return false;
            }
            user.Password = dto.Password;
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
                _repoWrapper.UserRepo.Update(user);
            }
            var result = await _repoWrapper.UserRepo.SaveAsync();
            return result;
        }   
    }
}
