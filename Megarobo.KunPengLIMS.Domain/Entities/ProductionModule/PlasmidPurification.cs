using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using Megarobo.KunPengLIMS.Domain.Enums;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    public class PlasmidPurification:Contract
    {
        /// <summary>
        /// 质粒类型：大抽，小抽
        /// </summary>
        public PlasmidExtractionTypeEnum PlasmidType { get; set; }

        /// <summary>
        /// 浓度（ng/μL）
        /// </summary>
        public Thickness Thickness { get; set; }

        public float Od { get; set; }

        /// <summary>
        /// 酶
        /// </summary>
        public string Enzyme { get; set; }

        /// <summary>
        /// 类型：待纯化，已完成
        /// </summary>
        public PlasmidPurificationStatusEnum Status { get; set; }

        public Guid OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        public string CarrierStructure { get; set; }

        public int PlasmidSize { get; set; }

        public DateTime OrderCreateTime { get; set; }
    }
}
