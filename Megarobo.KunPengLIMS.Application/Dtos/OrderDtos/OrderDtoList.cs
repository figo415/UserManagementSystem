using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class OrderDtoList:DtoList<OrderDto>
    {
        public OrderDtoList(IEnumerable<OrderDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
