using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public class OrderAppService : IOrderAppService
    {
        public Task<bool> DeleteOrders(DeleteMultiDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<PagedList<OrderDto>> GetOrdersByPage(OrderQueryParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertOrder(OrderCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateOrder(Guid orderId, OrderUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
