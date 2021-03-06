using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Profiles
{
    public class LogItemProfile:Profile
    {
        public LogItemProfile()
        {
            CreateMap<LogItem, LogItemDto>();

            CreateMap<LogItemCreationDto, LogItem>();
        }
    }
}
