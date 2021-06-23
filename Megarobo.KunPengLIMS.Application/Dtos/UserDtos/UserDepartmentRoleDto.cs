using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class UserDepartmentRoleDto
    {
        public DepartmentDto Department { get; set; }

        public RoleDto Role { get; set; }
    }
}
