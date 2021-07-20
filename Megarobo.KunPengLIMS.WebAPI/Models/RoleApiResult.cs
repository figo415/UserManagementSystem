using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class RoleApiResult:ApiResult<RoleDtoList>
    {
        public static RoleApiResult Succeed(IEnumerable<RoleDto> dtos, int totalCount)
        {
            var result = new RoleApiResult();
            result.Data = new RoleDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
