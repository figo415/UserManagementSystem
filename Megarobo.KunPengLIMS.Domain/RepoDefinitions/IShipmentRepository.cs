using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface IShipmentRepository : IRepositoryBase<Shipment>, IRepositoryBase2<Shipment, Guid>
    {
        System.Threading.Tasks.Task<PagedList<Shipment>> GetShipmentsByPage(ShipmentQueryParameters parameters);

        System.Threading.Tasks.Task<Shipment> GetShipmentByOrder(Guid orderId);
    }
}
