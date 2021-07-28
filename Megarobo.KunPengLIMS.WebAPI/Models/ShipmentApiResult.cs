using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class ShipmentApiResult : ApiResult<ShipmentDtoList>
    {
        public static ShipmentApiResult Succeed(IEnumerable<ShipmentDto> dtos, int totalCount)
        {
            var result = new ShipmentApiResult();
            result.Data = new ShipmentDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
