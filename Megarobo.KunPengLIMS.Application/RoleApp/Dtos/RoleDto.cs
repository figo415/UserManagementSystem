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

        [Required(ErrorMessage = "角色名称不能为空。")]
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreateTime { get; set; }

        public List<MenuDto> Menus { get; set; }
    }
}
