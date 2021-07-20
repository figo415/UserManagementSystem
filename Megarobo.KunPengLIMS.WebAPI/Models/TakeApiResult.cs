using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class TakeApiResult: ApiResult<TakeDtoList>
    {
        public static TakeApiResult Succeed(IEnumerable<TakeDto> dtos, int totalCount)
        {
            var result = new TakeApiResult();
            result.Data = new TakeDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
