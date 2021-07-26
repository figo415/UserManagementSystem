using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    [Description("Task与Labware多对多关系")]
    public class TaskLabware:Entity
    {
        public Guid TaskId { get; set; }

        public Guid LabwareId { get; set; }

        [ForeignKey("TaskId")]
        public virtual Task Task { get; set; }

        [ForeignKey("LabwareId")]
        public virtual Labware Labware { get; set; }
    }
}
