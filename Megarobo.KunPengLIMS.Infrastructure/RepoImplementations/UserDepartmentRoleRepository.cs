using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Infrastructure.RepoImplementations
{
    public class UserDepartmentRoleRepository:RepositoryBaseNoId<UserDepartmentRole>,IUserDepartmentRoleRepository
    {
        public UserDepartmentRoleRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public System.Threading.Tasks.Task<IEnumerable<UserDepartmentRole>> GetUserDepartmentRolesByUser(Guid userId)
        {
            return System.Threading.Tasks.Task.FromResult(DbContext.Set<UserDepartmentRole>().Where(udr => udr.UserID == userId).AsEnumerable());
        }
    }
}
