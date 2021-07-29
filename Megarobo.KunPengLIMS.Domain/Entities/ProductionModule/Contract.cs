using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Enums;

namespace Megarobo.KunPengLIMS.Domain.Entities
{
    public class Contract : AuditableEntity
    {
        /// <summary>
        /// 合同号
        /// </summary>
        public string ContractCode { get; set; }

        /// <summary>
        /// 合同类型：AAV, LV, ADV
        /// </summary>
        public ContractTypeEnum ContractType { get; set; }

        /// <summary>
        /// 载体编号
        /// </summary>
        public string CarrierCode { get; set; }
    }
}
