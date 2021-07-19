using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class ProjectQueryParameters:PagedParameters
    {
        public string Name { get; set; }

        public string ProcessName { get; set; }

        public string Status { get; set; }

        public override string ToString()
        {
            return string.Format("Name={0}, ProcessName={1}, Status={2}", Name, ProcessName, Status);
        }
    }
}
