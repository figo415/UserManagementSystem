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
            CreateMap<Role, RoleDto>();
            CreateMap<RoleCreationDto, Role>();
            CreateMap<RoleUpdateDto, Role>();
            CreateMap<RoleUpdateStatusDto, Role>();
        }
    }
}
