using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;

namespace Megarobo.KunPengLIMS.Infrastructure.RepoImplementations
{
    public class UserRepository:RepositoryBase<User,Guid>,IUserRepository
    {
        public UserRepository(DbContext dbContext):base(dbContext)
        {

        }
    }
}
