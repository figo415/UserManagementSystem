using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    public class StockIn:AuditableEntity
    {
        /// <summary>
        /// 入库日期
        /// </summary>
        public DateTime StockInDate { get; set; }

        /// <summary>
        /// 位置
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 状态：待入库，已入库
        /// </summary>
        public string Status { get; set; }

        public Guid OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }
    }
}
