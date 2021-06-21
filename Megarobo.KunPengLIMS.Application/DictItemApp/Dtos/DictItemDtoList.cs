using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.DictItemApp.Dtos
{
    public class DictItemDtoList:DtoList<DictItemDto>
    {
        public DictItemDtoList(IEnumerable<DictItemDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
