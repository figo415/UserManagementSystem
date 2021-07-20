using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class NodeApiResult:ApiResult<NodeDtoList>
    {
        public static NodeApiResult Succeed(IEnumerable<NodeDto> dtos, int totalCount)
        {
            var result = new NodeApiResult();
            result.Data = new NodeDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
