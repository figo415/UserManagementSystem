using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Application.Exceptions;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public class OrderAppService : IOrderAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public OrderAppService(IRepositoryWrapper wrapper, IMapper mapper)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
        }

        public async Task<PagedList<OrderDto>> GetOrdersByPage(OrderQueryParameters parameters)
        {
            var pagedOrders = await _repoWrapper.OrderRepo.GetOrdersByPage(parameters);
            var pagedDtos = _mapper.Map<List<OrderDto>>(pagedOrders);
            return new PagedList<OrderDto>(pagedDtos, pagedOrders.TotalCount, pagedOrders.PageNumber, pagedOrders.PageSize);
        }

        public Task<bool> InsertOrder(OrderCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateOrder(Guid orderId, OrderUpdateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteOrders(DeleteMultiDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
