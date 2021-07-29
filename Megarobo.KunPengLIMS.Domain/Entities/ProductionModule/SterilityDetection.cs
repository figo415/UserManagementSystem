using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using Megarobo.KunPengLIMS.Domain.Enums;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    public class SterilityDetection:Contract
    {
        /// <summary>
        /// 检测日期
        /// </summary>
        public DateTime DetectionDate { get; set; }

        /// <summary>
        /// 细菌污染
        /// </summary>
        public bool IsBacterialPollute { get; set; }

        /// <summary>
        /// 荧光污染
        /// </summary>
        public bool IsFluorescence { get; set; }

        /// <summary>
        /// 状态：待检测，已完成
        /// </summary>
        public DetectionStatusEnum Status { get; set; }

        public Guid OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        public DateTime OrderCreateTime { get; set; }
    }
}
