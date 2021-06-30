using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class PositionDtoList:DtoList<PositionDto>
    {
        public PositionDtoList(IEnumerable<PositionDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
