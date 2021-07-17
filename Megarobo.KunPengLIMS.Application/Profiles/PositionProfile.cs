using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.Externals;

namespace Megarobo.KunPengLIMS.Application.Profiles
{
    public class PositionProfile : Profile 
    {
        public PositionProfile()
        {
            CreateMap<BoxStore, BoxStoreDto>();

            CreateMap<BoxStoreDto, BoxStore>();

            CreateMap<Location, LocationDto>();
            //.ForMember(d => d.selectedList, opt => opt.MapFrom<SelectedListResolver>());
            CreateMap<LocationDto, Location>();
        }
    }
}

//public class SelectedListResolver : IValueResolver<Location, LocationDto, List<string>>
//{
//    public List<string> Resolve(Location source, LocationDto destination, List<string> destMember, ResolutionContext context)
//    {
//        if(string.IsNullOrEmpty(source.selectedList))
//        {
//            return new List<string>();
//        }
//        var selectedText = source.selectedList.Substring(2, source.selectedList.Length - 4);
//        var ary = selectedText.Split("\",\"", StringSplitOptions.RemoveEmptyEntries);
//        var result = new List<string>();
//        for(var i=0; i<ary.Length; i++)
//        {
//            if(ary[i].Contains("\""))
//            {
//                ary[i] = ary[i].Replace("\"", "");
//            }
//            result.Add(ary[i]);
//        }
//        return result;
//    }
//}
