using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.Enums;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Infrastructure.Utility;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.Infrastructure.RepoImplementations
{
    public class OrderRepository : RepositoryBase<Order, Guid>, IOrderRepository
    {
        public OrderRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public Task<PagedList<Order>> GetOrdersByPage(OrderQueryParameters parameters)
        {
            IQueryable<Order> queryable = DbContext.Set<Order>().Include(o => o.SdsPageDetection);
            var predicate = BuildPredicate(parameters);
            queryable = queryable.Where(predicate).OrderByDescending(c => c.CreatedAt);
            return PagedList<Order>.CreateAsync(queryable, parameters.PageNumber, parameters.PageSize);
        }

        private Expression<Func<Order, bool>> BuildPredicate(OrderQueryParameters parameters)
        {
            Expression<Func<Order, bool>> predicate = PredicateBuilder.True<Order>();
            if (!string.IsNullOrEmpty(parameters.ContractCode))
            {
                predicate = predicate.And(c => c.ContractCode == parameters.ContractCode);
            }
            if (!string.IsNullOrEmpty(parameters.CarrierCode))
            {
                predicate = predicate.And(c => c.CarrierCode == parameters.CarrierCode);
            }
            ContractTypeEnum contractType;
             if(!Enum.TryParse<ContractTypeEnum>(parameters.ContractType,out contractType))
            {
                contractType = ContractTypeEnum.AAV;
            }
            predicate = predicate.And(c => c.ContractType == contractType);
            if (!string.IsNullOrEmpty(parameters.Status))
            {
                OrderStatusEnum orderStatus;
                if(Enum.TryParse<OrderStatusEnum>(parameters.Status,out orderStatus))
                {
                    predicate = predicate.And(c => c.Status == orderStatus);
                }
            }
            if (parameters.StartDate != null && parameters.EndDate == null)
            {
                predicate = predicate.And(c => c.CreatedAt >= parameters.StartDate);
            }
            else if (parameters.StartDate == null && parameters.EndDate != null)
            {
                predicate = predicate.And(c => c.CreatedAt <= parameters.EndDate);
            }
            else if (parameters.StartDate != null && parameters.EndDate != null)
            {
                if (parameters.StartDate > parameters.EndDate)
                {
                    predicate = predicate.And(c => c.CreatedAt >= parameters.EndDate && c.CreatedAt <= parameters.StartDate);
                }
                else
                {
                    predicate = predicate.And(c => c.CreatedAt >= parameters.StartDate && c.CreatedAt <= parameters.EndDate);
                }
            }
            predicate = predicate.And(c => !c.IsDeleted);
            return predicate;
        }

        public Task<IEnumerable<Order>> GetOrdersByCode(string contractCode)
        {
            return GetByConditionAsync(o => o.ContractCode == contractCode);
        }

        public Task<Order> GetOrderWithMolecule(Guid orderId)
        {
            return System.Threading.Tasks.Task.FromResult(DbContext.Set<Order>().Include(o => o.MolecularCloning).Where(o => o.Id == orderId).SingleOrDefault());
        }

        public Task<Order> GetOrderWithPlasmid(Guid orderId)
        {
            return System.Threading.Tasks.Task.FromResult(DbContext.Set<Order>().Include(o => o.PlasmidPurification).Where(o => o.Id == orderId).SingleOrDefault());
        }

        public System.Threading.Tasks.Task<Order> GetOrderWithMoleculeAndPlasmid(Guid orderId)
        {
            return System.Threading.Tasks.Task.FromResult(DbContext.Set<Order>().Include(o => o.MolecularCloning).Include(o => o.PlasmidPurification).Where(o => o.Id == orderId).SingleOrDefault());
        }

        public Task<Order> GetOrderWithQpcr(Guid orderId)
        {
            return System.Threading.Tasks.Task.FromResult(DbContext.Set<Order>().Include(o => o.QpcrDetection).Where(o => o.Id == orderId).SingleOrDefault());
        }

        public Task<Order> GetOrderWithShipment(Guid orderId)
        {
            return System.Threading.Tasks.Task.FromResult(DbContext.Set<Order>().Include(o => o.Shipment).Where(o => o.Id == orderId).SingleOrDefault());
        }
    }
}
