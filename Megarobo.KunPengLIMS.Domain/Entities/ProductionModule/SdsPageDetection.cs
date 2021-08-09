using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using Megarobo.KunPengLIMS.Domain.Enums;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    /// <summary>
    /// SDS-PAGE检测
    /// </summary>
    public class SdsPageDetection:Contract
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
        /// 检测图片
        /// </summary>
        public string DetectionPicture { get; set; }

        /// <summary>
        /// 状态：待检测，已完成
        /// </summary>
        public DetectionStatusEnum Status { get; set; }

        public Guid OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        public DateTime OrderCreateTime { get; set; }

        [NotMapped]
        public QpcrDetection QpcrDetection { get; set; }
    }
}
