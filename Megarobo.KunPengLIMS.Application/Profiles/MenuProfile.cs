using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
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
                .ForMember(d => d.Meta, opt => opt.MapFrom(s => new Meta() { Title = s.Title, Icon = s.Icon }))
                .ForMember(d => d.ButtonList, opt => opt.MapFrom<ButtonStringResolver>());

            CreateMap<MenuCreationDto, Menu>()
                .ForMember(d => d.Path, opt => opt.MapFrom(s => s.RoutePath));

            CreateMap<MenuUpdateDto, Menu>();

            CreateMap<MenuUpdateStatusDto, Menu>();
        }
    }

    public class ButtonStringResolver : IValueResolver<Menu, MenuDto, List<string>>
    {
        public List<string> Resolve(Menu source, MenuDto destination, List<string> destMember, ResolutionContext context)
        {
            if(string.IsNullOrEmpty(source.Buttons))
            {
                return new List<string>();
            }
            return source.Buttons.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }
}
