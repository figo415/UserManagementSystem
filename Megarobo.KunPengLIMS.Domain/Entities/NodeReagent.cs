using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    [Description("Node与Reagent多对多关系")]
    public class NodeReagent
    {
        public Guid NodeID { get; set; }

        public Guid ReagentID { get; set; }

        [ForeignKey("NodeID")]
        public virtual Node Node { get; set; }

        [ForeignKey("ReagentID")]
        public virtual Reagent Reagent { get; set; }
    }
}
