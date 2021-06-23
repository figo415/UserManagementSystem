using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class DepartmentDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Manager { get; set; }

        public string ContactNumber { get; set; }

        public int OrdinalNumber { get; set; }

        public bool IsActive { get; set; }

        public Guid ParentId { get; set; }

        public DateTime CreateTime { get; set; }

        public List<DepartmentDto> Children { get; set; }
    }
}
