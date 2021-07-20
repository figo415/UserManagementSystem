using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class SpeciesApiResult:ApiResult<SpeciesDtoList>
    {
        public static SpeciesApiResult Succeed(IEnumerable<SpeciesDto> dtos, int totalCount)
        {
            var result = new SpeciesApiResult();
            result.Data = new SpeciesDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
