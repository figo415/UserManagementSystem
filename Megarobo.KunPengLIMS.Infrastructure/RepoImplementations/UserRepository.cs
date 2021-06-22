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
    public class UserRepository:RepositoryBase<User,Guid>,IUserRepository
    {
        public UserRepository(DbContext dbContext):base(dbContext)
        {

        }

        public System.Threading.Tasks.Task<PagedList<User>> GetUsersByPage(UserQueryParameters parameters)
        {
            //IQueryable<User> queryable = DbContext.Set<User>();
            IQueryable<User> queryable = DbContext.Set<User>().Include(u => u.Skills).ThenInclude(us => us.Skill).Include(u => u.DepartmentRoles);
            var predicate = BuildPredicate(parameters);
            queryable = queryable.Where(predicate);
            return PagedList<User>.CreateAsync(queryable, parameters.PageNumber, parameters.PageSize);
        }

        private Expression<Func<User,bool>> BuildPredicate(UserQueryParameters parameters)
        {
            Expression<Func<User, bool>> predicate = PredicateBuilder.True<User>();
            if (!string.IsNullOrEmpty(parameters.UserName))
            {
                predicate = predicate.And(u => u.UserName == parameters.UserName);
            }
            if (!string.IsNullOrEmpty(parameters.MobileNumber))
            {
                predicate = predicate.And(u => u.MobileNumber == parameters.MobileNumber);
            }
            if (parameters.IsActive != null)
            {
                predicate = predicate.And(u => u.IsActive == parameters.IsActive);
            }
            if (parameters.StartDate != DateTime.MinValue && parameters.EndDate != DateTime.MinValue)
            {
                predicate = predicate.And(u => u.CreatedAt >= parameters.StartDate && u.CreatedAt <= parameters.EndDate);
            }
            predicate = predicate.And(u => !u.IsDeleted);
            return predicate;
        }

        public System.Threading.Tasks.Task<User> GetUserWithSkill(Guid userId)
        {
            return System.Threading.Tasks.Task.FromResult(DbContext.Set<User>().Include(u => u.Skills).ThenInclude(us => us.Skill).Where(u => u.Id == userId).SingleOrDefault());
        }

        public System.Threading.Tasks.Task<User> GetUserWithDepartmentRole(Guid userId)
        {
            return System.Threading.Tasks.Task.FromResult(GetUserWithDepartmentRoleInternal(userId));
        }

        private User GetUserWithDepartmentRoleInternal(Guid userId)
        {
            var user = DbContext.Set<User>().Include(u => u.DepartmentRoles).ThenInclude(udr => udr.Department).SingleOrDefault();
            foreach(var dr in user.DepartmentRoles)
            {
                dr.Role = DbContext.Set<Role>().SingleOrDefault(s => s.Id == dr.RoleID);
            }
            return user;
        }
    }
}
