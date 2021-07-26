//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace Megarobo.KunPengLIMS.Domain.Entities
//{
//    [Description("Labware与Position多对多关系")]
//    public class LabwarePosition
//    {
//        public Guid LabwareId { get; set; }

//        public Guid PositionId { get; set; }

//        [ForeignKey("LabwareId")]
//        public virtual Labware Labware { get; set; }

//        [ForeignKey("PositionId")]
//        public virtual Position Position { get; set; }
//    }
//}
