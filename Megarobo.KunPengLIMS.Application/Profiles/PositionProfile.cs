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
            CreateMap<Position, PositionDto>();

            CreateMap<BoxStoreItem, BoxStoreItemDto>();

            CreateMap<LocationListItem, LocationDto>();
        }
    }
}
