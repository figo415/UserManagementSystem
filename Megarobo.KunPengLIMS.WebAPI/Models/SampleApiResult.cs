using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class SampleApiResult:ApiResult<SampleDtoList>
    {
        public static SampleApiResult Succeed(IEnumerable<SampleDto> dtos, int totalCount)
        {
            var result = new SampleApiResult();
            result.Data = new SampleDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
