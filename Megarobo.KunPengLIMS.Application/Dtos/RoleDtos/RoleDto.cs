using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class RoleDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreateTime { get; set; }

        public string Menu { get; set; }

        public List<Guid> MenuIds { get; set; }
    }
}
