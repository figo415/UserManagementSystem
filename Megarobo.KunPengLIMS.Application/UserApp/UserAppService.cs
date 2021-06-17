using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.IRepositories;
using Megarobo.KunPengLIMS.Application.UserApp.Dtos;
using Megarobo.KunPengLIMS.Application.SkillApp.Dtos;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;

namespace Megarobo.KunPengLIMS.Application.UserApp
{
    /// <summary>
    /// 用户管理服务
    /// </summary>
    public class UserAppService : IUserAppService
    {
        private readonly Megarobo.KunPengLIMS.Domain.IRepositories.IUserRepository _repository;
        private readonly IMapper _mapper;
        private readonly IRepositoryWrapper _repoWrapper;

        public UserAppService(IRepositoryWrapper wrapper)
        {
            _repoWrapper = wrapper;
        }

        public User CheckUser(string userName, string password)
        {
            return _repository.CheckUser(userName, password);
        }

        public List<UserDto> GetUserByDepartment(Guid departmentId, int startPage, int pageSize, out int rowCount)
        {
            //return _mapper.Map<List<UserDto>>(_repository.LoadPageList(startPage, pageSize, out rowCount, it => it.DepartmentId == departmentId, it => it.CreateTime));
            return _mapper.Map<List<UserDto>>(_repository.LoadPageList(startPage, pageSize, out rowCount, it => it.DepartmentRoles.Select(ud=>ud.DepartmentID).Contains(departmentId), it => it.CreatedAt));
        }

        public Task<UserDtoList> GetUsers(UserResourceParameter parameter)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDto> GetUser(Guid userId)
        {
            var user = await _repoWrapper.UserRepo.GetByIdAsync(userId);
            var dto = _mapper.Map<UserDto>(user);
            return dto;
        }

        public Task<SkillDtoList> GetSkillsForUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<UserDepartmentRoleDtoList> GetDepartmentRolesForUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertUser(UserCreationDto dto)
        {
            var user = _mapper.Map<User>(dto);
            user.Id = Guid.NewGuid();
            user.CreatedAt = DateTime.Now;
            user.IsDeleted = false;
            _repoWrapper.UserRepo.Create(user);
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
