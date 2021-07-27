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

        public async Task<bool> InsertOrder(OrderCreationDto dto)
        {
            var existed = await _repoWrapper.OrderRepo.GetOrdersByCode(dto.ContractCode);
            if (existed.Any())
            {
                throw new AlreadyExistedException("Order with Contract Code=" + dto.ContractCode + " is already existed");
            }
            var order = _mapper.Map<Order>(dto);
            order.Id = Guid.NewGuid();
            order.CreatedAt = DateTime.Now;
            order.IsDeleted = false;
            _repoWrapper.OrderRepo.Create(order);
            var result = await _repoWrapper.OrderRepo.SaveAsync();
            return result;
        }

        public async Task<bool> UpdateOrder(Guid orderId, OrderUpdateDto dto)
        {
            var order = await _repoWrapper.OrderRepo.GetByIdAsync(orderId);
            if (order == null)
            {
                throw new NotExistedException("Order with Guid=" + orderId + " is not existed");
            }
            _mapper.Map(dto, order, typeof(OrderUpdateDto), typeof(Order));
            order.LastModifiedAt = DateTime.Now;
            _repoWrapper.OrderRepo.Update(order);
            var result = await _repoWrapper.OrderRepo.SaveAsync();
            return result;
        }

        public async Task<bool> DeleteOrders(DeleteMultiDto dto)
        {
            foreach (var orderId in dto.Guids)
            {
                var order = await _repoWrapper.OrderRepo.GetByIdAsync(orderId);
                if (order == null)
                {
                    continue;
                }
                order.IsDeleted = true;
                order.LastModifiedAt = DateTime.Now;
                _repoWrapper.OrderRepo.Update(order);
            }
            var result = await _repoWrapper.OrderRepo.SaveAsync();
            return result;
        }
    }
}
