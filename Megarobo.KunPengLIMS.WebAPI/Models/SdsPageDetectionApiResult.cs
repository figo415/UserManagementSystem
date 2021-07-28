using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class SdsPageDetectionApiResult : ApiResult<SdsPageDetectionDtoList>
    {
        public static SdsPageDetectionApiResult Succeed(IEnumerable<SdsPageDetectionDto> dtos, int totalCount)
        {
            var result = new SdsPageDetectionApiResult();
            result.Data = new SdsPageDetectionDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
