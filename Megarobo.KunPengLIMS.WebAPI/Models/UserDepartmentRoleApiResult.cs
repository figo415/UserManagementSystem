using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class UserDepartmentRoleApiResult: ApiResult<UserDepartmentRoleDtoList>
    {
        public static UserDepartmentRoleApiResult Succeed(IEnumerable<UserDepartmentRoleDto> dtos, int totalCount)
        {
            var result = new UserDepartmentRoleApiResult();
            result.Data = new UserDepartmentRoleDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
