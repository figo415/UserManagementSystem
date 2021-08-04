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
    public class ShipmentRepository : RepositoryBase<Shipment, Guid>, IShipmentRepository
    {
        public ShipmentRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public Task<PagedList<Shipment>> GetShipmentsByPage(ShipmentQueryParameters parameters)
        {
            IQueryable<Shipment> queryable = DbContext.Set<Shipment>();
            var predicate = BuildPredicate(parameters);
            queryable = queryable.Where(predicate).OrderByDescending(c => c.CreatedAt);
            return PagedList<Shipment>.CreateAsync(queryable, parameters.PageNumber, parameters.PageSize);
        }

        private Expression<Func<Shipment, bool>> BuildPredicate(ShipmentQueryParameters parameters)
        {
            Expression<Func<Shipment, bool>> predicate = PredicateBuilder.True<Shipment>();
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
                ShipmentStatusEnum shipmentStatus;
                if (Enum.TryParse<ShipmentStatusEnum>(parameters.Status, out shipmentStatus))
                {
                    predicate = predicate.And(c => c.Status == shipmentStatus);
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

        public System.Threading.Tasks.Task<Shipment> GetShipmentByOrder(Guid orderId)
        {
            return DbContext.Set<Shipment>().SingleOrDefaultAsync(q => q.OrderId == orderId);
        }
    }
}