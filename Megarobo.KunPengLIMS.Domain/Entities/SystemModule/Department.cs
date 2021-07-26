using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    /// <summary>
    /// 部门
    /// 与UserDepartmentRole一对多
    /// </summary>
    public class Department:AuditableEntity
    {
        public string Name { get; set; }

        public string Manager { get; set; }

        public string ContactNumber { get; set; }

        public int OrdinalNumber { get; set; }

        public bool IsActive { get; set; }

        public Guid ParentId { get; set; }

        public virtual ICollection<UserDepartmentRole> UserRoles { get; set; }
    }
}
