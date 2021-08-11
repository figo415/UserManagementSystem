using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.Enums;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Infrastructure.Utility;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.Infrastructure.RepoImplementations
{
    public class MolecularCloningRepository: RepositoryBase<MolecularCloning, Guid>, IMolecularCloningRepository
    {
        public MolecularCloningRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public Task<PagedList<MolecularCloning>> GetMolecularCloningsByPage(MolecularCloningQueryParameters parameters)
        {
            IQueryable<MolecularCloning> queryable = DbContext.Set<MolecularCloning>();
            var predicate = BuildPredicate(parameters);
            queryable = queryable.Where(predicate).OrderByDescending(c => c.CreatedAt);
            return PagedList<MolecularCloning>.CreateAsync(queryable, parameters.PageNumber, parameters.PageSize);
        }

        private Expression<Func<MolecularCloning, bool>> BuildPredicate(MolecularCloningQueryParameters parameters)
        {
            Expression<Func<MolecularCloning, bool>> predicate = PredicateBuilder.True<MolecularCloning>();
            if (!string.IsNullOrEmpty(parameters.ContractCode))
            {
                predicate = predicate.And(c => c.ContractCode == parameters.ContractCode);
            }
            if (!string.IsNullOrEmpty(parameters.CarrierCode))
            {
                predicate = predicate.And(c => c.CarrierCode == parameters.CarrierCode);
            }
            ContractTypeEnum contractType;
            if (!Enum.TryParse<ContractTypeEnum>(parameters.ContractType, out contractType))
            {
                contractType = ContractTypeEnum.AAV;
            }
            predicate = predicate.And(c => c.ContractType == contractType);
            if (!string.IsNullOrEmpty(parameters.Status))
            {
                MolecularCloningStatusEnum moleculeStatus;
                if (Enum.TryParse<MolecularCloningStatusEnum>(parameters.Status, out moleculeStatus))
                {
                    predicate = predicate.And(c => c.Status == moleculeStatus);
                }
            }
            if (parameters.StartDate != null && parameters.EndDate == null)
            {
                predicate = predicate.And(c => c.OrderCreateTime >= parameters.StartDate);
            }
            else if (parameters.StartDate == null && parameters.EndDate != null)
            {
                predicate = predicate.And(c => c.OrderCreateTime <= parameters.EndDate);
            }
            else if (parameters.StartDate != null && parameters.EndDate != null)
            {
                if (parameters.StartDate > parameters.EndDate)
                {
                    predicate = predicate.And(c => c.OrderCreateTime >= parameters.EndDate && c.OrderCreateTime <= parameters.StartDate);
                }
                else
                {
                    predicate = predicate.And(c => c.OrderCreateTime >= parameters.StartDate && c.OrderCreateTime <= parameters.EndDate);
                }
            }
            predicate = predicate.And(c => !c.IsDeleted);
            return predicate;
        }

        public System.Threading.Tasks.Task<MolecularCloning> GetMolecularCloningByOrder(Guid orderId)
        {
            return DbContext.Set<MolecularCloning>().SingleOrDefaultAsync(q => q.OrderId == orderId);
        }
    }
}
