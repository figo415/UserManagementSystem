using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    [Description("Role与OpButton多对多关系")]
    public class RoleButton
    {
        public Guid RoleId { get; set; }

        public Guid ButtonId { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

        [ForeignKey("ButtonId")]
        public virtual OpButton Button { get; set; }
    }
}
