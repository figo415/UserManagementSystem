using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public interface IShipmentAppService
    {
        Task<PagedList<ShipmentDto>> GetShipmentsByPage(ShipmentQueryParameters parameters);

        Task<bool> UpdateShipment(Guid shipmentId, ShipmentUpdateDto dto);
    }
}