using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class ReagentApiResult:ApiResult<ReagentDtoList>
    {
        public static ReagentApiResult Succeed(IEnumerable<ReagentDto> dtos, int totalCount)
        {
            var result = new ReagentApiResult();
            result.Data = new ReagentDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
