using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class SdsPageDetectionUpdateDto
    {
        public DateTime DetectionDate { get; set; }

        public float ProteinTiter { get; set; }

        public bool IsPurityQualified { get; set; }

        public List<string> Files { get; set; }
    }
}
