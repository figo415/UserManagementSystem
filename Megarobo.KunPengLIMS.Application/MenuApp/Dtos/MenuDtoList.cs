﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.MenuApp.Dtos
{
    public class MenuDtoList:DtoList<MenuDto>
    {
        public MenuDtoList(IEnumerable<MenuDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
