using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.SkillApp.Dtos
{
    public class SkillUpdateDto
    {
        public Guid ParentId { get; set; }

        public string SkillName { get; set; }

        //public int OrdinalNumber { get; set; }

        //public bool IsActive { get; set; }
    }
}
