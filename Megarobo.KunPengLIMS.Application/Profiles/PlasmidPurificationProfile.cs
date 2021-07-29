using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Profiles
{
    public class PlasmidPurificationProfile:Profile
    {
        public PlasmidPurificationProfile()
        {
            CreateMap<PlasmidPurification, PlasmidPurificationDto>()
                .ForMember(d => d.ThicknessValue, opt => opt.MapFrom(s => s.Thickness.Value))
                .ForMember(d => d.Status, opt => opt.MapFrom(s => s.Status.ToString()));

            CreateMap<PlasmidPurificationUpdateDto, PlasmidPurification>()
                .ForMember(d => d.Thickness, opt => opt.MapFrom(s => new Thickness() { Value = s.ThicknessValue }));
        }
    }
}
