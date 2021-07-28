using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class StockInDtoList:DtoList<StockInDto>
    {
        public StockInDtoList(IEnumerable<StockInDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
