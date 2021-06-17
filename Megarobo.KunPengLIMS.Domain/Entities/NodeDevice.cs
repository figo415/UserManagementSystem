using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    [Description("Node与Device多对多关系")]
    public class NodeDevice
    {
        public Guid NodeID { get; set; }

        public Guid DeviceID { get; set; }

        [ForeignKey("NodeID")]
        public virtual Node Node { get; set; }

        [ForeignKey("DeviceID")]
        public virtual Device Device { get; set; }
    }
}
