using Megarobo.KunPengLIMS.Application.MenuApp.Dtos;
using Megarobo.KunPengLIMS.Application.RoleApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.RoleApp
{
    public interface IRoleAppService
    {
        Task<PagedList<RoleDto>> GetRolesByPage(RoleQueryParameters parameters);

        Task<PagedList<RoleDto>> GetRolesWithMenuByPage(RoleQueryParameters parameters);

        Task<IEnumerable<MenuDto>> GetMenusForRole(Guid roleId);

        Task<bool> InsertRole(RoleCreationDto dto);

        Task<bool> UpdateRole(Guid roleId, RoleUpdateDto dto);

        Task<bool> EnableRole(Guid roleId, RoleUpdateStatusDto dto);

        Task<bool> DeleteRoles(DeleteMultiDto dto);

    }
}
