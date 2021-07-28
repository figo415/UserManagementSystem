using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class SterilityDetectionDtoList:DtoList<SterilityDetectionDto>
    {
        public SterilityDetectionDtoList(IEnumerable<SterilityDetectionDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
