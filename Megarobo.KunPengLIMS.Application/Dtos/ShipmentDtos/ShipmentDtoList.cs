using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class ShipmentDtoList:DtoList<ShipmentDto>
    {
        public ShipmentDtoList(IEnumerable<ShipmentDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
