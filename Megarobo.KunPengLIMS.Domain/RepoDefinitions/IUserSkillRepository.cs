using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface IUserSkillRepository:IRepositoryBase<UserSkill>
    {
        System.Threading.Tasks.Task<IEnumerable<UserSkill>> GetUserSkillsByUser(Guid userId);
    }
}
