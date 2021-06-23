using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Profiles
{
    public class DictItemProfile:Profile
    {
        public DictItemProfile()
        {
            CreateMap<DictItem, DictItemDto>().ForMember(d => d.CreateTime, opt => opt.MapFrom(s => s.CreatedAt));
            CreateMap<DictItemCreationDto, DictItem>();
            CreateMap<DictItemUpdateDto, DictItem>();
        }
    }
}
