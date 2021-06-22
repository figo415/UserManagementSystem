using System;
using System.Collections.Generic;
using System.Text;
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
    }
}
