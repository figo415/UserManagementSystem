using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Infrastructure.Utility;

namespace Megarobo.KunPengLIMS.Infrastructure.RepoImplementations
{
    public class SkillRepository:RepositoryBase<Skill,Guid>,ISkillRepository
    {
        public SkillRepository(DbContext dbContext):base(dbContext)
        {

        }

        public System.Threading.Tasks.Task<PagedList<Skill>> GetSkillsByPage(SkillQueryParameters parameters)
        {
            IQueryable<Skill> queryable = DbContext.Set<Skill>();
            var predicate = BuildPredicate(parameters);
            queryable = queryable.Where(predicate).OrderByDescending(s => s.CreatedAt);
            return PagedList<Skill>.CreateAsync(queryable, parameters.PageNumber, parameters.PageSize);
        }

        public System.Threading.Tasks.Task<IEnumerable<Skill>> GetSkills(SkillQueryParameters parameters)
        {
            var predicate = BuildPredicate(parameters);
            return GetByConditionAsync(predicate);
        }

        private Expression<Func<Skill, bool>> BuildPredicate(SkillQueryParameters parameters)
        {
            Expression<Func<Skill, bool>> predicate = PredicateBuilder.True<Skill>();
            if (!string.IsNullOrEmpty(parameters.SkillName))
            {
                predicate = predicate.And(s => s.SkillName.ToLower().Contains(parameters.SkillName.ToLower()));
            }
            predicate = predicate.And(s => !s.IsDeleted);
            return predicate;
        }
    }
}
