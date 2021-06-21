﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.MenuApp.Dtos;

namespace Megarobo.KunPengLIMS.Application.RoleApp.Dtos
{
    public class RoleDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreateTime { get; set; }

        //public List<MenuDto> Menus { get; set; }
        public string Menus { get; set; }
    }
}
