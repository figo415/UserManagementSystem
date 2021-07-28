using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface ISdsPageDetectionRepository : IRepositoryBase<SdsPageDetection>, IRepositoryBase2<SdsPageDetection, Guid>
    {
        System.Threading.Tasks.Task<PagedList<SdsPageDetection>> GetSdsPageDetectionsByPage(SdsPageDetectionQueryParameters parameters);
    }
}
