using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Megarobo.KunPengLIMS.Infrastructure.RepoImplementations
{
    public class UserSkillRepository:RepositoryBaseNoId<UserSkill>,IUserSkillRepository
    {
        public UserSkillRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
