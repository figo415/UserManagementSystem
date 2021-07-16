using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    class ProjectDto
    {
        public string Name { get; set; }

        public string ProcessName { get; set; }

        public DateTime? PlannedStartTime { get; set; }

        public int NumOfTakes { get; set; }

        public int NumOfTasks { get; set; }

        public string Status { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
