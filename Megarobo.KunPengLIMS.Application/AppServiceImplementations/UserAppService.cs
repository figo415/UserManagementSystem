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

namespace Megarobo.KunPengLIMS.Application.Services
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
            if(dto.DepartmentRoleIds.Any())
            {
                foreach(var deptrole in dto.DepartmentRoleIds)
                {
                    var userdepartmentrole = new UserDepartmentRole() { UserID = user.Id, DepartmentID = deptrole.DepartmentId, RoleID = deptrole.RoleId };
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
                return false;
            }
            _mapper.Map(dto, user, typeof(UserUpdateDto), typeof(User));
            user.LastModifiedAt = DateTime.Now;
            _repoWrapper.UserRepo.Update(user);
            var userskills = await _repoWrapper.UserSkillRepo.GetSkillsByUser(userId);
            foreach(var userskill in userskills)
            {
                _repoWrapper.UserSkillRepo.Delete(userskill);
            }
            if(dto.SkillIds.Any())
            {
                foreach (var skillid in dto.SkillIds)
                {
                    var userskill = new UserSkill() { UserID = user.Id, SkillID = skillid };
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
                    var userdepartmentrole = new UserDepartmentRole() { UserID = user.Id, DepartmentID = deptrole.DepartmentId, RoleID = deptrole.RoleId };
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
                return false;
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
                return false;
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
