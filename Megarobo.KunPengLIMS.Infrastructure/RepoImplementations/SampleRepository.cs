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
    public class SampleRepository : RepositoryBase<Sample, Guid>, ISampleRepository
    {
        public SampleRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public System.Threading.Tasks.Task<PagedList<Sample>> GetSamplesByPage(SampleQueryParameters parameters)
        {
            IQueryable<Sample> queryable = DbContext.Set<Sample>().Include(s => s.Cell);
            var predicate = BuildPredicate(parameters);
            queryable = queryable.Where(predicate).OrderByDescending(s => s.CreatedAt);
            return PagedList<Sample>.CreateAsync(queryable, parameters.PageNumber, parameters.PageSize);
        }

        private Expression<Func<Sample, bool>> BuildPredicate(SampleQueryParameters parameters)
        {
            Expression<Func<Sample, bool>> predicate = PredicateBuilder.True<Sample>();
            if (!string.IsNullOrEmpty(parameters.Name))
            {
                predicate = predicate.And(s => s.Name.ToLower().Contains(parameters.Name.ToLower()));
            }
            if (!string.IsNullOrEmpty(parameters.TaskName))
            {
            }
            if (!string.IsNullOrEmpty(parameters.Status))
            {
                predicate = predicate.And(s => s.Status == parameters.Status);
            }
            predicate = predicate.And(s => !s.IsDeleted);
            return predicate;
        }

        public System.Threading.Tasks.Task<Sample> GetSampleWithCell(Guid sampleId)
        {
            return System.Threading.Tasks.Task.FromResult(DbContext.Set<Sample>().Include(s => s.Cell).Where(s => s.Id == sampleId).SingleOrDefault());
        }

        public System.Threading.Tasks.Task<IEnumerable<Sample>> GetSampleByName(string sampleName)
        {
            return GetByConditionAsync(s => s.Name == sampleName);
        }
    }
}
