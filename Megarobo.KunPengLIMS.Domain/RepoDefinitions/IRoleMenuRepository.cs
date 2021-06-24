using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface IRoleMenuRepository:IRepositoryBase<RoleMenu>
    {
        System.Threading.Tasks.Task<IEnumerable<RoleMenu>> GetRoleMenusByRole(Guid roleId);
    }
}
