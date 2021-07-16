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
        public Guid SolutionId { get; set; }

        public Guid SampleDosageId { get; set; }

        [ForeignKey("SolutionId")]
        public virtual Solution Solution { get; set; }

        [ForeignKey("SampleDosageId")]
        public virtual SampleDosage SampleDosage { get; set; }
    }
}
