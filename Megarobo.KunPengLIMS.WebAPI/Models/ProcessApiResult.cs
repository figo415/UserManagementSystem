using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class ProcessApiResult:ApiResult<ProcessDtoList>
    {
        public static ProcessApiResult Succeed(IEnumerable<ProcessDto> dtos, int totalCount)
        {
            var result = new ProcessApiResult();
            result.Data = new ProcessDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
