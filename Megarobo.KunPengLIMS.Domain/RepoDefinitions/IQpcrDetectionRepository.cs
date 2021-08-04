using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface IQpcrDetectionRepository : IRepositoryBase<QpcrDetection>, IRepositoryBase2<QpcrDetection, Guid>
    {
        System.Threading.Tasks.Task<PagedList<QpcrDetection>> GetQpcrDetectionsByPage(QpcrDetectionQueryParameters parameters);

        System.Threading.Tasks.Task<QpcrDetection> GetQpcrDetectionByOrder(Guid orderId);
    }
}
