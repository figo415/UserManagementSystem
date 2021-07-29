using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Enums;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    public class Order:Contract
    {
        /// <summary>
        /// 状态：已接单，待生产，生产中，已完成，已取消
        /// </summary>
        public OrderStatusEnum Status { get; set; }

        /// <summary>
        /// 载体结构
        /// </summary>
        public string CarrierStructure { get; set; }

        /// <summary>
        /// 质粒类型：大抽，小抽
        /// </summary>
        public PlasmidExtractionTypeEnum PlasmidType { get; set; }

        /// <summary>
        /// 质粒大小/bp
        /// </summary>
        public int PlasmidSize { get; set; }

        /// <summary>
        /// 插入序列
        /// </summary>
        public string InsertionSequence { get; set; }

        /// <summary>
        /// 需求滴度（vgs/ml）
        /// </summary>
        public float DemandTiter { get; set; }

        /// <summary>
        /// 需求总量/vgs
        /// </summary>
        public float TotelDemand { get; set; }

        /// <summary>
        /// 血清型：只有AAV有
        /// </summary>
        public string SeroType { get; set; }

        /// <summary>
        /// 合同开始日期
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 合同截止日期
        /// </summary>
        public DateTime Deadline { get; set; }

        /// <summary>
        /// 包装盘数
        /// </summary>
        public int PackagingTrayNumber { get; set; }

        /// <summary>
        /// 生产日期：进入生产的时间
        /// </summary>
        public DateTime ProductionDate { get; set; }

        /// <summary>
        /// 完成日期
        /// </summary>
        public DateTime FinisheDate { get; set; }

        /// <summary>
        /// 分装体积/μL
        /// </summary>
        public float SubpackageCubage { get; set; }

        /// <summary>
        /// 分装支数/支
        /// </summary>
        public int SubpackageNumber { get; set; }

        /// <summary>
        /// 质粒1（ng/μL）
        /// </summary>
        public float Plasmid1 { get; set; }

        /// <summary>
        /// 质粒2（ng/μL）
        /// </summary>
        public float Plasmid2 { get; set; }

        /// <summary>
        /// 质粒3（ng/μL）
        /// </summary>
        public float Plasmid3 { get; set; }

        /// <summary>
        /// 质粒4（ng/μL）
        /// </summary>
        public float Plasmid4 { get; set; }

        /// <summary>
        /// 分析报告：pdf
        /// </summary>
        public object AnalysisReport { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string CreatedBy { get; set; }

        public virtual ICollection<MolecularCloning> MolecularClonings { get; set; }

        public virtual ICollection<PlasmidPurification> PlasmidPurifications { get; set; }

        public virtual ICollection<QpcrDetection> QpcrDetections { get; set; }

        public virtual ICollection<SdsPageDetection> SdsPageDetections { get; set; }

        public virtual ICollection<SterilityDetection> SterilityDetections { get; set; }

        public virtual ICollection<StockIn> StockIns { get; set; }

        public virtual ICollection<Shipment> Shipments { get; set; }
    }
}
