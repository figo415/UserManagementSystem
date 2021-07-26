using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    /// <summary>
    /// 操作按钮
    /// </summary>
    public class OpButton:Entity
    {
        public string Name { get; set; }

        public virtual ICollection<RoleButton> Roles { get; set; }
    }
}
