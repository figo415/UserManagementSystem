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
        public Guid ProjectID { get; set; }

        public Guid TaskID { get; set; }

        [ForeignKey("ProjectID")]
        public virtual Project Project { get; set; }

        [ForeignKey("TaskID")]
        public virtual Task Task { get; set; }
    }
}
