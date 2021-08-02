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
    public class QpcrDetectionRepository : RepositoryBase<QpcrDetection, Guid>, IQpcrDetectionRepository
    {
        public QpcrDetectionRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public Task<PagedList<QpcrDetection>> GetQpcrDetectionsByPage(QpcrDetectionQueryParameters parameters)
        {
            IQueryable<QpcrDetection> queryable = DbContext.Set<QpcrDetection>();
            var predicate = BuildPredicate(parameters);
            queryable = queryable.Where(predicate).OrderByDescending(c => c.CreatedAt);
            return PagedList<QpcrDetection>.CreateAsync(queryable, parameters.PageNumber, parameters.PageSize);
        }

        private Expression<Func<QpcrDetection, bool>> BuildPredicate(QpcrDetectionQueryParameters parameters)
        {
            Expression<Func<QpcrDetection, bool>> predicate = PredicateBuilder.True<QpcrDetection>();
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
                DetectionStatusEnum qpcrStatus;
                if(Enum.TryParse<DetectionStatusEnum>(parameters.Status,out qpcrStatus))
                {
                    predicate = predicate.And(c => c.Status == qpcrStatus);
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