using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class QpcrDetectionApiResult : ApiResult<QpcrDetectionDtoList>
    {
        public static QpcrDetectionApiResult Succeed(IEnumerable<QpcrDetectionDto> dtos, int totalCount)
        {
            var result = new QpcrDetectionApiResult();
            result.Data = new QpcrDetectionDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
