using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class DepartmentDtoList:DtoList<DepartmentDto>
    {
        public DepartmentDtoList(IEnumerable<DepartmentDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
