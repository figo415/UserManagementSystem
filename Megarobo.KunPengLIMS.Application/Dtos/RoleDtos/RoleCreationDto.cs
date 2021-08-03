using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class RoleCreationDto
    {
        [Required(ErrorMessage = "角色名称不能为空")]
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public List<Guid> ButtonIds { get; set; }
    }
}
