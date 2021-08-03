using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    public class Button:Entity
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public Guid MenuId { get; set; }

        [ForeignKey("MenuId")]
        public virtual Menu Menu { get; set; }

        public virtual ICollection<RoleMenu> RoleMenus { get; set; }
    }
}
