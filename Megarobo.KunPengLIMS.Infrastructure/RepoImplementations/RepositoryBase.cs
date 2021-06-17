﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;

namespace Megarobo.KunPengLIMS.Infrastructure.RepoImplementations
{
    public class RepositoryBase<T, TId> : IRepositoryBase<T>, IRepositoryBase2<T, TId> where T : class
    {
        public DbContext DbContext { get; set; }

        public RepositoryBase(DbContext dbContext)
        {
            DbContext = dbContext;
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            return Task.FromResult(DbContext.Set<T>().AsEnumerable());
        }

        public Task<IEnumerable<T>> GetByConditionAsync(Expression<Func<T, bool>> expression)
        {
            return Task.FromResult(DbContext.Set<T>().Where(expression).AsEnumerable());
        }

        public void Create(T entity)
        {
            DbContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            DbContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            DbContext.Set<T>().Remove(entity);
        }

        public async Task<bool> SaveAsync()
        {
            var num = await DbContext.SaveChangesAsync();
            return num > 0;
        }

        public async Task<T> GetByIdAsync(TId id)
        {
            return await DbContext.Set<T>().FindAsync(id);
        }

        public async Task<bool> IsExistAsync(TId id)
        {
            return await DbContext.Set<T>().FindAsync(id) != null;
        }
    }
}
