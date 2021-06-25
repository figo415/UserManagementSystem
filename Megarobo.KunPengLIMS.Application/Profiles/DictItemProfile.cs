using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Profiles
{
    public class DictItemProfile:Profile
    {
        public DictItemProfile()
        {
            CreateMap<DictItem, DictItemDto>()
                .ForMember(d => d.CreateTime, opt => opt.MapFrom(s => s.CreatedAt))
                .ForMember(d => d.Values, opt => opt.MapFrom<DictValueResolver>());

            CreateMap<DictItemCreationDto, DictItem>();

            CreateMap<DictItemUpdateDto, DictItem>();

            CreateMap<DictItemUpdateValueDto, DictItem>()
                .ForMember(d => d.Value, opt => opt.MapFrom<DictValuesResolver>());
        }
    }

    public class DictValueResolver : IValueResolver<DictItem, DictItemDto, List<string>>
    {
        public List<string> Resolve(DictItem source, DictItemDto destination, List<string> destMember, ResolutionContext context)
        {
            if(string.IsNullOrEmpty(source.Value))
            {
                return new List<string>();
            }
            return source.Value.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }

    public class DictValuesResolver : IValueResolver<DictItemUpdateValueDto, DictItem, string>
    {
        public string Resolve(DictItemUpdateValueDto source, DictItem destination, string destMember, ResolutionContext context)
        {
            if(source.Values.Any())
            {
                return string.Join(',', source.Values.ToArray());
            }
            return string.Empty;
        }
    }
}
