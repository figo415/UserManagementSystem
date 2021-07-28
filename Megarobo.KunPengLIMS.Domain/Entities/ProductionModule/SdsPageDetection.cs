using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    public class SdsPageDetection:AuditableEntity
    {
        /// <summary>
        /// 检测日期
        /// </summary>
        public DateTime DetectionDate { get; set; }

        /// <summary>
        /// 蛋白滴度（vgs/ml）
        /// </summary>
        public float ProteinTiter { get; set; }

        /// <summary>
        /// 纯度是否合格
        /// </summary>
        public bool IsPurityQualified { get; set; }

        /// <summary>
        /// 状态：待检测，已完成
        /// </summary>
        public string Status { get; set; }

        public Guid OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }
    }
}
