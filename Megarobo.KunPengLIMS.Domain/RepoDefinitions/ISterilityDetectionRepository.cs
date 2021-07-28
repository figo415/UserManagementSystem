using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface ISterilityDetectionRepository : IRepositoryBase<SterilityDetection>, IRepositoryBase2<SterilityDetection, Guid>
    {
        System.Threading.Tasks.Task<PagedList<SterilityDetection>> GetSterilityDetectionsByPage(SterilityDetectionQueryParameters parameters);
    }
}
