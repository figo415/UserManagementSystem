using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class ProcessDtoList:DtoList<ProcessDto>
    {
        public ProcessDtoList(IEnumerable<ProcessDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
