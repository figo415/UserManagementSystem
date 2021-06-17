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
        public Guid TakeID { get; set; }

        public Guid TaskID { get; set; }

        [ForeignKey("TakeID")]
        public virtual Take Take { get; set; }

        [ForeignKey("TaskID")]
        public virtual Task Task { get; set; }
    }
}
