using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class DictItemApiResult:ApiResult<DictItemDtoList>
    {
        public static DictItemApiResult Succeed(IEnumerable<DictItemDto> dtos, int totalCount)
        {
            var result = new DictItemApiResult();
            result.Data = new DictItemDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
