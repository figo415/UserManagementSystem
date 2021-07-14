using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain.Entities;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Application.Exceptions;

namespace Megarobo.KunPengLIMS.Application.Services
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

        public async Task<IEnumerable<MenuDto>> GetMenuTree(MenuQueryParameters parameters)
        {
            var menus = await _repoWrapper.MenuRepo.GetMenus(parameters);
            menus = menus.OrderByDescending(m => m.CreatedAt);
            var menuDtos = _mapper.Map<IEnumerable<MenuDto>>(menus);
            var tree = GetTree(Guid.Empty, menuDtos);
            return tree;
        }

        private List<MenuDto> GetTree(Guid parentId, IEnumerable<MenuDto> dtos)
        {
            var tree = dtos.Where(d => d.ParentId == parentId).ToList();
            foreach (var item in tree)
            {
                item.Children = GetTree(item.Id, dtos);
            }
            return tree;
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
                throw new NotExistedException("Menu with Guid=" + menuId + " is not existed");
            }
            _mapper.Map(dto, menu, typeof(MenuUpdateDto), typeof(Menu));
            menu.LastModifiedAt = DateTime.Now;
            _repoWrapper.MenuRepo.Update(menu);
            var result = await _repoWrapper.MenuRepo.SaveAsync();
            return result;
        }

        public async Task<bool> EnableMenu(Guid menuId, MenuUpdateStatusDto dto)
        {
            var menu = await _repoWrapper.MenuRepo.GetByIdAsync(menuId);
            if (menu == null)
            {
                throw new NotExistedException("Menu with Guid=" + menuId + " is not existed");
            }
            menu.IsActive = dto.IsActive;
            menu.LastModifiedAt = DateTime.Now;
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
                menu.LastModifiedAt = DateTime.Now;
                _repoWrapper.MenuRepo.Update(menu);
            }
            var result = await _repoWrapper.MenuRepo.SaveAsync();
            return result;
        }


        private List<MenuDto> GetMenusByUser(Guid userId)// 根据用户获取功能菜单
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
