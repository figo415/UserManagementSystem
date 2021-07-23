using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface IRoleRepository:IRepositoryBase<Role>,IRepositoryBase2<Role,Guid>
    {
        System.Threading.Tasks.Task<PagedList<Role>> GetRolesByPage(RoleQueryParameters parameters);

        System.Threading.Tasks.Task<PagedList<Role>> GetRolesWithMenuByPage(RoleQueryParameters parameters);

        System.Threading.Tasks.Task<Role> GetRoleWithMenu(Guid roleId);

        System.Threading.Tasks.Task<IEnumerable<Role>> GetRolesByName(string roleName);

        System.Threading.Tasks.Task<Role> GetRoleWithButton(Guid roleId);
    }
}
