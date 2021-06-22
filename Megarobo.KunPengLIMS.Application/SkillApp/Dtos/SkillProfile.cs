using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;

namespace Megarobo.KunPengLIMS.Application.SkillApp.Dtos
{
    public class SkillProfile:Profile
    {
        public SkillProfile()
        {
            CreateMap<Skill, SkillDto>().ForMember(d => d.CreateTime, opt => opt.MapFrom(s => s.CreatedAt));
            CreateMap<SkillCreationDto, Skill>();
            CreateMap<SkillUpdateDto, Skill>();
        }
    }
}
