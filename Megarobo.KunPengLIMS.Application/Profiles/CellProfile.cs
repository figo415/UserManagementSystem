using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Profiles
{
    public class CellProfile:Profile
    {
        public CellProfile()
        {
            CreateMap<Cell, CellDto>()
                .ForMember(d => d.OriginalSpecies, opt => opt.MapFrom(s => s.Species == null ? string.Empty : s.Species.ChineseName+" - "+s.Species.EnglishName+" - "+s.Species.LatinName))
                .ForMember(d => d.PurchaseFromName, opt => opt.MapFrom(s => s.PurchaseFrom.Name))
                .ForMember(d => d.PurchaseFromUrl, opt => opt.MapFrom(s => s.PurchaseFrom.Url))
                .ForMember(d => d.PurchasePrice, opt => opt.MapFrom(s => s.Price.ToString()))
                .ForMember(d => d.SpeciesList, opt => opt.MapFrom<SpeciesListResolver>());

            CreateMap<CellCreationDto, Cell>()
                .ForMember(d => d.PurchaseFrom, opt => opt.MapFrom(s => new Link() { Name = s.PurchaseFromName, Url = s.PurchaseFromUrl }))
                //.ForMember(d => d.Price, opt => opt.MapFrom<PriceResolver>())
                .ForMember(d => d.Price, opt => opt.MapFrom(s => new Price() { Unit = s.PurchasePrice }));

            CreateMap<CellUpdateDto, Cell>()
                .ForMember(d => d.PurchaseFrom, opt => opt.MapFrom(s => new Link() { Name = s.PurchaseFromName, Url = s.PurchaseFromUrl }))
                //.ForMember(d => d.Price, opt => opt.MapFrom<Price2Resolver>())
                .ForMember(d => d.Price, opt => opt.MapFrom(s => new Price() { Unit = s.PurchasePrice }))
                .ForMember(d => d.Species, opt => opt.Ignore());
        }
    }

    public class PriceResolver : IValueResolver<CellCreationDto, Cell, Price>
    {
        public Price Resolve(CellCreationDto source, Cell destination, Price destMember, ResolutionContext context)
        {
            if(string.IsNullOrEmpty(source.PurchasePrice))
            {
                return new Price();
            }
            return new Price() { Unit = source.PurchasePrice };
        }
    }

    public class Price2Resolver : IValueResolver<CellUpdateDto, Cell, Price>
    {
        public Price Resolve(CellUpdateDto source, Cell destination, Price destMember, ResolutionContext context)
        {
            if (string.IsNullOrEmpty(source.PurchasePrice))
            {
                return new Price();
            }
            return new Price() { Unit = source.PurchasePrice };
        }
    }

    public class SpeciesListResolver : IValueResolver<Cell, CellDto, List<SpeciesDto>>
    {
        public List<SpeciesDto> Resolve(Cell source, CellDto destination, List<SpeciesDto> destMember, ResolutionContext context)
        {
            if(source.Species==null)
            {
                return new List<SpeciesDto>();
            }
            var dto = new SpeciesDto()
            {
                Id = source.Species.Id,
                ChineseName = source.Species.ChineseName,
                EnglishName = source.Species.EnglishName,
                LatinName = source.Species.LatinName
            };
            return new List<SpeciesDto>() { dto };
        }
    }
}
