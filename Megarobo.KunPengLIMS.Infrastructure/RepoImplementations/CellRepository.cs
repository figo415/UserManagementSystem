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
    public class CellRepository : RepositoryBase<Cell, Guid>, ICellRepository
    {
        public CellRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public System.Threading.Tasks.Task<PagedList<Cell>> GetCellsByPage(CellQueryParameters parameters)
        {
            IQueryable<Cell> queryable = DbContext.Set<Cell>().Include(c => c.Species);
            var predicate = BuildPredicate(parameters);
            queryable = queryable.Where(predicate).OrderByDescending(c => c.CreatedAt);
            return PagedList<Cell>.CreateAsync(queryable, parameters.PageNumber, parameters.PageSize);
        }

        private Expression<Func<Cell, bool>> BuildPredicate(CellQueryParameters parameters)
        {
            Expression<Func<Cell, bool>> predicate = PredicateBuilder.True<Cell>();
            if (!string.IsNullOrEmpty(parameters.Name))
            {
                predicate = predicate.And(c => c.Name.ToLower().Contains(parameters.Name.ToLower()));
            }
            if (!string.IsNullOrEmpty(parameters.TissueType))
            {
                predicate = predicate.And(c => c.TissueType == parameters.TissueType);
            }
            if (!string.IsNullOrEmpty(parameters.CellLineType))
            {
                predicate = predicate.And(c => c.CellLineType == parameters.CellLineType);
            }
            if (parameters.StartDate != null && parameters.EndDate == null)
            {
                predicate = predicate.And(c => c.CreatedAt >= parameters.StartDate);
            }
            else if (parameters.StartDate == null && parameters.EndDate != null)
            {
                predicate = predicate.And(c => c.CreatedAt <= parameters.EndDate);
            }
            else if (parameters.StartDate != null && parameters.EndDate != null)
            {
                if (parameters.StartDate > parameters.EndDate)
                {
                    predicate = predicate.And(c => c.CreatedAt >= parameters.EndDate && c.CreatedAt <= parameters.StartDate);
                }
                else
                {
                    predicate = predicate.And(c => c.CreatedAt >= parameters.StartDate && c.CreatedAt <= parameters.EndDate);
                }
            }
            predicate = predicate.And(c => !c.IsDeleted);
            return predicate;
        }

        public System.Threading.Tasks.Task<IEnumerable<Cell>> GetCellsByName(string cellName)
        {
            return GetByConditionAsync(c => c.Name == cellName && !c.IsDeleted);
        }

        public System.Threading.Tasks.Task<int> GetCellCount()
        {
            return DbContext.Set<Cell>().CountAsync();
        }
    }
}
