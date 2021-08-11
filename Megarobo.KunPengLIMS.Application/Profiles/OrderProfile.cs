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
                .ForMember(d => d.PlasmidType, opt => opt.MapFrom(s => (PlasmidExtractionTypeEnum)Enum.Parse(typeof(PlasmidExtractionTypeEnum), s.PlasmidType)))
                .ForMember(d => d.AnalysisReport, opt => opt.MapFrom<File1Resolver>());

            CreateMap<Order, OrderDto>()
                .ForMember(d => d.CreateTime, opt => opt.MapFrom(s => s.CreatedAt))
                .ForMember(d => d.ActualTiter, opt => opt.MapFrom(s => s.SdsPageDetection.ProteinTiter))
                .ForMember(d => d.ContractType, opt => opt.MapFrom(s => s.ContractType.ToString()))
                .ForMember(d => d.Status, opt => opt.MapFrom(s => s.Status.ToString()))
                .ForMember(d => d.Files, opt => opt.MapFrom<ReportResolver>());

            CreateMap<OrderUpdateDto, Order>()
                .ForMember(d => d.AnalysisReport, opt => opt.MapFrom<File2Resolver>());
        }
    }

    public class File1Resolver : IValueResolver<OrderCreationDto, Order, string>
    {
        public string Resolve(OrderCreationDto source, Order destination, string destMember, ResolutionContext context)
        {
            if(source.Files!=null && source.Files.Any())
            {
                return string.Join(',', source.Files);
            }
            return string.Empty;
        }
    }

    public class File2Resolver : IValueResolver<OrderUpdateDto, Order, string>
    {
        public string Resolve(OrderUpdateDto source, Order destination, string destMember, ResolutionContext context)
        {
            if (source.Files != null && source.Files.Any())
            {
                var newfiles = string.Join(',', source.Files);
                return destination.AnalysisReport + "," + newfiles;
            }
            return destination.AnalysisReport ;
        }
    }

    public class ReportResolver : IValueResolver<Order, OrderDto, List<string>>
    {
        public List<string> Resolve(Order source, OrderDto destination, List<string> destMember, ResolutionContext context)
        {
            if (string.IsNullOrEmpty(source.AnalysisReport))
            {
                return new List<string>();
            }
            return source.AnalysisReport.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }
}
