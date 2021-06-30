using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class CellDtoList:DtoList<CellDto>
    {
        public CellDtoList(IEnumerable<CellDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
