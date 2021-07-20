using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class StringListApiResult:ApiResult<StringDtoList>
    {
        public static StringListApiResult Succeed(IEnumerable<string> dtos, int totalCount)
        {
            var result = new StringListApiResult();
            result.Data = new StringDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
