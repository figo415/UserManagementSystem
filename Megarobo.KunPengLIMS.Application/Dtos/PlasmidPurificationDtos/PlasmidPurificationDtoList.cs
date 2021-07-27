using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class PlasmidPurificationDtoList:DtoList<PlasmidPurificationDto>
    {
        public PlasmidPurificationDtoList(IEnumerable<PlasmidPurificationDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
