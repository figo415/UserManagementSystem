using Megarobo.KunPengLIMS.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public interface IMenuAppService
    {
        Task<PagedList<MenuDto>> GetMenusByPage(MenuQueryParameters parameters);

        Task<IEnumerable<MenuDto>> GetMenuTree(MenuQueryParameters parameters);

        Task<bool> InsertMenu(MenuCreationDto dto);

        Task<bool> UpdateMenu(Guid menuId, MenuUpdateDto dto);

        Task<bool> EnableMenu(Guid menuId, MenuUpdateStatusDto dto);

        Task<bool> DeleteMenus(DeleteMultiDto dto);

        List<MenuDto> GetTree(Guid parentId, IEnumerable<MenuDto> dtos);
    }
}
