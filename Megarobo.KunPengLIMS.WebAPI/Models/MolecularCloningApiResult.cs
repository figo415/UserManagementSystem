using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class MolecularCloningApiResult:ApiResult<MolecularCloningDtoList>
    {
        public static MolecularCloningApiResult Succeed(IEnumerable<MolecularCloningDto> dtos, int totalCount)
        {
            var result = new MolecularCloningApiResult();
            result.Data = new MolecularCloningDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}
