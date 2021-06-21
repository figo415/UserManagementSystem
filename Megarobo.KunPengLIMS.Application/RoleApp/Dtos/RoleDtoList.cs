﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.RoleApp.Dtos
{
    public class RoleDtoList:DtoList<RoleDto>
    {
        public RoleDtoList(IEnumerable<RoleDto> dtos)
        {
            ObjectList = dtos;
        }
    }
}
