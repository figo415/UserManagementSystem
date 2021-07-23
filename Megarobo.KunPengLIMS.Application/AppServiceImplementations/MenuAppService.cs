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
            var pagedDtos = _mapper.Map<List<MenuDto>>(pagedMenus);
            return new PagedList<MenuDto>(pagedDtos, pagedMenus.TotalCount, pagedMenus.PageNumber, pagedMenus.PageSize);
        }

        public async Task<IEnumerable<MenuDto>> GetMenuTree(MenuQueryParameters parameters)
        {
            var menus = await _repoWrapper.MenuRepo.GetMenus(parameters);
            menus = menus.OrderByDescending(m => m.CreatedAt);
            var menuDtos = _mapper.Map<IEnumerable<MenuDto>>(menus);
            var tree = GetTree(Guid.Empty, menuDtos);
            return tree;
        }

        public List<MenuDto> GetTree(Guid parentId, IEnumerable<MenuDto> dtos)
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
            var existed = await _repoWrapper.MenuRepo.GetMenusByName(dto.Name);
            if (existed.Any())
            {
                throw new AlreadyExistedException("Menu with Name=" + dto.Name + " is already existed");
            }
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
    }
}
