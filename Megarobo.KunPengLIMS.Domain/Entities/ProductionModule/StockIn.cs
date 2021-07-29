using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using Megarobo.KunPengLIMS.Domain.Enums;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    public class StockIn:Contract
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
        public StockStatusEnum Status { get; set; }

        public Guid OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        public DateTime OrderCreateTime { get; set; }
    }
}
