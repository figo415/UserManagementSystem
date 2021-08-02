using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.Enums;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Profiles
{
    public class OrderProfile:Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderCreationDto, Order>()
                .ForMember(d => d.ContractType, opt => opt.MapFrom(s => (ContractTypeEnum)Enum.Parse(typeof(ContractTypeEnum), s.ContractType)))
                .ForMember(d => d.Status, opt => opt.MapFrom(s => (OrderStatusEnum)Enum.Parse(typeof(OrderStatusEnum), s.Status)))
                .ForMember(d => d.PlasmidType, opt => opt.MapFrom(s => (PlasmidExtractionTypeEnum)Enum.Parse(typeof(PlasmidExtractionTypeEnum), s.PlasmidType)));

            CreateMap<Order, OrderDto>()
                .ForMember(d => d.CreateTime, opt => opt.MapFrom(s => s.CreatedAt))
                .ForMember(d => d.ActualTiter, opt => opt.MapFrom(s => s.SdsPageDetection.ProteinTiter))
                .ForMember(d => d.ContractType, opt => opt.MapFrom(s => s.ContractType.ToString()))
                .ForMember(d => d.Status, opt => opt.MapFrom(s => s.Status.ToString()));

            CreateMap<OrderUpdateDto, Order>();
        }
    }
}
