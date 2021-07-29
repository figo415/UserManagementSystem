using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class SdsPageDetectionDto
    {
        public Guid Id { get; set; }

        public string ContractCode { get; set; }

        public string CarrierCode { get; set; }

        public DateTime DetectionDate { get; set; }

        public float QpcrTiter { get; set; }

        public float ProteinTiter { get; set; }

        public bool IsPurityQualified { get; set; }

        public string Status { get; set; }
    }
}
