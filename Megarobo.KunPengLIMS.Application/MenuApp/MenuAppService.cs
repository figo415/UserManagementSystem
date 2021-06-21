﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.MenuApp.Dtos;
using Megarobo.KunPengLIMS.Domain.Entities;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.MenuApp
{
    public class MenuAppService : IMenuAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public MenuAppService(IRepositoryWrapper wrapper, IMapper mapper)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
        }

        public async Task<PagedList<MenuDto>> GetMenusByPage(MenuQueryParameters parameters)
        {
            var pagedMenus = await _repoWrapper.MenuRepo.GetMenusByPage(parameters);
            var pagedDtos = _mapper.Map<IEnumerable<MenuDto>>(pagedMenus);
            return new PagedList<MenuDto>(pagedDtos.ToList(), pagedMenus.TotalCount, pagedMenus.CurrentPage, pagedMenus.PageSize);
        }

        public async Task<bool> InsertMenu(MenuCreationDto dto)
        {
            var menu = _mapper.Map<Menu>(dto);
            menu.Id = Guid.NewGuid();
            menu.CreatedAt = DateTime.Now;
            menu.IsDeleted = false;
            _repoWrapper.MenuRepo.Create(menu);
            var result = await _repoWrapper.MenuRepo.SaveAsync();
            return result;
        }

        public async Task<bool> UpdateMenu(Guid menuId, MenuUpdateDto dto)
        {
            var menu = await _repoWrapper.MenuRepo.GetByIdAsync(menuId);
            if (menu == null)
            {
                return false;
            }
            _mapper.Map(dto, menu, typeof(MenuUpdateDto), typeof(Menu));
            _repoWrapper.MenuRepo.Update(menu);
            var result = await _repoWrapper.MenuRepo.SaveAsync();
            return result;
        }

        public async Task<bool> EnableMenu(Guid menuId, MenuUpdateStatusDto dto)
        {
            var menu = await _repoWrapper.MenuRepo.GetByIdAsync(menuId);
            if (menu == null)
            {
                return false;
            }
            menu.IsActive = dto.IsActive;
            _repoWrapper.MenuRepo.Update(menu);
            var result = await _repoWrapper.MenuRepo.SaveAsync();
            return result;
        }

        public async Task<bool> DeleteMenus(DeleteMultiDto dto)
        {
            foreach (var menuId in dto.Guids)
            {
                var menu = await _repoWrapper.MenuRepo.GetByIdAsync(menuId);
                if (menu == null)
                {
                    continue;
                }
                menu.IsDeleted = true;
                _repoWrapper.MenuRepo.Update(menu);
            }
            var result = await _repoWrapper.MenuRepo.SaveAsync();
            return result;
        }


        public List<MenuDto> GetMenusByUser(Guid userId)// 根据用户获取功能菜单
        {
            throw new NotImplementedException();
            //List<MenuDto> result = new List<MenuDto>();
            //var allMenus = _menuRepository.GetAllList(it=>it.Type == 0).OrderBy(it => it.OrdinalNumber);
            //if (userId == Guid.Empty) //超级管理员
            //    return _mapper.Map<List<MenuDto>>(allMenus);
            //var user = new User(); //_userRepository.GetWithRoles(userId);
            //if (user == null)
            //    return result;
            ////var userRoles = user.Roles;
            //List<Guid> menuIds = new List<Guid>();
            ////foreach (var role in userRoles)
            ////{
            ////    menuIds = menuIds.Union(_roleRepository.GetAllMenuListByRole(role.RoleID)).ToList();
            ////}
            //allMenus = allMenus.Where(it => menuIds.Contains(it.Id)).OrderBy(it => it.OrdinalNumber);
            //return _mapper.Map<List<MenuDto>>(allMenus);
        }
    }
}
