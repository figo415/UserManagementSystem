using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public interface IOrderAppService
    {
        Task<PagedList<OrderDto>> GetOrdersByPage(OrderQueryParameters parameters);

        Task<bool> InsertOrder(OrderCreationDto dto);

        Task<bool> UpdateOrder(Guid orderId, OrderUpdateDto dto);

        Task<bool> CancelOrder(Guid orderId);

        Task<bool> CloneMolecule(Guid orderId);

        Task<bool> PurifyPlasmid(Guid orderId);

        Task<bool> StartProduce(Guid orderId);

        Task<bool> QcAndStockIn(Guid orderId);

        Task<bool> FinishOrder(Guid orderId);

        Task<bool> DeleteOrders(DeleteMultiDto dto);
    }
}
