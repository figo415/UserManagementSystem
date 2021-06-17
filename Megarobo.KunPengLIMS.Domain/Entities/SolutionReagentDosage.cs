using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    [Description("Solution与ReagentDosage多对多关系")]
    public class SolutionReagentDosage
    {
        public Guid SolutionID { get; set; }

        public Guid ReagentDosageID { get; set; }

        [ForeignKey("SolutionID")]
        public virtual Solution Solution { get; set; }

        [ForeignKey("ReagentDosageID")]
        public virtual ReagentDosage ReagentDosage { get; set; }
    }
}
