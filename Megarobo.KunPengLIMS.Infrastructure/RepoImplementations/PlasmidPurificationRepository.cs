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
    public class PlasmidPurificationRepository: RepositoryBase<PlasmidPurification, Guid>, IPlasmidPurificationRepository
    {
        public PlasmidPurificationRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public Task<PagedList<PlasmidPurification>> GetPlasmidPurificationsByPage(PlasmidPurificationQueryParameters parameters)
        {
            IQueryable<PlasmidPurification> queryable = DbContext.Set<PlasmidPurification>();
            var predicate = BuildPredicate(parameters);
            queryable = queryable.Where(predicate).OrderByDescending(c => c.CreatedAt);
            return PagedList<PlasmidPurification>.CreateAsync(queryable, parameters.PageNumber, parameters.PageSize);
        }

        private Expression<Func<PlasmidPurification, bool>> BuildPredicate(PlasmidPurificationQueryParameters parameters)
        {
            Expression<Func<PlasmidPurification, bool>> predicate = PredicateBuilder.True<PlasmidPurification>();
            if (!string.IsNullOrEmpty(parameters.ContractCode))
            {
                predicate = predicate.And(c => c.ContractCode == parameters.ContractCode);
            }
            if (!string.IsNullOrEmpty(parameters.CarrierCode))
            {
                predicate = predicate.And(c => c.CarrierCode == parameters.CarrierCode);
            }
            predicate = predicate.And(c => c.ContractType.ToString() == parameters.ContractType);
            if (!string.IsNullOrEmpty(parameters.PlasmidType))
            {
                predicate = predicate.And(c => c.PlasmidType.ToString() == parameters.PlasmidType);
            }
            if (!string.IsNullOrEmpty(parameters.Status))
            {
                predicate = predicate.And(c => c.Status.ToString() == parameters.Status);
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
