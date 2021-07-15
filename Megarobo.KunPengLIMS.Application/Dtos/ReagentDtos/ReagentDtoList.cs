using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class ReagentDtoList:DtoList<ReagentDto>
    {
        public ReagentDtoList(IEnumerable<ReagentDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
