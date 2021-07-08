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
    public class DeviceRepository : RepositoryBase<Device, Guid>, IDeviceRepository
    {
        public DeviceRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public System.Threading.Tasks.Task<PagedList<Device>> GetDevicesByPage(DeviceQueryParameters parameters)
        {
            IQueryable<Device> queryable = DbContext.Set<Device>();
            var predicate = BuildPredicate(parameters);
            queryable = queryable.Where(predicate).OrderByDescending(d => d.CreatedAt);
            return PagedList<Device>.CreateAsync(queryable, parameters.PageNumber, parameters.PageSize);
        }

        private Expression<Func<Device, bool>> BuildPredicate(DeviceQueryParameters parameters)
        {
            Expression<Func<Device, bool>> predicate = PredicateBuilder.True<Device>();
            if (!string.IsNullOrEmpty(parameters.Name))
            {
                predicate = predicate.And(d => d.Name.ToLower().Contains(parameters.Name.ToLower()));
            }
            if (!string.IsNullOrEmpty(parameters.Type))
            {
                predicate = predicate.And(d => d.Type == parameters.Type);
            }
            if (parameters.StartDate != null && parameters.EndDate == null)
            {
                predicate = predicate.And(d => d.CreatedAt >= parameters.StartDate);
            }
            else if (parameters.StartDate == null && parameters.EndDate != null)
            {
                predicate = predicate.And(d => d.CreatedAt <= parameters.EndDate);
            }
            else if (parameters.StartDate != null && parameters.EndDate != null)
            {
                if (parameters.StartDate > parameters.EndDate)
                {
                    predicate = predicate.And(d => d.CreatedAt >= parameters.EndDate && d.CreatedAt <= parameters.StartDate);
                }
                else
                {
                    predicate = predicate.And(d => d.CreatedAt >= parameters.StartDate && d.CreatedAt <= parameters.EndDate);
                }
            }
            predicate = predicate.And(d => !d.IsDeleted);
            return predicate;
        }

        public System.Threading.Tasks.Task<IEnumerable<Device>> GetDeviceByName(string deviceName)
        {
            return GetByConditionAsync(d => d.Name == deviceName && !d.IsDeleted);
        }
    }
}
