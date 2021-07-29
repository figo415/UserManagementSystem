using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.Entities;
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
            IQueryable<Order> queryable = DbContext.Set<Order>().Include(o => o.SdsPageDetections);
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
            predicate = predicate.And(c => c.ContractType.ToString() == parameters.ContractType);
            if (!string.IsNullOrEmpty(parameters.Status))
            {
                predicate = predicate.And(c => c.Status.ToString() == parameters.Status);
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
    }
}
