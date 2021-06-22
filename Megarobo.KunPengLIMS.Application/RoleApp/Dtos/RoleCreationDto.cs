using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Megarobo.KunPengLIMS.Application.MenuApp.Dtos;

namespace Megarobo.KunPengLIMS.Application.RoleApp.Dtos
{
    public class RoleCreationDto
    {
        [Required(ErrorMessage = "角色名称不能为空")]
        public string Name { get; set; }

        public bool IsActive { get; set; }

        //public List<MenuDto> Menus { get; set; }
        public string Menus { get; set; }
    }
}
