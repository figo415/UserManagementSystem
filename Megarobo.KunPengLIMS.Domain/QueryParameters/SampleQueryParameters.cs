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
    }
}
