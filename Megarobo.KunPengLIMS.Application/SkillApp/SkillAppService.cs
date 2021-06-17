using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;

namespace Megarobo.KunPengLIMS.Application.SkillApp
{
    public class SkillAppService:ISkillAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;

        public SkillAppService(IRepositoryWrapper wrapper)
        {
            _repoWrapper = wrapper;
        }
    }
}
