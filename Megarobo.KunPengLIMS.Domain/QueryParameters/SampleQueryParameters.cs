using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class SampleQueryParameters:PagedParameters
    {
        public string Name { get; set; }

        public string TaskName { get; set; }

        public string Status { get; set; }

        public override string ToString()
        {
            return string.Format("Name={0}, TaskName={1}, Status={2}", Name, TaskName, Status);
        }
    }
}
