using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.SkillApp.Dtos
{
    public class SkillDto
    {
        public Guid Id { get; set; }

        public string SkillName { get; set; }

        public Guid ParentId { get; set; }

        public int OrdinalNumber { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreateTime { get; set; }

        public List<SkillDto> Children { get; set; }
    }
}
