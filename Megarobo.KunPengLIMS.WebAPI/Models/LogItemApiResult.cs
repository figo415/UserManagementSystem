using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class LogItemApiResult:ApiResult<LogItemDtoList>
    {
        public static LogItemApiResult Succeed(IEnumerable<LogItemDto> dtos, int totalCount)
        {
            var result = new LogItemApiResult();
            result.Data = new LogItemDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
