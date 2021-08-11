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
                .ForMember(d => d.Address, opt => opt.MapFrom(s => new List<string>() { s.DeliveryAddress.Province, s.DeliveryAddress.City, s.DeliveryAddress.District }))
                .ForMember(d => d.Detail, opt => opt.MapFrom(s => s.DeliveryAddress.Detail))
                .ForMember(d => d.CompleteAddress, opt => opt.MapFrom(s => s.DeliveryAddress.ToString()))
                .ForMember(d => d.Status, opt => opt.MapFrom(s => s.Status.ToString()));

            CreateMap<ShipmentUpdateDto, Shipment>()
                .ForMember(d => d.DeliveryAddress, opt => opt.MapFrom<AddressResolver>());
        }
    }

    public class AddressResolver : IValueResolver<ShipmentUpdateDto, Shipment, Address>
    {
        public Address Resolve(ShipmentUpdateDto source, Shipment destination, Address destMember, ResolutionContext context)
        {
            if(source.Address.Count>=3)
            {
                return new Address() { Province = source.Address[0], City = source.Address[1], District = source.Address[2], Detail = source.Detail };
            }
            else if(source.Address.Count==2)
            {
                return new Address() { Province = source.Address[0], City = source.Address[1], Detail = source.Detail };
            }
            else if(source.Address.Count==1)
            {
                return new Address() { Province = source.Address[0], Detail = source.Detail };
            }
            return new Address() { Detail = source.Detail };
        }
    }
}
