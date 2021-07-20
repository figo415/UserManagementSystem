using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class ProjectApiResult:ApiResult<ProjectDtoList>
    {
        public static ProjectApiResult Succeed(IEnumerable<ProjectDto> dtos, int totalCount)
        {
            var result = new ProjectApiResult();
            result.Data = new ProjectDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
