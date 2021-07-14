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
    public class LogItemRepository:RepositoryBase<LogItem,int>,ILogItemRepository
    {
        public LogItemRepository(DbContext dbContext):base(dbContext)
        {

        }

        public System.Threading.Tasks.Task<PagedList<LogItem>> GetLogItemsByPage(LogItemQueryParameters parameters)
        {
            IQueryable<LogItem> queryable = DbContext.Set<LogItem>();
            var predicate = BuildPredicate(parameters);
            queryable = queryable.Where(predicate).OrderByDescending(d => d.OperationTime);
            return PagedList<LogItem>.CreateAsync(queryable, parameters.PageNumber, parameters.PageSize);
        }

        private Expression<Func<LogItem, bool>> BuildPredicate(LogItemQueryParameters parameters)
        {
            Expression<Func<LogItem, bool>> predicate = PredicateBuilder.True<LogItem>();
            if (!string.IsNullOrEmpty(parameters.Operator))
            {
                predicate = predicate.And(l => l.Operator.ToLower().Contains(parameters.Operator.ToLower()));
            }
            if (parameters.IsSuccess != null)
            {
                predicate = predicate.And(l => l.IsSuccess == parameters.IsSuccess);
            }
            return predicate;
        }

        public bool Save()
        {
            var num = DbContext.SaveChanges();
            return num > 0;
        }
    }
}
