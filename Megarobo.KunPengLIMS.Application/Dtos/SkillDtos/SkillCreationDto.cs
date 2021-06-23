using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class SkillCreationDto
    {
        [Required(ErrorMessage ="请提供上级技能")]
        public Guid ParentId { get; set; }

        [Required(ErrorMessage ="技能名称不能为空")]
        public string SkillName { get; set; }

        

        //public int OrdinalNumber { get; set; }

        //public bool IsActive { get; set; }
    }
}
