using AutoMapper;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Application.Exceptions;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public class RoleAppService : IRoleAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public RoleAppService(IRepositoryWrapper wrapper, IMapper mapper)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
        }

        public async Task<PagedList<RoleDto>> GetRolesByPage(RoleQueryParameters parameters)
        {
            var pagedRoles = await _repoWrapper.RoleRepo.GetRolesByPage(parameters);
            var pagedDtos = _mapper.Map<List<RoleDto>>(pagedRoles);
            return new PagedList<RoleDto>(pagedDtos, pagedRoles.TotalCount, pagedRoles.CurrentPage, pagedRoles.PageSize);
        }

        public async Task<PagedList<RoleDto>> GetRolesWithMenuByPage(RoleQueryParameters parameters)
        {
            var pagedRoles = await _repoWrapper.RoleRepo.GetRolesWithMenuByPage(parameters);
            var pagedDtos = _mapper.Map<IEnumerable<RoleDto>>(pagedRoles);
            return new PagedList<RoleDto>(pagedDtos.ToList(), pagedRoles.TotalCount, pagedRoles.CurrentPage, pagedRoles.PageSize);
        }

        public async Task<IEnumerable<MenuDto>> GetMenusForRole(Guid roleId)
        {
            var role = await _repoWrapper.RoleRepo.GetRoleWithMenu(roleId);
            var menus = role.Menus.Select(rm => rm.Menu);
            var dtos = _mapper.Map<IEnumerable<MenuDto>>(menus);
            return dtos;
        }

        public async Task<bool> InsertRole(RoleCreationDto dto)
        {
            var role = _mapper.Map<Role>(dto);
            role.Id = Guid.NewGuid();
            role.CreatedAt = DateTime.Now;
            role.IsDeleted = false;
            _repoWrapper.RoleRepo.Create(role);
            if(dto.MenuIds.Any())
            {
                foreach(var menuid in dto.MenuIds)
                {
                    var rolemenu = new RoleMenu() { RoleID = role.Id, MenuID = menuid };
                    _repoWrapper.RoleMenuRepo.Create(rolemenu);
                }
            }
            var result = await _repoWrapper.RoleRepo.SaveAsync();
            return result;
        }

        public async Task<bool> UpdateRole(Guid roleId, RoleUpdateDto dto)
        {
            var role = await _repoWrapper.RoleRepo.GetByIdAsync(roleId);
            if (role == null)
            {
                throw new NotExistedException("Role with Guid=" + roleId + " is not existed");
            }
            _mapper.Map(dto, role, typeof(RoleUpdateDto), typeof(Role));
            role.LastModifiedAt = DateTime.Now;
            _repoWrapper.RoleRepo.Update(role);
            var rolemenus = await _repoWrapper.RoleMenuRepo.GetRoleMenusByRole(roleId);
            foreach(var rolemenu in rolemenus)
            {
                _repoWrapper.RoleMenuRepo.Delete(rolemenu);
            }
            if (dto.MenuIds.Any())
            {
                foreach (var menuid in dto.MenuIds)
                {
                    var rolemenu = new RoleMenu() { RoleID = role.Id, MenuID = menuid };
                    _repoWrapper.RoleMenuRepo.Create(rolemenu);
                }
            }
            var result = await _repoWrapper.RoleRepo.SaveAsync();
            return result;
        }

        public async Task<bool> EnableRole(Guid roleId, RoleUpdateStatusDto dto)
        {
            var role = await _repoWrapper.RoleRepo.GetByIdAsync(roleId);
            if (role == null)
            {
                throw new NotExistedException("Role with Guid=" + roleId + " is not existed");
            }
            role.IsActive = dto.IsActive;
            role.LastModifiedAt = DateTime.Now;
            _repoWrapper.RoleRepo.Update(role);
            var result = await _repoWrapper.RoleRepo.SaveAsync();
            return result;
        }

        public async Task<bool> DeleteRoles(DeleteMultiDto dto)
        {
            foreach (var roleId in dto.Guids)
            {
                var role = await _repoWrapper.RoleRepo.GetByIdAsync(roleId);
                if (role == null)
                {
                    continue;
                }
                role.IsDeleted = true;
                role.LastModifiedAt = DateTime.Now;
                _repoWrapper.RoleRepo.Update(role);
            }
            var result = await _repoWrapper.RoleRepo.SaveAsync();
            return result;
        }
    }
}
