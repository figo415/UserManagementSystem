using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.Application.Profiles
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<UserDepartmentRole, DepartmentIdRoleId>()
                .ForMember(d => d.DepartmentId, opt => opt.MapFrom(s => s.DepartmentID))
                .ForMember(d => d.RoleId, opt => opt.MapFrom(s => s.RoleID));

            CreateMap<User, UserDto>()
                .ForMember(d => d.Skill, opt => opt.MapFrom<SkillResolver>())
                .ForMember(d=>d.SkillIds,opt=>opt.MapFrom<SkillIdResolver>())
                .ForMember(d => d.CreateTime, opt => opt.MapFrom(s => s.CreatedAt))
                .ForMember(d => d.DepartmentRoleIds, opt => opt.MapFrom(s => s.DepartmentRoles));

            CreateMap<UserCreationDto, User>()
                .ForMember(d => d.WorkTime, opt => opt.MapFrom<WorkTime1Resolver>());

            CreateMap<UserUpdateDto, User>()
                .ForMember(d => d.WorkTime, opt => opt.MapFrom<WorkTime2Resolver>());

            CreateMap<UserUpdatePasswordDto, User>();

            CreateMap<UserUpdateStatusDto, User>();
        }
    }

    public class SkillResolver : IValueResolver<User, UserDto, string>
    {
        public string Resolve(User source, UserDto destination, string destMember, ResolutionContext context)
        {
            if(source.Skills.Any())
            {
                return string.Join(',', source.Skills.Select(s => s.Skill.SkillName).ToArray());
            }
            return string.Empty;
        }
    }

    public class SkillIdResolver : IValueResolver<User, UserDto, List<Guid>>
    {
        public List<Guid> Resolve(User source, UserDto destination, List<Guid> destMember, ResolutionContext context)
        {
            if(source.Skills.Any())
            {
                return source.Skills.Select(s => s.SkillID).ToList();
            }
            return new List<Guid>();
        }
    }

    public class WorkTime1Resolver : IValueResolver<UserCreationDto, User, string>
    {
        public string Resolve(UserCreationDto source, User destination, string destMember, ResolutionContext context)
        {
            if(source.WorkTime.Any())
            {
                return string.Join(',', source.WorkTime.ToArray());
            }
            return string.Empty;
        }
    }

    public class WorkTime2Resolver : IValueResolver<UserUpdateDto, User, string>
    {
        public string Resolve(UserUpdateDto source, User destination, string destMember, ResolutionContext context)
        {
            if (source.WorkTime.Any())
            {
                return string.Join(',', source.WorkTime.ToArray());
            }
            return string.Empty;
        }
    }
}
