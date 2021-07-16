using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class NodeDto
    {
        public string Name { get; set; }

        public string NodeTypeName { get; set; }

        public string DurationTime { get; set; }

        public string InteractiveTime { get; set; }

        public bool CanGenerateResultSample { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
