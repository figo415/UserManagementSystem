using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;

namespace Megarobo.KunPengLIMS.Application.UserApp.Dtos
{
    public class UserUpdateDto
    {
        public string UserName { get; set; }

        public string EMail { get; set; }

        public string MobileNumber { get; set; }

        public List<string> WorkTime { get; set; }

        public bool IsActive { get; set; }

        public List<Guid> SkillIds { get; set; }

        public List<DepartmentIdRoleId> DepartmentRoleIds { get; set; }
    }
}
