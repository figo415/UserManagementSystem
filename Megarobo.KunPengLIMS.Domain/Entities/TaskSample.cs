using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    [Description("Task与Sample多对多关系")]
    public class TaskSample
    {
        public Guid TaskId { get; set; }

        public Guid SampleId { get; set; }

        [ForeignKey("TaskId")]
        public virtual Task Task { get; set; }

        [ForeignKey("SampleId")]
        public virtual Sample Sample { get; set; }
    }
}
