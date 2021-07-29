﻿using System;
using System.Collections.Generic;
using System.Text;
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
                .ForMember(d => d.Status, opt => opt.MapFrom(s => s.Status.ToString()));

            CreateMap<SterilityDetectionUpdateDto, SterilityDetection>();
        }
    }
}
