using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class StockInApiResult : ApiResult<StockInDtoList>
    {
        public static StockInApiResult Succeed(IEnumerable<StockInDto> dtos, int totalCount)
        {
            var result = new StockInApiResult();
            result.Data = new StockInDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
