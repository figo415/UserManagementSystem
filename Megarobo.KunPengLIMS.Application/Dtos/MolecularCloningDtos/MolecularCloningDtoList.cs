using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class MolecularCloningDtoList:DtoList<MolecularCloningDto>
    {
        public MolecularCloningDtoList(IEnumerable<MolecularCloningDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
