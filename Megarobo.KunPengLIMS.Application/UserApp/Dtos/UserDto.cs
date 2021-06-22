﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.SkillApp.Dtos;
using Megarobo.KunPengLIMS.Application.DepartmentApp.Dtos;
using Megarobo.KunPengLIMS.Application.RoleApp.Dtos;
using Megarobo.KunPengLIMS.Domain.Entities;

namespace Megarobo.KunPengLIMS.Application.UserApp.Dtos
{
    public class UserDto
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string EMail { get; set; }

        public string MobileNumber { get; set; }

        //public List<Period> WorkTimes { get; set; }
        public string WorkTime { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreateTime { get; set; }

        public List<DepartmentIdRoleId> DepartmentRoleIds { get; set; }

        public string Skill { get; set; }

        public List<Guid> SkillIds { get; set; }
    }
}
