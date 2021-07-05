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

namespace Megarobo.KunPengLIMS.Infrastructure.RepoImplementations
{
    public class SpeciesRepository:RepositoryBase<Species,Guid>,ISpeciesRepository
    {
        public SpeciesRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public System.Threading.Tasks.Task<PagedList<Species>> GetSpeciesByPage(SpeciesQueryParameters parameters)
        {
            IQueryable<Species> queryable = DbContext.Set<Species>();
            var predicate = BuildPredicate(parameters);
            queryable = queryable.Where(predicate);
            return PagedList<Species>.CreateAsync(queryable, parameters.PageNumber, parameters.PageSize);
        }

        private Expression<Func<Species, bool>> BuildPredicate(SpeciesQueryParameters parameters)
        {
            Expression<Func<Species, bool>> predicate = PredicateBuilder.True<Species>();
            if (!string.IsNullOrEmpty(parameters.ChineseName))
            {
                predicate = predicate.And(s => s.ChineseName.ToLower().Contains(parameters.ChineseName.ToLower()));
            }
            if (!string.IsNullOrEmpty(parameters.EnglishName))
            {
                predicate = predicate.And(s => s.EnglishName.ToLower().Contains(parameters.EnglishName.ToLower()));
            }
            if (!string.IsNullOrEmpty(parameters.LatinName))
            {
                predicate = predicate.And(s => s.LatinName.ToLower().Contains(parameters.LatinName.ToLower()));
            }
            if (parameters.StartDate != null && parameters.EndDate == null)
            {
                predicate = predicate.And(u => u.CreatedAt >= parameters.StartDate);
            }
            else if (parameters.StartDate == null && parameters.EndDate != null)
            {
                predicate = predicate.And(u => u.CreatedAt <= parameters.EndDate);
            }
            else if (parameters.StartDate != null && parameters.EndDate != null)
            {
                if (parameters.StartDate > parameters.EndDate)
                {
                    predicate = predicate.And(u => u.CreatedAt >= parameters.EndDate && u.CreatedAt <= parameters.StartDate);
                }
                else
                {
                    predicate = predicate.And(u => u.CreatedAt >= parameters.StartDate && u.CreatedAt <= parameters.EndDate);
                }
            }
            predicate = predicate.And(s => !s.IsDeleted);
            return predicate;
        }
    }
}
