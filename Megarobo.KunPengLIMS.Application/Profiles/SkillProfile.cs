using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Profiles
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
