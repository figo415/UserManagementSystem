using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class LocationDtoList:DtoList<LocationDto>
    {
        public LocationDtoList(IEnumerable<LocationDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
