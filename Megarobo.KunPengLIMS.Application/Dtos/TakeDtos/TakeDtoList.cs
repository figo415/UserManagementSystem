using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class TakeDtoList:DtoList<TakeDto>
    {
        public TakeDtoList(IEnumerable<TakeDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
