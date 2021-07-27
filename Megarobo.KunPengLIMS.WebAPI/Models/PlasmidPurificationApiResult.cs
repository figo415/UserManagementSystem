using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class PlasmidPurificationApiResult:ApiResult<PlasmidPurificationDtoList>
    {
        public static PlasmidPurificationApiResult Succeed(IEnumerable<PlasmidPurificationDto> dtos, int totalCount)
        {
            var result = new PlasmidPurificationApiResult();
            result.Data = new PlasmidPurificationDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
