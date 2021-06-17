using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    [Description("User、Department和Role三方关系")]
    public class UserDepartmentRole
    {
        public Guid UserID { get; set; }

        public Guid DepartmentID { get; set; }

        public Guid RoleID { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }

        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }

        [ForeignKey("RoleID")]
        public Role Role { get; set; }
    }
}
