using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;

namespace Megarobo.KunPengLIMS.Application.DictItemApp.Dtos
{
    public class DictItemProfile:Profile
    {
        public DictItemProfile()
        {
            CreateMap<DictItem, DictItemDto>();
            CreateMap<DictItemCreationDto, DictItem>();
            CreateMap<DictItemUpdateDto, DictItem>();
        }
    }
}
