using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class LabwareDtoList:DtoList<LabwareDto>
    {
        public LabwareDtoList(IEnumerable<LabwareDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
