using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class SterilityDetectionApiResult : ApiResult<SterilityDetectionDtoList>
    {
        public static SterilityDetectionApiResult Succeed(IEnumerable<SterilityDetectionDto> dtos, int totalCount)
        {
            var result = new SterilityDetectionApiResult();
            result.Data = new SterilityDetectionDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
