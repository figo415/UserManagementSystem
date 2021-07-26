//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace Megarobo.KunPengLIMS.Domain.Entities
//{
//    [Description("Device与Position多对多关系")]
//    public class DevicePosition
//    {
//        public Guid DeviceId { get; set; }

//        public Guid PositionId { get; set; }

//        [ForeignKey("DeviceId")]
//        public virtual Device Device { get; set; }

//        [ForeignKey("PositionId")]
//        public virtual Position Position { get; set; }
//    }
//}
