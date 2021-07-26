using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    [Description("Task与User多对多关系")]
    public class TaskUser
    {
        public Guid TaskId { get; set; }

        public Guid UserId { get; set; }

        [ForeignKey("TaskId")]
        public virtual Task Task { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
