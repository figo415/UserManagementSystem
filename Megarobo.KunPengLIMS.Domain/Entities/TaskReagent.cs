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
        public Guid TaskID { get; set; }

        public Guid ReagentID { get; set; }

        [ForeignKey("TaskID")]
        public virtual Task Task { get; set; }

        [ForeignKey("ReagentID")]
        public virtual Reagent Reagent { get; set; }
    }
}
