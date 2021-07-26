//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace Megarobo.KunPengLIMS.Domain.Entities
//{
//    [Description("Solution与ReagentDosage多对多关系")]
//    public class SolutionReagentDosage
//    {
//        public Guid SolutionId { get; set; }

//        public Guid ReagentDosageId { get; set; }

//        [ForeignKey("SolutionId")]
//        public virtual Solution Solution { get; set; }

//        [ForeignKey("ReagentDosageId")]
//        public virtual ReagentDosage ReagentDosage { get; set; }
//    }
//}
