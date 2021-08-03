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
        public Guid RoleId { get; set; }

        public Guid MenuId { get; set; }

        public Guid ButtonId { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

        [ForeignKey("MenuId")]
        public virtual Menu Menu { get; set; }

        //public string Buttons { get; set; }
        [ForeignKey("ButtonId")]
        public virtual Button Button { get; set; }
    }
}
