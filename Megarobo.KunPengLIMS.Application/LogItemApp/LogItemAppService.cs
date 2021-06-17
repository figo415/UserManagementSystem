using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;

namespace Megarobo.KunPengLIMS.Application.LogItemApp
{
    public class LogItemAppService:ILogItemAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;

        public LogItemAppService(IRepositoryWrapper wrapper)
        {
            _repoWrapper = wrapper;
        }
    }
}
