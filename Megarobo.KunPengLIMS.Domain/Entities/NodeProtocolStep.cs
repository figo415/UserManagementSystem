using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    [Description("Node与ProtocolStep多对多关系")]
    public class NodeProtocolStep
    {
        public Guid NodeID { get; set; }

        public Guid ProtocolStepID { get; set; }

        [ForeignKey("NodeID")]
        public virtual Node Node { get; set; }

        [ForeignKey("ProtocolStepID")]
        public virtual ProtocolStep ProtocolStep { get; set; }
    }
}
