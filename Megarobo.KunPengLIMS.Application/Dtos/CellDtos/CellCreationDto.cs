using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class CellCreationDto
    {
        [Required(ErrorMessage ="细胞名称不能为空")]
        public string Name { get; set; }

        [Required(ErrorMessage = "请选择组织类型")]
        public string TissueType { get; set; }

        [Required(ErrorMessage = "请选择细胞系种类")]
        public string CellLineType { get; set; }

        [Required(ErrorMessage = "请选择培养方式")]
        public string CultivationMethod { get; set; }

        [Range(1,4,ErrorMessage ="生物安全级别的最小值为1，最大值为4")]
        public int BioSafetyLevel { get; set; }

        public string Disease { get; set; }

        [Range(0,120,ErrorMessage = "年龄最小值为0，最大值为120")]
        public int Age { get; set; }

        public string Gender { get; set; }

        public string Race { get; set; }

        [Range(1,10,ErrorMessage = "CRISPR订单档位的最小值为1，最大值为10")]
        public int CrisprOrderLevel { get; set; }

        public string AtccId { get; set; }

        public string AtccUrl { get; set; }

        public string PurchaseFromName { get; set; }

        public string PurchaseFromUrl { get; set; }

        public string PurchasePrice { get; set; }

        public DateTime? PurchaseDate { get; set; }

        public string Remarks { get; set; }

        public List<SpeciesDto> SpeciesList { get; set; }
    }
}
