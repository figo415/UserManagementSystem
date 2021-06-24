using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class RoleUpdateDto
    {
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public List<Guid> MenuIds { get; set; }
    }
}
