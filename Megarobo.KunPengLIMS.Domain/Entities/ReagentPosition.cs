using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    [Description("Reagent与Position多对多关系")]
    public class ReagentPosition
    {
        public Guid ReagentID { get; set; }

        public Guid PositionID { get; set; }

        [ForeignKey("ReagentID")]
        public virtual Reagent Reagent { get; set; }

        [ForeignKey("PositionID")]
        public virtual Position Position { get; set; }
    }
}
