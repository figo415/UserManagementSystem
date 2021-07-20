using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class UserApiResult: ApiResult<UserDtoList>
    {
        public static UserApiResult Succeed(IEnumerable<UserDto> dtos, int totalCount)
        {
            var result = new UserApiResult();
            result.Data = new UserDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
