using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Application;

namespace Megarobo.KunPengLIMS.Application.DepartmentApp.Dtos
{
    public class DepartmentDtoList:DtoList<DepartmentDto>
    {
        public DepartmentDtoList(IEnumerable<DepartmentDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
