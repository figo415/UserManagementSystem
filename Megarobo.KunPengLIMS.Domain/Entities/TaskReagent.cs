using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    [Description("Task与Reagent多对多关系")]
    public class TaskReagent
    {
        public Guid TaskId { get; set; }

        public Guid ReagentId { get; set; }

        [ForeignKey("TaskId")]
        public virtual Task Task { get; set; }

        [ForeignKey("ReagentId")]
        public virtual Reagent Reagent { get; set; }
    }
}
