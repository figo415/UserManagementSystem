using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class SampleDtoList:DtoList<SampleDto>
    {
        public SampleDtoList(IEnumerable<SampleDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
