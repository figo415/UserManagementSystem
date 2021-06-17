using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    [Description("Solution与SampleDosage多对多关系")]
    public class SolutionSampleDosage
    {
        public Guid SolutionID { get; set; }

        public Guid SampleDosageID { get; set; }

        [ForeignKey("SolutionID")]
        public virtual Solution Solution { get; set; }

        [ForeignKey("SampleDosageID")]
        public virtual SampleDosage SampleDosage { get; set; }
    }
}
