using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
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

        public System.Threading.Tasks.Task<IEnumerable<UserSkill>> GetSkillsByUser(Guid userId)
        {
            return System.Threading.Tasks.Task.FromResult(DbContext.Set<UserSkill>().Where(us => us.UserID == userId).AsEnumerable());
        }
    }
}
