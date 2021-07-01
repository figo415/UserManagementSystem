using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Profiles
{
    public class SpeciesProfile:Profile
    {
        public SpeciesProfile()
        {
            CreateMap<Species, SpeciesDto>();

            CreateMap<SpeciesCreationDto, Species>()
                .ForMember(d => d.SpeciesId, opt => opt.MapFrom(s => new Link() { Name = s.Name, Url = s.Url }));

            CreateMap<SpeciesUpdateDto, Species>()
                .ForMember(d => d.SpeciesId, opt => opt.MapFrom(s => new Link() { Name = s.Name, Url = s.Url }));
        }
    }
}
