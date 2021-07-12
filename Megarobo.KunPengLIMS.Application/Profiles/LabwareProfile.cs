using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AutoMapper;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.Externals;

namespace Megarobo.KunPengLIMS.Application.Profiles
{
    public class LabwareProfile:Profile
    {
        public LabwareProfile()
        {
            CreateMap<Labware, LabwareDto>()
                .ForMember(d => d.Position, opt => opt.MapFrom(s => s.Positions.Any() ? string.Join(',', s.Positions.Select(p => p.Position.Name).ToArray()) : string.Empty))
                .ForMember(d => d.CreateTime, opt => opt.MapFrom(s => s.CreatedAt))
                .ForMember(d => d.LastModifiedTime, opt => opt.MapFrom(s => s.LastModifiedAt))
                .ForMember(d => d.PurchaseFromName, opt => opt.MapFrom(s => s.PurchaseFrom.Name))
                .ForMember(d => d.PurchaseFromUrl, opt => opt.MapFrom(s => s.PurchaseFrom.Url))
                .ForMember(d => d.PurchasePrice, opt => opt.MapFrom(s => s.Price.ToString()));

            CreateMap<Inventory, LabwareDto>()
                .ForMember(d => d.Id, opt => opt.Ignore())
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.itemName))
                .ForMember(d => d.Type, opt => opt.MapFrom(s => s.typeName))
                .ForMember(d => d.ArticleNumber, opt => opt.MapFrom(s => s.articleNum))
                .ForMember(d => d.Brand, opt => opt.MapFrom(s => s.brand))
                .ForMember(d => d.Specification, opt => opt.MapFrom(s => s.spec + s.specUnit))
                .ForMember(d => d.Position, opt => opt.MapFrom(s => s.locationString))
                .ForMember(d => d.CreateTime, opt => opt.MapFrom(s => Convert.ToDateTime(s.addDate)))
                .ForMember(d => d.LastModifiedTime, opt => opt.MapFrom(s => Convert.ToDateTime(s.updateDate)))
                .ForMember(d => d.PurchaseFromUrl, opt => opt.MapFrom(s => s.url))
                .ForMember(d => d.PurchasePrice, opt => opt.MapFrom(s => s.price + s.priceUnit))
                .ForMember(d => d.PurchaseDate, opt => opt.MapFrom(s => s.arrivalDate))
                .ForMember(d => d.Supplier, opt => opt.MapFrom(s => s.vendor))
                .ForMember(d => d.Remarks, opt => opt.MapFrom(s => s.inventoryNote));
        }
    }
}
