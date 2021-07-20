using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class ProtocolStepApiResult:ApiResult<ProtocolStepDtoList>
    {
        public static ProtocolStepApiResult Succeed(IEnumerable<ProtocolStepDto> dtos, int totalCount)
        {
            var result = new ProtocolStepApiResult();
            result.Data = new ProtocolStepDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
