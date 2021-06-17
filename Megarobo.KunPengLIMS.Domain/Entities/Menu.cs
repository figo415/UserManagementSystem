using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    /// <summary>
    /// 菜单
    /// 与Role多对多
    /// </summary>
    public class Menu:AuditableEntity
    {
        public string Name { get; set; }

        // 类型：0目录；1页面，2按钮
        public int Type { get; set; }

        public Guid ParentId { get; set; }

        public string Code { get; set; }

        public string Url { get; set; }

        public int OrdinalNumber { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<RoleMenu> Roles { get; set; }
    }
}
