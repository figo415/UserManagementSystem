using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.Enums;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Application.Exceptions;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public class ShipmentAppService : IShipmentAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public ShipmentAppService(IRepositoryWrapper wrapper, IMapper mapper)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
        }

        public async Task<PagedList<ShipmentDto>> GetShipmentsByPage(ShipmentQueryParameters parameters)
        {
            var pagedShipments = await _repoWrapper.ShipmentRepo.GetShipmentsByPage(parameters);
            var pagedDtos = _mapper.Map<List<ShipmentDto>>(pagedShipments);
            return new PagedList<ShipmentDto>(pagedDtos, pagedShipments.TotalCount, pagedShipments.PageNumber, pagedShipments.PageSize);
        }

        public async Task<bool> UpdateShipment(Guid shipmentId, ShipmentUpdateDto dto)
        {
            var shipment = await _repoWrapper.ShipmentRepo.GetByIdAsync(shipmentId);
            if (shipment == null)
            {
                throw new NotExistedException("Shipment with Guid=" + shipmentId + " is not existed");
            }
            _mapper.Map(dto, shipment, typeof(ShipmentUpdateDto), typeof(Shipment));
            shipment.Status = ShipmentStatusEnum.Shipped;
            shipment.LastModifiedAt = DateTime.Now;
            _repoWrapper.ShipmentRepo.Update(shipment);
            var result = await _repoWrapper.ShipmentRepo.SaveAsync();
            return result;
        }
    }
}

