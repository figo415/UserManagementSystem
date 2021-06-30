using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    /// <summary>
    /// 细胞
    /// </summary>
    public class Cell:PurchasableEntity
    {
        /// <summary>
        /// 细胞名称：自动生成，KPCL前缀加上5位数字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 组织类型：cervix, lung, ELSE
        /// </summary>
        public string TissueType { get; set; }

        /// <summary>
        /// 细胞系种类：epithelial, ELSE
        /// </summary>
        public string CellLineType { get; set; }

        /// <summary>
        /// 培养方式: Adherent, Suspension, ELSE
        /// </summary>
        public string CultivationMethod { get; set; }

        /// <summary>
        /// 生物安全级别，最小值1，最大值4
        /// </summary>
        public int BioSafetyLevel { get; set; }

        /// <summary>
        /// 疾病：Carcinoma, Adenocarcinoma, ELSE
        /// </summary>
        public string Disease { get; set; }

        /// <summary>
        /// 年龄：最小值0，最大值120
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 性别：Female, Male, ELSE
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// 种族：Black, Caucasian, Asian, ELSE
        /// </summary>
        public string Race { get; set; }

        /// <summary>
        /// CRISPR订单档位：最小值1，最大值10
        /// </summary>
        public int CrisprOrderLevel { get; set; }

        public string AtccId { get; set; }

        public string AtccUrl { get; set; }

        public Guid SpeciesId { get; set; }

        [ForeignKey("SpeciesId")]
        public Species Species { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }

        public virtual ICollection<Sample> Samples { get; set; }
    }
}
