using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class UserDto
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string EMail { get; set; }

        public string MobileNumber { get; set; }

        public List<string> WorkTime { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreateTime { get; set; }

        public List<DepartmentIdRoleId> DepartmentRoleIds { get; set; }

        public string Skill { get; set; }

        public List<Guid> SkillIds { get; set; }
    }
}
