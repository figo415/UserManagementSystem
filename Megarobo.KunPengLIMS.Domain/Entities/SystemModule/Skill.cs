using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    /// <summary>
    /// 技能
    /// 与User多对多
    /// </summary>
    public class Skill : AuditableEntity
    {
        public string SkillName { get; set; }

        public Guid ParentId { get; set; }

        public int OrdinalNumber { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<UserSkill> Users { get; set; }

        public virtual ICollection<Node> Nodes { get; set; }
    }
}
