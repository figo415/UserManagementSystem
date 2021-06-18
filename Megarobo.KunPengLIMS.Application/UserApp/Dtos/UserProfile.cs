using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;

namespace Megarobo.KunPengLIMS.Application.UserApp.Dtos
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>().ForMember(d => d.Skill, MapSkill);
            CreateMap<UserCreationDto, User>();
            CreateMap<UserUpdateDto, User>();
            CreateMap<UserUpdatePasswordDto, User>();
            CreateMap<UserUpdateStatusDto, User>();
        }

        private void MapSkill(IMemberConfigurationExpression<User, UserDto, string> opt)
        {
            //opt.MapFrom(s => s.Skills);
            opt.ConvertUsing( new SkillConverter());
        }
    }

    public class SkillConverter : IValueConverter<List<Skill>,string>
    {
        public string Convert(List<Skill> sourceMember, ResolutionContext context)
        {
            if(!sourceMember.Any())
            {
                return string.Empty;
            }
            return string.Join(',', sourceMember.Select(s => s.SkillName));
        }
    }
}
