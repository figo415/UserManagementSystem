using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class QpcrDetectionUpdateDto
    {
        public DateTime DetectionDate { get; set; }

        public float Titer { get; set; }
    }
}
