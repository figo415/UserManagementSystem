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
        public Guid ReagentId { get; set; }

        public Guid PositionId { get; set; }

        [ForeignKey("ReagentId")]
        public virtual Reagent Reagent { get; set; }

        [ForeignKey("PositionId")]
        public virtual Position Position { get; set; }
    }
}
