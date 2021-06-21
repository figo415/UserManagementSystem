using Megarobo.KunPengLIMS.Application.MenuApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.MenuApp
{
    public interface IMenuAppService
    {
        Task<PagedList<MenuDto>> GetMenusByPage(MenuQueryParameters parameters);

        Task<bool> InsertMenu(MenuCreationDto dto);

        Task<bool> UpdateMenu(Guid menuId, MenuUpdateDto dto);

        Task<bool> EnableMenu(Guid menuId, MenuUpdateStatusDto dto);

        Task<bool> DeleteMenus(DeleteMultiDto dto);

        List<MenuDto> GetMenusByUser(Guid userId);
    }
}
