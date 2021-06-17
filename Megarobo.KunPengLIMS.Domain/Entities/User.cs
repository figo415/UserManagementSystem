using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    /// <summary>
    /// 用户
    /// 与Skill多对多
    /// 与UserDepartmentRole一对多
    /// 与Project一对多
    /// 与Task多对多
    /// </summary>
    public class User : AuditableEntity
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string EMail { get; set; }

        public string MobileNumber { get; set; }

        //工作时间，嵌入值对象：时间区间
        public Period WorkTime { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<UserDepartmentRole> DepartmentRoles { get; set; }

        public virtual ICollection<UserSkill> Skills { get; set; }

        public virtual ICollection<Project> ManagerProjects { get; set; }

        public virtual ICollection<Project> ARDProjects { get; set; }

        public virtual ICollection<Project> FRDProjects { get; set; }

        public virtual ICollection<Project> SRDProjects { get; set; }

        public virtual ICollection<TaskUser> Tasks { get; set; }
    }
}
