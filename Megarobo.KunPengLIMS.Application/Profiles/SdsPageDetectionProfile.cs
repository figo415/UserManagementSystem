using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Profiles
{
    public class SdsPageDetectionProfile:Profile
    {
        public SdsPageDetectionProfile()
        {
            CreateMap<SdsPageDetection, SdsPageDetectionDto>()
                .ForMember(d => d.Status, opt => opt.MapFrom(s => s.Status.ToString()))
                .ForMember(d => d.QpcrTiter, opt => opt.MapFrom(s => s.QpcrDetection == null ? 0f : s.QpcrDetection.Titer))
                .ForMember(d => d.Files, opt => opt.MapFrom<SdsPageFileListResolver>());

            CreateMap<SdsPageDetectionUpdateDto, SdsPageDetection>()
                .ForMember(d => d.DetectionPicture, opt => opt.MapFrom<SdsPageFileResolver>());
        }
    }

    public class SdsPageFileListResolver : IValueResolver<SdsPageDetection, SdsPageDetectionDto, List<string>>
    {
        public List<string> Resolve(SdsPageDetection source, SdsPageDetectionDto destination, List<string> destMember, ResolutionContext context)
        {
            if (string.IsNullOrEmpty(source.DetectionPicture))
            {
                return new List<string>();
            }
            return source.DetectionPicture.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }

    public class SdsPageFileResolver : IValueResolver<SdsPageDetectionUpdateDto, SdsPageDetection, string>
    {
        public string Resolve(SdsPageDetectionUpdateDto source, SdsPageDetection destination, string destMember, ResolutionContext context)
        {
            if (source.Files != null && source.Files.Any())
            {
                return string.Join(',', source.Files);
            }
            return string.Empty;
        }
    }
}
