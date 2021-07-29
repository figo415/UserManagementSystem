using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Profiles
{
    public class QpcrDetectionProfile:Profile
    {
        public QpcrDetectionProfile()
        {
            CreateMap<QpcrDetection, QpcrDetectionDto>()
                .ForMember(d => d.Status, opt => opt.MapFrom(s => s.Status.ToString()));

            CreateMap<QpcrDetectionUpdateDto, QpcrDetection>();
        }
    }
}
