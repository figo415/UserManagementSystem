using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Infrastructure.RepoImplementations
{
    public class RoleMenuRepository:RepositoryBaseNoId<RoleMenu>,IRoleMenuRepository
    {
        public RoleMenuRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public System.Threading.Tasks.Task<IEnumerable<RoleMenu>> GetRoleMenusByRole(Guid roleId)
        {
            return System.Threading.Tasks.Task.FromResult(DbContext.Set<RoleMenu>().Where(rm => rm.RoleId == roleId).AsEnumerable());
        }
    }
}
