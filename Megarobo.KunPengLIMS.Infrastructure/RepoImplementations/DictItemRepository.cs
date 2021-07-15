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
    public class DictItemRepository:RepositoryBase<DictItem,Guid>,IDictItemRepository
    {
        public DictItemRepository(DbContext dbContext):base(dbContext)
        {

        }

        public System.Threading.Tasks.Task<PagedList<DictItem>> GetDictItemsByPage(DictItemQueryParameters parameters)
        {
            IQueryable<DictItem> queryable = DbContext.Set<DictItem>();
            var predicate = BuildPredicate(parameters);
            queryable = queryable.Where(predicate).OrderByDescending(d => d.CreatedAt);
            return PagedList<DictItem>.CreateAsync(queryable, parameters.PageNumber, parameters.PageSize);
        }

        private Expression<Func<DictItem, bool>> BuildPredicate(DictItemQueryParameters parameters)
        {
            Expression<Func<DictItem, bool>> predicate = PredicateBuilder.True<DictItem>();
            if (!string.IsNullOrEmpty(parameters.KeyName))
            {
                predicate = predicate.And(d => d.KeyName.ToLower().Contains(parameters.KeyName.ToLower()));
            }
            if (!string.IsNullOrEmpty(parameters.Type))
            {
                predicate = predicate.And(d => d.Type == parameters.Type);
            }
            predicate = predicate.And(u => !u.IsDeleted);
            return predicate;
        }

        public System.Threading.Tasks.Task<IEnumerable<DictItem>> GetDictItemsByName(string dictItemName)
        {
            return GetByConditionAsync(d => d.KeyName == dictItemName);
        }
    }
}
