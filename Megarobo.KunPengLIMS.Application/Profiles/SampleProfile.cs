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
                .ForMember(d => d.CubageValue, opt => opt.MapFrom(s => s.Cubage.Value.ToString()))
                .ForMember(d => d.CubageUnit, opt => opt.MapFrom(s => s.Cubage.Unit))
                .ForMember(d => d.Thickness, opt => opt.MapFrom(s => s.Thickness.ToString()))
                .ForMember(d => d.ThicknessValue, opt => opt.MapFrom(s => s.Thickness.Value.ToString()))
                .ForMember(d => d.ThicknessUnit, opt => opt.MapFrom(s => s.Thickness.Unit))
                .ForMember(d => d.Quality, opt => opt.MapFrom(s => s.Quality.ToString()))
                .ForMember(d => d.QualityValue, opt => opt.MapFrom(s => s.Quality.Value.ToString()))
                .ForMember(d => d.QualityUnit, opt => opt.MapFrom(s => s.Quality.Unit))
                .ForMember(d => d.CreateTime, opt => opt.MapFrom(s => s.CreatedAt))
                .ForMember(d => d.PurchasePrice, opt => opt.MapFrom(s => s.Price.ToString()))
                .ForMember(d => d.PurchaseFromName, opt => opt.MapFrom(s => s.PurchaseFrom.Name))
                .ForMember(d => d.PurchaseFromUrl, opt => opt.MapFrom(s => s.PurchaseFrom.Url))
                .ForMember(d=>d.Cells,opt=>opt.MapFrom<SampleCellsResolver>())
                .ForMember(d => d.SourceTask, opt => opt.Ignore())
                .ForMember(d => d.Positions, opt => opt.Ignore());

            CreateMap<SampleCreationDto, Sample>()
                .ForMember(d => d.Cubage, opt => opt.MapFrom(s => new Cubage() { Value = Convert.ToSingle(s.CubageValue), Unit = s.CubageUnit }))
                .ForMember(d => d.Thickness, opt => opt.MapFrom(s => new Thickness() { Value = Convert.ToSingle(s.ThicknessValue), Unit = s.ThicknessUnit }))
                .ForMember(d => d.Quality, opt => opt.MapFrom(s => new Quality() { Value = Convert.ToSingle(s.QualityValue), Unit = s.QualityUnit }))
                .ForMember(d => d.PurchaseFrom, opt => opt.MapFrom(s => new Link() { Name = s.PurchaseFromName, Url = s.PurchaseFromUrl }))
                .ForMember(d => d.Price, opt => opt.MapFrom(s => new Price() { Unit = s.PurchasePrice }))
                .ForMember(d => d.SourceTask, opt => opt.Ignore())
                .ForMember(d => d.Positions, opt => opt.Ignore());

            CreateMap<SampleUpdateDto, Sample>()
                .ForMember(d => d.Cubage, opt => opt.MapFrom(s => new Cubage() { Value = Convert.ToSingle(s.CubageValue), Unit = s.CubageUnit }))
                .ForMember(d => d.Thickness, opt => opt.MapFrom(s => new Thickness() { Value = Convert.ToSingle(s.ThicknessValue), Unit = s.ThicknessUnit }))
                .ForMember(d => d.Quality, opt => opt.MapFrom(s => new Quality() { Value = Convert.ToSingle(s.QualityValue), Unit = s.QualityUnit }))
                .ForMember(d => d.PurchaseFrom, opt => opt.MapFrom(s => new Link() { Name = s.PurchaseFromName, Url = s.PurchaseFromUrl }))
                .ForMember(d => d.Price, opt => opt.MapFrom(s => new Price() { Unit = s.PurchasePrice }))
                .ForMember(d => d.SourceTask, opt => opt.Ignore())
                .ForMember(d => d.Positions, opt => opt.Ignore());
        }
    }

    public class SampleCellsResolver : IValueResolver<Sample, SampleDto, List<SampleCellDto>>
    {
        public List<SampleCellDto> Resolve(Sample source, SampleDto destination, List<SampleCellDto> destMember, ResolutionContext context)
        {
            if(source.Cell==null)
            {
                return new List<SampleCellDto>();
            }
            var dto = new SampleCellDto();
            dto.Id = source.Cell.Id;
            dto.Name = source.Cell.Name;
            dto.TissueType = source.Cell.TissueType;
            dto.CellLineType = source.Cell.CellLineType;
            dto.CultivationMethod = source.Cell.CultivationMethod;
            return new List<SampleCellDto>()
            {
                dto
            };
        }
    }
}
