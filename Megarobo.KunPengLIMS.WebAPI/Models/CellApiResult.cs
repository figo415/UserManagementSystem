﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    public class CellApiResult:ApiResult<CellDtoList>
    {
        public static CellApiResult Succeed(IEnumerable<CellDto> dtos, int totalCount)
        {
            var result = new CellApiResult();
            result.Data = new CellDtoList(dtos);
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = totalCount;
            return result;
        }
    }
}