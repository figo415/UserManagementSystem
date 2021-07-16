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
        public Guid UserId { get; set; }

        public Guid DepartmentId { get; set; }

        public Guid RoleId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }
    }
}
