using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace Megarobo.KunPengLIMS.Domain.Entities
{
    /// <summary>
    /// 角色
    /// 与UserDepartmentRole一对多
    /// 与Menu多对多
    /// </summary>
    public class Role : AuditableEntity
    {
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<UserDepartmentRole> UserDepartments { get; set; }

        public virtual ICollection<RoleMenu> Menus { get; set; }
    }
}
