using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;

namespace Megarobo.KunPengLIMS.Application.MenuApp.Dtos
{
    public class MenuProfile:Profile
    {
        public MenuProfile()
        {
            CreateMap<Menu, MenuDto>().ForMember(d => d.CreateTime, opt => opt.MapFrom(s => s.CreatedAt));
            CreateMap<MenuCreationDto, Menu>();
            CreateMap<MenuUpdateDto, Menu>();
            CreateMap<MenuUpdateStatusDto, Menu>();
        }
    }
}
