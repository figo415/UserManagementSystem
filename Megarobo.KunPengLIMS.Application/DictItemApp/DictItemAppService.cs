using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;

namespace Megarobo.KunPengLIMS.Application.DictItemApp
{
    public class DictItemAppService: IDictItemAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;

        public DictItemAppService(IRepositoryWrapper wrapper)
        {
            _repoWrapper = wrapper;
        }
    }
}
