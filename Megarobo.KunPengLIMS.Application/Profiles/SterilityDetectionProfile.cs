using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Profiles
{
    public class SterilityDetectionProfile:Profile
    {
        public SterilityDetectionProfile()
        {
            CreateMap<SterilityDetection, SterilityDetectionDto>()
                .ForMember(d => d.Status, opt => opt.MapFrom(s => s.Status.ToString()))
                .ForMember(d => d.Files, opt => opt.MapFrom<SterilityFileListResolver>());

            CreateMap<SterilityDetectionUpdateDto, SterilityDetection>()
                .ForMember(d => d.DetectionPicture, opt => opt.MapFrom<SterilityFileResolver>());
        }
    }

    public class SterilityFileListResolver : IValueResolver<SterilityDetection, SterilityDetectionDto, List<string>>
    {
        public List<string> Resolve(SterilityDetection source, SterilityDetectionDto destination, List<string> destMember, ResolutionContext context)
        {
            if (string.IsNullOrEmpty(source.DetectionPicture))
            {
                return new List<string>();
            }
            return source.DetectionPicture.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }

    public class SterilityFileResolver : IValueResolver<SterilityDetectionUpdateDto, SterilityDetection, string>
    {
        public string Resolve(SterilityDetectionUpdateDto source, SterilityDetection destination, string destMember, ResolutionContext context)
        {
            if (source.Files != null && source.Files.Any())
            {
                return string.Join(',', source.Files);
            }
            return string.Empty;
        }
    }
}
