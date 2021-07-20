using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class LabwareApiResult:ApiResult<LabwareDtoList>
    {
        public static LabwareApiResult Succeed(IEnumerable<LabwareDto> dtos, int totalCount)
        {
            var result = new LabwareApiResult();
            result.Data = new LabwareDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
