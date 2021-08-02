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
    public class SterilityDetectionRepository : RepositoryBase<SterilityDetection, Guid>, ISterilityDetectionRepository
    {
        public SterilityDetectionRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public Task<PagedList<SterilityDetection>> GetSterilityDetectionsByPage(SterilityDetectionQueryParameters parameters)
        {
            IQueryable<SterilityDetection> queryable = DbContext.Set<SterilityDetection>();
            var predicate = BuildPredicate(parameters);
            queryable = queryable.Where(predicate).OrderByDescending(c => c.CreatedAt);
            return PagedList<SterilityDetection>.CreateAsync(queryable, parameters.PageNumber, parameters.PageSize);
        }

        private Expression<Func<SterilityDetection, bool>> BuildPredicate(SterilityDetectionQueryParameters parameters)
        {
            Expression<Func<SterilityDetection, bool>> predicate = PredicateBuilder.True<SterilityDetection>();
            if (!string.IsNullOrEmpty(parameters.ContractCode))
            {
                predicate = predicate.And(c => c.ContractCode == parameters.ContractCode);
            }
            if (!string.IsNullOrEmpty(parameters.CarrierCode))
            {
                predicate = predicate.And(c => c.CarrierCode == parameters.CarrierCode);
            }
            ContractTypeEnum contractType;
            if (!Enum.TryParse<ContractTypeEnum>(parameters.ContractType, out contractType))
            {
                contractType = ContractTypeEnum.AAV;
            }
            predicate = predicate.And(c => c.ContractType == contractType);
            if (!string.IsNullOrEmpty(parameters.Status))
            {
                DetectionStatusEnum sterilityStatus;
                if (Enum.TryParse<DetectionStatusEnum>(parameters.Status, out sterilityStatus))
                {
                    predicate = predicate.And(c => c.Status == sterilityStatus);
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
    }
}