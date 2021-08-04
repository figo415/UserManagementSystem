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
    public class SdsPageDetectionRepository : RepositoryBase<SdsPageDetection, Guid>, ISdsPageDetectionRepository
    {
        public SdsPageDetectionRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public Task<PagedList<SdsPageDetection>> GetSdsPageDetectionsByPage(SdsPageDetectionQueryParameters parameters)
        {
            IQueryable<SdsPageDetection> queryable = DbContext.Set<SdsPageDetection>();
            var predicate = BuildPredicate(parameters);
            queryable = queryable.Where(predicate).OrderByDescending(c => c.CreatedAt);
            return PagedList<SdsPageDetection>.CreateAsync(queryable, parameters.PageNumber, parameters.PageSize);
        }

        private Expression<Func<SdsPageDetection, bool>> BuildPredicate(SdsPageDetectionQueryParameters parameters)
        {
            Expression<Func<SdsPageDetection, bool>> predicate = PredicateBuilder.True<SdsPageDetection>();
            if (!string.IsNullOrEmpty(parameters.ContractCode))
            {
                predicate = predicate.And(c => c.ContractCode == parameters.ContractCode);
            }
            if (!string.IsNullOrEmpty(parameters.CarrierCode))
            {
                predicate = predicate.And(c => c.CarrierCode == parameters.CarrierCode);
            }
            if (!string.IsNullOrEmpty(parameters.Status))
            {
                DetectionStatusEnum sdspageStatus;
                if (Enum.TryParse<DetectionStatusEnum>(parameters.Status, out sdspageStatus))
                {
                    predicate = predicate.And(c => c.Status == sdspageStatus);
                }
            }
            if (parameters.StartDate != null && parameters.EndDate == null)
            {
                predicate = predicate.And(c => c.OrderCreateTime >= parameters.StartDate);
            }
            else if (parameters.StartDate == null && parameters.EndDate != null)
            {
                predicate = predicate.And(c => c.OrderCreateTime <= parameters.EndDate);
            }
            else if (parameters.StartDate != null && parameters.EndDate != null)
            {
                if (parameters.StartDate > parameters.EndDate)
                {
                    predicate = predicate.And(c => c.OrderCreateTime >= parameters.EndDate && c.OrderCreateTime <= parameters.StartDate);
                }
                else
                {
                    predicate = predicate.And(c => c.OrderCreateTime >= parameters.StartDate && c.OrderCreateTime <= parameters.EndDate);
                }
            }
            predicate = predicate.And(c => !c.IsDeleted);
            return predicate;
        }

        public System.Threading.Tasks.Task<SdsPageDetection> GetSdsPageDetectionByOrder(Guid orderId)
        {
            return DbContext.Set<SdsPageDetection>().SingleOrDefaultAsync(q => q.OrderId == orderId);
        }
    }
}