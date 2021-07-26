using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    [Description("Project和Task多对多关系")]
    public class ProjectTask
    {
        public Guid ProjectId { get; set; }

        public Guid TaskId { get; set; }

        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }

        [ForeignKey("TaskId")]
        public virtual Task Task { get; set; }
    }
}
