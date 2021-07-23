using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Profiles
{
    public class MenuProfile:Profile
    {
        public MenuProfile()
        {
            CreateMap<Menu, MenuDto>()
                .ForMember(d => d.CreateTime, opt => opt.MapFrom(s => s.CreatedAt))
                .ForMember(d => d.Meta, opt => opt.MapFrom(s => new Meta() { Title = s.Title, Icon = s.Icon }));

            CreateMap<MenuCreationDto, Menu>()
                .ForMember(d => d.Path, opt => opt.MapFrom(s => s.RoutePath));

            CreateMap<MenuUpdateDto, Menu>();

            CreateMap<MenuUpdateStatusDto, Menu>();
        }
    }
}
