using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    [Description("Role与Menu多对多关系")]
    public class RoleMenu
    {
        public Guid RoleID { get; set; }

        public Guid MenuID { get; set; }

        [ForeignKey("RoleID")]
        public virtual Role Role { get; set; }

        [ForeignKey("MenuID")]
        public virtual Menu Menu { get; set; }
    }
}
