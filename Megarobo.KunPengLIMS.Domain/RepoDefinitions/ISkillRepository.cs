using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface ISkillRepository:IRepositoryBase<Skill>,IRepositoryBase2<Skill,Guid>
    {
        System.Threading.Tasks.Task<PagedList<Skill>> GetSkillsByPage(SkillQueryParameters parameters);
    }
}
