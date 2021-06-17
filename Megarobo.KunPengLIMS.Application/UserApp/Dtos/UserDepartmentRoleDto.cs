using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Application.DepartmentApp.Dtos;
using Megarobo.KunPengLIMS.Application.RoleApp.Dtos;

namespace Megarobo.KunPengLIMS.Application.UserApp.Dtos
{
    public class UserDepartmentRoleDto
    {
        public DepartmentDto Department { get; set; }

        public RoleDto Role { get; set; }
    }
}
