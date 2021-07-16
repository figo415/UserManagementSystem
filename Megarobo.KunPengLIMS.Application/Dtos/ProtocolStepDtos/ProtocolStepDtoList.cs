using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class ProtocolStepDtoList:DtoList<ProtocolStepDto>
    {
        public ProtocolStepDtoList(IEnumerable<ProtocolStepDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
