using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    public class Species:AuditableEntity
    {
        /// <summary>
        /// 中文名称: "智人", "小鼠", "大鼠", "中国仓鼠", "非洲爪蟾", "其他"
        /// </summary>
        public string ChineseName { get; set; }

        /// <summary>
        /// 英文名称: "Human", "Mouse", "Rat", "CHO" "ELSE"
        /// </summary>
        public string EnglishName { get; set; }

        /// <summary>
        /// 拉丁文名称: "Homo Sapiens", "Mus musculus", "Rattus norvegicus", "Spodoptera frugiperda", "Oryctolagus cuniculus",  "Canis familiaris", "Bos taurus", "Xenopus", "Danio rerio", "ELSE"
        /// </summary>
        public string LatinName { get; set; }

        public Link SpeciesId { get; set; }

        public virtual ICollection<Cell> Cells { get; set; }
    }
}
