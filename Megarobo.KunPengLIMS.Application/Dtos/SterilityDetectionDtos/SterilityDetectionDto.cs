using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class SterilityDetectionDto
    {
        public Guid Id { get; set; }

        public string ContractCode { get; set; }

        public string CarrierCode { get; set; }

        public DateTime DetectionDate { get; set; }

        public bool IsBacterialPollute { get; set; }

        public bool IsFluorescence { get; set; }

        public List<string> Files { get; set; }

        public string Status { get; set; }
    }
}
