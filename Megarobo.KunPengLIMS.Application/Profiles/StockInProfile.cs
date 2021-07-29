using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Profiles
{
    public class StockInProfile:Profile
    {
        public StockInProfile()
        {
            CreateMap<StockIn, StockInDto>()
                .ForMember(d => d.Status, opt => opt.MapFrom(s => s.Status.ToString()));

            CreateMap<StockInUpdateDto, StockIn>();
        }
    }
}
