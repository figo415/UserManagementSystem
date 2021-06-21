using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Megarobo.KunPengLIMS.Application.MenuApp.Dtos;

namespace Megarobo.KunPengLIMS.Application.RoleApp.Dtos
{
    public class RoleUpdateDto
    {
        public string Name { get; set; }

        public bool IsActive { get; set; }

        //public List<MenuDto> Menus { get; set; }
        public string Menus { get; set; }
    }
}
