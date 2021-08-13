using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface IOrderRepository: IRepositoryBase<Order>, IRepositoryBase2<Order, Guid>
    {
        System.Threading.Tasks.Task<PagedList<Order>> GetOrdersByPage(OrderQueryParameters parameters);

        System.Threading.Tasks.Task<IEnumerable<Order>> GetOrdersByCode(string contractCode);

        System.Threading.Tasks.Task<Order> GetOrderWithMolecule(Guid orderId);

        System.Threading.Tasks.Task<Order> GetOrderWithPlasmid(Guid orderId);

        System.Threading.Tasks.Task<Order> GetOrderWithMoleculeAndPlasmid(Guid orderId);

        System.Threading.Tasks.Task<Order> GetOrderWithQpcr(Guid orderId);

        System.Threading.Tasks.Task<Order> GetOrderWithShipment(Guid orderId);
    }
}
