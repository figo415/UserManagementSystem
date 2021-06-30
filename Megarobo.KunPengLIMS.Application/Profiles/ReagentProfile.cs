using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Profiles
{
    public class ReagentProfile : Profile
    {
        public ReagentProfile()
        {
            CreateMap<Reagent, ReagentDto>()
                .ForMember(d => d.Quality, opt => opt.MapFrom(s => s.Quality.ToString()))
                .ForMember(d => d.Thickness, opt => opt.MapFrom(s => s.Thickness.ToString()))
                .ForMember(d => d.Position, opt => opt.MapFrom(s => s.Positions.Any() ? string.Join(',', s.Positions.Select(p => p.Position.Name).ToArray()) : string.Empty))
                .ForMember(d => d.AvailableQuality, opt => opt.MapFrom(s => s.AvailableQuality.ToString()))
                .ForMember(d => d.AvailableCubage, opt => opt.MapFrom(s => s.AvailableCubage.ToString()))
                .ForMember(d => d.CreatedTime, opt => opt.MapFrom(s => s.CreatedAt))
                .ForMember(d => d.LastModifiedTime, opt => opt.MapFrom(s => s.LastModifiedAt))
                .ForMember(d => d.PurchaseFromName, opt => opt.MapFrom(s => s.PurchaseFrom.Name))
                .ForMember(d => d.PurchaseFromUrl, opt => opt.MapFrom(s => s.PurchaseFrom.Url))
                .ForMember(d => d.PurchasePrice, opt => opt.MapFrom(s => s.Price.ToString()));
        }
    }
}
