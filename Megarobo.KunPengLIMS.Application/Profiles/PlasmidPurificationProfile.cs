using System;
using System.Collections.Generic;
using System.Linq;
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
                .ForMember(d => d.Status, opt => opt.MapFrom(s => s.Status.ToString()))
                .ForMember(d => d.Files, opt => opt.MapFrom<PlasmidFileListResolver>());

            CreateMap<PlasmidPurificationUpdateDto, PlasmidPurification>()
                .ForMember(d => d.Thickness, opt => opt.MapFrom(s => new Thickness() { Value = s.ThicknessValue }))
                .ForMember(d => d.EnzymeCuttingPicture, opt => opt.MapFrom<PlasmidFileResolver>());
        }
    }

    public class PlasmidFileListResolver : IValueResolver<PlasmidPurification, PlasmidPurificationDto, List<string>>
    {
        public List<string> Resolve(PlasmidPurification source, PlasmidPurificationDto destination, List<string> destMember, ResolutionContext context)
        {
            if (string.IsNullOrEmpty(source.EnzymeCuttingPicture))
            {
                return new List<string>();
            }
            return source.EnzymeCuttingPicture.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }

    public class PlasmidFileResolver : IValueResolver<PlasmidPurificationUpdateDto, PlasmidPurification, string>
    {
        public string Resolve(PlasmidPurificationUpdateDto source, PlasmidPurification destination, string destMember, ResolutionContext context)
        {
            if (source.Files != null && source.Files.Any())
            {
                return string.Join(',', source.Files);
            }
            return string.Empty;
        }
    }
}
