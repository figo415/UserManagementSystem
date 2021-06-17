using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.SkillApp.Dtos
{
    public class SkillCreationDto
    {
        public string SkillName { get; set; }

        public Guid ParentID { get; set; }

        public int OrdinalNumber { get; set; }

        public bool IsActive { get; set; }
    }
}
