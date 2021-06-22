using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;

namespace Megarobo.KunPengLIMS.Application.RoleApp.Dtos
{
    public class RoleProfile:Profile
    {
        public RoleProfile()
        {
            CreateMap<Role, RoleDto>().ForMember(d => d.CreateTime, opt => opt.MapFrom(s => s.CreatedAt));
            CreateMap<RoleCreationDto, Role>().ForMember(d => d.Menus, opt => opt.Ignore());
            CreateMap<RoleUpdateDto, Role>();
            CreateMap<RoleUpdateStatusDto, Role>();
        }
    }
}
