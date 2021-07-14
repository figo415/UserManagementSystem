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
    public class DepartmentRepository:RepositoryBase<Department,Guid>,IDepartmentRepository
    {
        public DepartmentRepository(DbContext dbContext):base(dbContext)
        {

        }

        public System.Threading.Tasks.Task<PagedList<Department>> GetDepartmentsByPage(DepartmentQueryParameters parameters)
        {
            IQueryable<Department> queryable = DbContext.Set<Department>();
            var predicate = BuildPredicate(parameters);
            queryable = queryable.Where(predicate).OrderByDescending(d => d.CreatedAt);
            return PagedList<Department>.CreateAsync(queryable, parameters.PageNumber, parameters.PageSize);
        }

        public System.Threading.Tasks.Task<IEnumerable<Department>> GetDepartments(DepartmentQueryParameters parameters)
        {
            var predicate = BuildPredicate(parameters);
            return GetByConditionAsync(predicate);
        }

        private Expression<Func<Department, bool>> BuildPredicate(DepartmentQueryParameters parameters)
        {
            Expression<Func<Department, bool>> predicate = PredicateBuilder.True<Department>();
            if (!string.IsNullOrEmpty(parameters.Name))
            {
                predicate = predicate.And(d => d.Name.ToLower().Contains(parameters.Name.ToLower()));
            }
            if(parameters.IsActive!=null)
            {
                predicate = predicate.And(d => d.IsActive == parameters.IsActive);
            }
            predicate = predicate.And(d => !d.IsDeleted);
            return predicate;
        }

        public System.Threading.Tasks.Task<IEnumerable<Department>> GetChildrenOfDepartment(Guid departmentId)
        {
            return System.Threading.Tasks.Task.FromResult(GetChildren(departmentId));
        }

        private IEnumerable<Department> GetChildren(Guid departmentId)
        {
            var departments = new List<Department>();
            var children = DbContext.Set<Department>().Where(d => d.ParentId == departmentId && !d.IsDeleted).ToList();
            foreach(var child in children)
            {
                departments.Add(child);
                var grandsons = GetChildren(child.Id);
                departments.AddRange(grandsons);
            }
            return departments;
        }

        public System.Threading.Tasks.Task<PagedList<User>> GetUsersByDepartment(Guid departmentId, PagedParameters parameters)
        {
            var department = DbContext.Set<Department>().Include(d => d.UserRoles).ThenInclude(u => u.User).ThenInclude(u=>u.DepartmentRoles).Where(d => d.Id == departmentId).SingleOrDefault();
            var users = department.UserRoles.Select(u => u.User).AsQueryable();
            foreach(var user in users)
            {
                user.Skills = DbContext.Set<UserSkill>().Include(us => us.Skill).Where(us => us.UserID == user.Id).ToList();
            }
            return PagedList<User>.CreateAsync(users, parameters.PageNumber, parameters.PageSize);
        }
    }
}
