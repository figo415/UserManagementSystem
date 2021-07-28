using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class SdsPageDetectionDtoList:DtoList<SdsPageDetectionDto>
    {
        public SdsPageDetectionDtoList(IEnumerable<SdsPageDetectionDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
