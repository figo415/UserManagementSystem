using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class SterilityDetectionUpdateDto
    {
        public DateTime DetectionDate { get; set; }

        public bool IsBacterialPollute { get; set; }

        public bool IsFluorescence { get; set; }
    }
}
