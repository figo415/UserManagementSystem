using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;

namespace Megarobo.KunPengLIMS.Application.DepartmentApp.Dtos
{
    public class DepartmentProfile:Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Department, DepartmentDto>().ForMember(d => d.CreateTime, opt => opt.MapFrom(s => s.CreatedAt));
            CreateMap<DepartmentCreationDto, Department>();
            CreateMap<DepartmentUpdateDto, Department>();
            CreateMap<DepartmentUpdateStatusDto, Department>();
        }
    }
}
