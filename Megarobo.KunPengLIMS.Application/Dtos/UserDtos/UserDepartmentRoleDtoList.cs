using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class UserDepartmentRoleDtoList:DtoList<UserDepartmentRoleDto>
    {
        public UserDepartmentRoleDtoList(IEnumerable<UserDepartmentRoleDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
