using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class SolutionDto
    {
        public List<ReagentUsageDto> ReagentUsages { get; set; }

        public List<SampleDosageDto> SampleDosages { get; set; }

        public string TotalValue { get; set; }

        public string TotalUnit { get; set; }
    }
}
