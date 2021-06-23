using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class SkillDtoList:DtoList<SkillDto>
    {
        public SkillDtoList(IEnumerable<SkillDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
