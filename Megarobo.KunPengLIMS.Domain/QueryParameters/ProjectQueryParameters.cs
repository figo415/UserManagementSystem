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
    }
}
