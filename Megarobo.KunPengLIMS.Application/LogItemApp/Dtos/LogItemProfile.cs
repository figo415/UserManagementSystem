using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.LogItemApp.Dtos;

namespace Megarobo.KunPengLIMS.Application.LogItemApp.Dtos
{
    public class LogItemProfile:Profile
    {
        public LogItemProfile()
        {
            CreateMap<LogItem, LogItemDto>();
        }
    }
}
