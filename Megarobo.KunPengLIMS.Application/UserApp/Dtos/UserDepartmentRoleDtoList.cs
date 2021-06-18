using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Application;

namespace Megarobo.KunPengLIMS.Application.UserApp.Dtos
{
    public class UserDepartmentRoleDtoList:DtoList<UserDepartmentRoleDto>
    {
        public UserDepartmentRoleDtoList(IEnumerable<UserDepartmentRoleDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
