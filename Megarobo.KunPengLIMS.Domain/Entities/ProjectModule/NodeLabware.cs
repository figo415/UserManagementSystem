using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    [Description("Node与Labware多对多关系")]
    public class NodeLabware
    {
        public Guid NodeId { get; set; }

        public Guid LabwareId { get; set; }

        [ForeignKey("NodeId")]
        public virtual Node Node { get; set; }

        [ForeignKey("LabwareId")]
        public virtual Labware Labware { get; set; }
    }
}
