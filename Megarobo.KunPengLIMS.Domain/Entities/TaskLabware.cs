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
        public Guid TaskID { get; set; }

        public Guid LabwareID { get; set; }

        [ForeignKey("TaskID")]
        public virtual Task Task { get; set; }

        [ForeignKey("LabwareID")]
        public virtual Labware Labware { get; set; }
    }
}
