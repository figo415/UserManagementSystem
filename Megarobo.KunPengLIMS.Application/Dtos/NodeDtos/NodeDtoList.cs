using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class NodeDtoList:DtoList<NodeDto>
    {
        public NodeDtoList(IEnumerable<NodeDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
