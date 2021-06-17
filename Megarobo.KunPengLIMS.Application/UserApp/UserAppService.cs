using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.IRepositories;
using Megarobo.KunPengLIMS.Application.UserApp.Dtos;
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

        public List<UserDto> GetAllUsers()
        {
            var users = _repository.GetAllList();
            return _mapper.Map<List<UserDto>>(users);
        }

        public async Task<UserDto> GetUser(Guid userId)
        {
            var user = await _repoWrapper.UserRepo.GetByIdAsync(userId);
            var dto = _mapper.Map<UserDto>(user);
            return dto;
        }

        ///// <summary>
        ///// 根据Id获取实体
        ///// </summary>
        ///// <param name="id">Id</param>
        ///// <returns></returns>
        //public UserDto Get(Guid id)
        //{
        //    return _mapper.Map<UserDto>(_repository.GetWithRoles(id));
        //}

        public User CheckUser(string userName, string password)
        {
            return _repository.CheckUser(userName, password);
        }

        public List<UserDto> GetUserByDepartment(Guid departmentId, int startPage, int pageSize, out int rowCount)
        {
            //return _mapper.Map<List<UserDto>>(_repository.LoadPageList(startPage, pageSize, out rowCount, it => it.DepartmentId == departmentId, it => it.CreateTime));
            return _mapper.Map<List<UserDto>>(_repository.LoadPageList(startPage, pageSize, out rowCount, it => it.DepartmentRoles.Select(ud=>ud.DepartmentID).Contains(departmentId), it => it.CreatedAt));
        }

        public async Task<bool> InsertUser(UserCreationDto dto)
        {
            var user = _mapper.Map<User>(dto);
            user.Id = Guid.NewGuid();
            user.CreatedAt = DateTime.Now;
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

        /// <summary>
        /// 新增或修改
        /// </summary>
        /// <param name="dto">实体</param>
        /// <returns></returns>
        public UserDto InsertOrUpdate(UserDto dto)
        {
            //if (Get(dto.Id) != null)
                _repository.Delete(dto.Id);
            var user = _repository.InsertOrUpdate(_mapper.Map<User>(dto));
            return _mapper.Map<UserDto>(user);
        }

        /// <summary>
        /// 根据Id集合批量删除
        /// </summary>
        /// <param name="ids">Id集合</param>
        public void DeleteBatch(List<Guid> ids)
        {
            _repository.Delete(it => ids.Contains(it.Id));
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">Id</param>
        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        
    }
}
