using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Profiles
{
    public class ShipmentProfile:Profile
    {
        public ShipmentProfile()
        {
            CreateMap<Shipment, ShipmentDto>()
                .ForMember(d => d.Address, opt => opt.MapFrom(s => s.DeliveryAddress.ToString()))
                .ForMember(d => d.Status, opt => opt.MapFrom(s => s.Status.ToString()));

            CreateMap<ShipmentUpdateDto, Shipment>()
                .ForMember(d => d.DeliveryAddress, opt => opt.MapFrom(s => new Address() { Province = s.Province, City = s.City, District = s.District, Detail = s.Detail }));
        }
    }
}
