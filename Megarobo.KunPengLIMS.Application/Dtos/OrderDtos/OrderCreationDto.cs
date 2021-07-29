using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class OrderCreationDto
    {
        public string ContractType { get; set; }

        public string Status { get; set; }

        public string PlasmidType { get; set; }

        [Required(ErrorMessage = "请输入合同号")]
        public string ContractCode { get; set; }

        [Required(ErrorMessage = "请输入载体编号")]
        public string CarrierCode { get; set; }

        [Required(ErrorMessage = "请输入载体结构")]
        public string CarrierStructure { get; set; }

        public int PlasmidSize { get; set; }

        [Required(ErrorMessage = "请输入插入序列")]
        public string InsertionSequence { get; set; }

        [Required(ErrorMessage = "请选择合同开始日期")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "请选择合同截止日期")]
        public DateTime Deadline { get; set; }

        [Required(ErrorMessage = "请输入需求滴度")]
        public float DemandTiter { get; set; }

        [Required(ErrorMessage = "请输入需求总量")]
        public float TotelDemand { get; set; }

        public string SeroType { get; set; }

        [Required(ErrorMessage = "请输入包装盘数")]
        public int PackagingTrayNumber { get; set; }

        [Required(ErrorMessage = "请输入分装体积")]
        public float SubpackageCubage { get; set; }

        [Required(ErrorMessage = "请输入分装支数")]
        public int SubpackageNumber { get; set; }

        public float Plasmid1 { get; set; }

        public float Plasmid2 { get; set; }

        public float Plasmid3 { get; set; }

        public float Plasmid4 { get; set; }

        public object AnalysisReport { get; set; } //TODO

        public string Memo { get; set; }
    }
}
