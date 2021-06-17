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
        public Guid TaskID { get; set; }

        public Guid SampleID { get; set; }

        [ForeignKey("TaskID")]
        public virtual Task Task { get; set; }

        [ForeignKey("SampleID")]
        public virtual Sample Sample { get; set; }
    }
}
