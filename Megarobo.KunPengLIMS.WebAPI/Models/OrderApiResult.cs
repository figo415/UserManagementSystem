using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class OrderApiResult: ApiResult<OrderDtoList>
    {
        public static OrderApiResult Succeed(IEnumerable<OrderDto> dtos, int totalCount)
        {
            var result = new OrderApiResult();
            result.Data = new OrderDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
