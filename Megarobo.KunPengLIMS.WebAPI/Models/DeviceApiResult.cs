using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class DeviceApiResult:ApiResult<DeviceDtoList>
    {
        public static DeviceApiResult Succeed(IEnumerable<DeviceDto> dtos, int totalCount)
        {
            var result = new DeviceApiResult();
            result.Data = new DeviceDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
