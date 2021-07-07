using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class SourceTask
    {
        public Guid ProjectId { get; set; }

        public string ProjectName { get; set; }

        public Guid NodeId { get; set; }

        public string NodeName { get; set; }
    }
}
