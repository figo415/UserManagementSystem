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
    public class RoleRepository:RepositoryBase<Role,Guid>,IRoleRepository
    {
        public RoleRepository(DbContext dbContext):base(dbContext)
        {

        }

        public System.Threading.Tasks.Task<PagedList<Role>> GetRolesByPage(RoleQueryParameters parameters)
        {
            IQueryable<Role> queryable = DbContext.Set<Role>();
            var predicate = BuildPredicate(parameters);
            queryable = queryable.Where(predicate);
            return PagedList<Role>.CreateAsync(queryable, parameters.PageNumber, parameters.PageSize);
        }

        public System.Threading.Tasks.Task<PagedList<Role>> GetRolesWithMenuByPage(RoleQueryParameters parameters)
        {
            IQueryable<Role> queryable = DbContext.Set<Role>().Include(r => r.Menus).ThenInclude(rm => rm.Menu);
            var predicate = BuildPredicate(parameters);
            queryable = queryable.Where(predicate);
            return PagedList<Role>.CreateAsync(queryable, parameters.PageNumber, parameters.PageSize);
        }

        private Expression<Func<Role, bool>> BuildPredicate(RoleQueryParameters parameters)
        {
            Expression<Func<Role, bool>> predicate = PredicateBuilder.True<Role>();
            if (!string.IsNullOrEmpty(parameters.Name))
            {
                predicate = predicate.And(r => r.Name.ToLower().Contains(parameters.Name.ToLower()));
            }
            if (parameters.IsActive != null)
            {
                predicate = predicate.And(r => r.IsActive == parameters.IsActive);
            }
            predicate = predicate.And(r => !r.IsDeleted);
            return predicate;
        }

        public System.Threading.Tasks.Task<Role> GetRoleWithMenu(Guid roleId)
        {
            return System.Threading.Tasks.Task.FromResult(DbContext.Set<Role>().Include(r => r.Menus).ThenInclude(rm => rm.Menu).Where(r => r.Id == roleId).SingleOrDefault());
        }
    }
}
