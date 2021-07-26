using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    public class Shipment:AuditableEntity
    {
        /// <summary>
        /// 发货日期
        /// </summary>
        public DateTime ShipmentDate { get; set; }

        /// <summary>
        /// 邮寄地址
        /// </summary>
        public string DeliveryAddress { get; set; }

        /// <summary>
        /// 状态：待发货，已发货
        /// </summary>
        public string Status { get; set; }

        public Guid OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }
    }
}
