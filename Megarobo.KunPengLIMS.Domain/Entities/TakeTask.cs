using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    [Description("Take与Task多对多关系")]
    public class TakeTask
    {
        public Guid TakeId { get; set; }

        public Guid TaskId { get; set; }

        [ForeignKey("TakeId")]
        public virtual Take Take { get; set; }

        [ForeignKey("TaskId")]
        public virtual Task Task { get; set; }
    }
}
