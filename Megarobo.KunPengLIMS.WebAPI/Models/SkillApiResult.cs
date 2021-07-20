using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class SkillApiResult:ApiResult<SkillDtoList>
    {
        public static SkillApiResult Succeed(IEnumerable<SkillDto> dtos, int totalCount)
        {
            var result = new SkillApiResult();
            result.Data = new SkillDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
