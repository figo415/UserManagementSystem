using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface ISkillRepository:IRepositoryBase<Skill>,IRepositoryBase2<Skill,Guid>
    {
    }
}
