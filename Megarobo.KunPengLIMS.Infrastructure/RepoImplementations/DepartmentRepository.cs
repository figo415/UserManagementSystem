﻿using System;
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
            queryable = queryable.Where(predicate);
            return PagedList<Department>.CreateAsync(queryable, parameters.PageNumber, parameters.PageSize);
        }

        private Expression<Func<Department, bool>> BuildPredicate(DepartmentQueryParameters parameters)
        {
            Expression<Func<Department, bool>> predicate = PredicateBuilder.True<Department>();
            if (!string.IsNullOrEmpty(parameters.Name))
            {
                predicate = predicate.And(d => d.Name == parameters.Name);
            }
            predicate = predicate.And(d => d.IsActive == parameters.IsActive);
            predicate = predicate.And(d => !d.IsDeleted);
            return predicate;
        }

        public System.Threading.Tasks.Task<PagedList<User>> GetUsersByDepartment(Guid departmentId, PagedParameters parameters)
        {
            var department = DbContext.Set<Department>().Include(d => d.UserRoles).ThenInclude(u => u.User).Where(d => d.Id == departmentId).SingleOrDefault();
            var users = department.UserRoles.Select(u => u.User).AsQueryable();
            return PagedList<User>.CreateAsync(users, parameters.PageNumber, parameters.PageSize);
        }
    }
}