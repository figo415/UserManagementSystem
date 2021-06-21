﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.LogItemApp.Dtos
{
    public class LogItemDtoList:DtoList<LogItemDto>
    {
        public LogItemDtoList(IEnumerable<LogItemDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
