using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class SpeciesDtoList:DtoList<SpeciesDto>
    {
        public SpeciesDtoList(IEnumerable<SpeciesDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
