using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Profiles
{
    public class SampleProfile : Profile
    {
        public SampleProfile()
        {
            CreateMap<Sample, SampleDto>()
                .ForMember(d => d.Cubage, opt => opt.MapFrom(s => s.Cubage.ToString()))
                .ForMember(d => d.Thickness, opt => opt.MapFrom(s => s.Thickness.ToString()))
                .ForMember(d => d.Quality, opt => opt.MapFrom(s => s.Quality.ToString()))
                //.ForMember(d=>d.Position)
                .ForMember(d => d.CreateTime, opt => opt.MapFrom(s => s.CreatedAt))
                .ForMember(d => d.PurchasePrice, opt => opt.MapFrom(s => s.Price.ToString()));

            CreateMap<SampleCreationDto, Sample>()
                .ForMember(d => d.Cubage, opt => opt.MapFrom(s => new Cubage() { Value = Convert.ToSingle(s.Cubage), Unit = s.CubageUnit }))
                .ForMember(d => d.Thickness, opt => opt.MapFrom(s => new Thickness() { Value = Convert.ToSingle(s.Thickness), Unit = s.ThicknessUnit }))
                .ForMember(d => d.Quality, opt => opt.MapFrom(s => new Quality() { Value = Convert.ToSingle(s.Quality), Unit = s.QualityUnit }))
                .ForMember(d => d.PurchaseFrom, opt => opt.MapFrom(s => new Link() { Name = s.PurchaseFromName, Url = s.PurchaseFromUrl }))
                .ForMember(d => d.Price, opt => opt.MapFrom(s => new Price() { Unit = s.PurchasePrice }));

            CreateMap<SampleUpdateDto, Sample>();
        }
    }
}
