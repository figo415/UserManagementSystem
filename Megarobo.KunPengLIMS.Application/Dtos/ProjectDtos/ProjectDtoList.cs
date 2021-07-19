using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class ProjectDtoList:DtoList<ProjectDto>
    {
        public ProjectDtoList(IEnumerable<ProjectDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
