using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Infrastructure.Utility;

namespace Megarobo.KunPengLIMS.Infrastructure.RepoImplementations
{
    public class MenuRepository:RepositoryBase<Menu,Guid>,IMenuRepository
    {
        public MenuRepository(DbContext dbContext):base(dbContext)
        {

        }

        public System.Threading.Tasks.Task<PagedList<Menu>> GetMenusByPage(MenuQueryParameters parameters)
        {
            throw new NotImplementedException();
            //IQueryable<Menu> queryable = DbContext.Set<Menu>();
            //var predicate = BuildPredicate(parameters);
            //queryable = queryable.Where(predicate);
            //return PagedList<Menu>.CreateAsync(queryable, parameters.PageNumber, parameters.PageSize);
        }

        public System.Threading.Tasks.Task<IEnumerable<Menu>> GetMenus(MenuQueryParameters parameters)
        {
            var predicate = BuildPredicate(parameters);
            return GetByConditionAsync(predicate);
        }

        private Expression<Func<Menu, bool>> BuildPredicate(MenuQueryParameters parameters)
        {
            Expression<Func<Menu, bool>> predicate = PredicateBuilder.True<Menu>();
            if (!string.IsNullOrEmpty(parameters.Name))
            {
                predicate = predicate.And(m => m.Name == parameters.Name);
            }
            if (parameters.Type!=null)
            {
                predicate = predicate.And(m => m.Type == parameters.Type);
            }
            if(parameters.IsActive!=null)
            {
                predicate = predicate.And(u => u.IsActive == parameters.IsActive);
            }
            predicate = predicate.And(u => !u.IsDeleted);
            return predicate;
        }
    }
}
