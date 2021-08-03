using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Profiles
{
    public class RoleProfile:Profile
    {
        public RoleProfile()
        {
            CreateMap<Role, RoleDto>()
                .ForMember(d => d.CreateTime, opt => opt.MapFrom(s => s.CreatedAt))
                .ForMember(d => d.Menu, opt => opt.MapFrom<MenuResolver>())
                .ForMember(d => d.ButtonIds, opt => opt.MapFrom<ButtonIdsResolver>());

            CreateMap<RoleCreationDto, Role>()
                .ForMember(d => d.Menus, opt => opt.Ignore());

            CreateMap<RoleUpdateDto, Role>()
                .ForMember(d => d.Menus, opt => opt.Ignore());

            CreateMap<RoleUpdateStatusDto, Role>();
        }
    }

    public class MenuResolver : IValueResolver<Role, RoleDto, string>
    {
        public string Resolve(Role source, RoleDto destination, string destMember, ResolutionContext context)
        {
            if(source.Menus.Any())
            {
                return string.Join(',', source.Menus.Select(rm => rm.Menu.Title).Distinct().ToArray());
            }
            return string.Empty;
        }
    }

    public class ButtonIdsResolver : IValueResolver<Role, RoleDto, List<Guid>>
    {
        public List<Guid> Resolve(Role source, RoleDto destination, List<Guid> destMember, ResolutionContext context)
        {
            if (source.Menus.Any())
            {
                return source.Menus.Select(rm => rm.ButtonId).ToList();
            }
            return new List<Guid>();
        }
    }
}
