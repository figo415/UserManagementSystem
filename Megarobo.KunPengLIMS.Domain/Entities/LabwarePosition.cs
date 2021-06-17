using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    [Description("Labware与Position多对多关系")]
    public class LabwarePosition
    {
        public Guid LabwareID { get; set; }

        public Guid PositionID { get; set; }

        [ForeignKey("LabwareID")]
        public virtual Labware Labware { get; set; }

        [ForeignKey("PositionID")]
        public virtual Position Position { get; set; }
    }
}
