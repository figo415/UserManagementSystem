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

        public System.Threading.Tasks.Task<PagedList<User>> GetUsersByPage(UserQueryParametersExt parameters)
        {
            //IQueryable<User> queryable = DbContext.Set<User>();
            IQueryable<User> queryable = DbContext.Set<User>().Include(u => u.Skills).ThenInclude(us => us.Skill).Include(u => u.DepartmentRoles);
            var predicate = BuildPredicate(parameters);
            queryable = queryable.Where(predicate).OrderByDescending(u => u.CreatedAt);
            return PagedList<User>.CreateAsync(queryable, parameters.PageNumber, parameters.PageSize);
        }

        private Expression<Func<User,bool>> BuildPredicate(UserQueryParametersExt parameters)
        {
            Expression<Func<User, bool>> predicate = PredicateBuilder.True<User>();
            if (!string.IsNullOrEmpty(parameters.UserName))
            {
                predicate = predicate.And(u => u.UserName.ToLower().Contains(parameters.UserName.ToLower()));
            }
            if (!string.IsNullOrEmpty(parameters.MobileNumber))
            {
                predicate = predicate.And(u => u.MobileNumber == parameters.MobileNumber);
            }
            if (parameters.IsActive != null)
            {
                predicate = predicate.And(u => u.IsActive == parameters.IsActive);
            }
            if(parameters.DepartmentId!=null)
            {
                predicate = predicate.And(u => u.DepartmentRoles.Any(d => parameters.DepartmentIds.Contains(d.DepartmentId)));
            }
            if(parameters.StartDate!=null && parameters.EndDate==null)
            {
                predicate = predicate.And(u => u.CreatedAt >= parameters.StartDate);
            }
            else if(parameters.StartDate==null && parameters.EndDate!=null)
            {
                predicate = predicate.And(u => u.CreatedAt <= parameters.EndDate);
            }
            else if (parameters.StartDate != null && parameters.EndDate != null)
            {
                if(parameters.StartDate>parameters.EndDate)
                {
                    predicate = predicate.And(u => u.CreatedAt >= parameters.EndDate && u.CreatedAt <= parameters.StartDate);
                }
                else
                {
                    predicate = predicate.And(u => u.CreatedAt >= parameters.StartDate && u.CreatedAt <= parameters.EndDate);
                }
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
            var user = DbContext.Set<User>().Include(u => u.DepartmentRoles).ThenInclude(udr => udr.Department).Where(u => u.Id == userId).SingleOrDefault();
            foreach (var dr in user.DepartmentRoles)
            {
                dr.Role = DbContext.Set<Role>().SingleOrDefault(s => s.Id == dr.RoleId);
            }
            return System.Threading.Tasks.Task.FromResult(user);
        }

        public System.Threading.Tasks.Task<IEnumerable<User>> GetUsersByName(string userName)
        {
            return GetByConditionAsync(u => u.UserName == userName);
        }

        public System.Threading.Tasks.Task<User> GetUserByName(string userName)
        {
            return DbContext.Set<User>().SingleOrDefaultAsync(u => !u.IsDeleted && u.UserName == userName);
        }
    }
}
