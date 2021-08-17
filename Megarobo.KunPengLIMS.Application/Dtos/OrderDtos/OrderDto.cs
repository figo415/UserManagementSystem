using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class OrderDto
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 合同号
        /// </summary>
        public string ContractCode { get; set; }

        /// <summary>
        /// 合同类型：AAV, LV, ADV
        /// </summary>
        public string ContractType { get; set; }

        /// <summary>
        /// 状态：已接单，待生产，生产中，已完成，已取消
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 载体编号
        /// </summary>
        public string CarrierCode { get; set; }

        /// <summary>
        /// 载体结构
        /// </summary>
        public string CarrierStructure { get; set; }

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
        /// 血清型
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
        /// 实际滴度（vgs/ml)："SDS-PAGE检测"页面-蛋白滴度
        /// </summary>
        public float ActualTiter { get; set; }

        /// <summary>
        /// 实际产量/vgs：实际滴度*分装体积*分装支数
        /// </summary>
        public float ActualOutput
        {
            get
            {
                return ActualTiter * SubpackageCubage * SubpackageNumber;
            }
        }

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
        /// 分析报告：pdf
        /// </summary>
        public List<string> Files { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
