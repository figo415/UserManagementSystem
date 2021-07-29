using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class QpcrDetectionDto
    {
        public Guid Id { get; set; }

        public string ContractCode { get; set; }

        public string CarrierCode { get; set; }

        public DateTime DetectionDate { get; set; }

        public float Titer { get; set; }

        public string Status { get; set; }
    }
}
