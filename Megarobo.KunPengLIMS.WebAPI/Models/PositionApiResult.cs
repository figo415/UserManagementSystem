using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class PositionApiResult:ApiResult<LocationDtoList>
    {
        public static PositionApiResult Succeed(IEnumerable<LocationDto> dtos, int totalCount)
        {
            var result = new PositionApiResult();
            result.Data = new LocationDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
