using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface IStockInRepository : IRepositoryBase<StockIn>, IRepositoryBase2<StockIn, Guid>
    {
        System.Threading.Tasks.Task<PagedList<StockIn>> GetStockInsByPage(StockInQueryParameters parameters);

        System.Threading.Tasks.Task<StockIn> GetStockInByOrder(Guid orderId);
    }
}
