using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    [Description("User和Skill多对多关系")]
    public class UserSkill
    {
        public Guid UserID { get; set; }

        public Guid SkillID { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        [ForeignKey("SkillID")]
        public virtual Skill Skill { get; set; }
    }
}
