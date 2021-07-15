using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    [Description("Sample与Position多对多关系")]
    public class SamplePosition
    {
        public Guid SampleId { get; set; }

        public Guid PositionId { get; set; }

        [ForeignKey("SampleId")]
        public virtual Sample Sample { get; set; }

        [ForeignKey("PositionId")]
        public virtual Position Position { get; set; }
    }
}
