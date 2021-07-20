using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class DepartmentApiResult:ApiResult<DepartmentDtoList>
    {
        public static DepartmentApiResult Succeed(IEnumerable<DepartmentDto> dtos, int totalCount)
        {
            var result = new DepartmentApiResult();
            result.Data = new DepartmentDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
