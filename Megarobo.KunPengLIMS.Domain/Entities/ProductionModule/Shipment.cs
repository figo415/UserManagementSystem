using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using Megarobo.KunPengLIMS.Domain.Enums;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    /// <summary>
    /// 发货
    /// </summary>
    public class Shipment:Contract
    {
        /// <summary>
        /// 发货日期
        /// </summary>
        public DateTime ShipmentDate { get; set; }

        /// <summary>
        /// 收货人
        /// </summary>
        public string Consignee { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string ContactNumber { get; set; }

        /// <summary>
        /// 邮寄地址
        /// </summary>
        public Address DeliveryAddress { get; set; }

        /// <summary>
        /// 状态：待发货，已发货
        /// </summary>
        public ShipmentStatusEnum Status { get; set; }

        public Guid OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        public DateTime OrderCreateTime { get; set; }
    }
}
