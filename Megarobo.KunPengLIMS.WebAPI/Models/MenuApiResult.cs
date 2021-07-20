using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class MenuApiResult:ApiResult<MenuDtoList>
    {
        public static MenuApiResult Succeed(IEnumerable<MenuDto> dtos, int totalCount)
        {
            var result = new MenuApiResult();
            result.Data = new MenuDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
