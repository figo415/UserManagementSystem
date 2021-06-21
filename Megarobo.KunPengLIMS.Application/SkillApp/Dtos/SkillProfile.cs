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
            CreateMap<Skill, SkillDto>();
            CreateMap<SkillCreationDto, Skill>();
            CreateMap<SkillUpdateDto, Skill>();
        }
    }
}
