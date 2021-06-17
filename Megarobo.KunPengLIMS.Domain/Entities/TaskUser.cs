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
        public Guid TaskID { get; set; }

        public Guid UserID { get; set; }

        [ForeignKey("TaskID")]
        public virtual Task Task { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }
    }
}
