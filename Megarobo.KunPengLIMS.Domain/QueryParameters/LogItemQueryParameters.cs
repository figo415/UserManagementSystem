using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class LogItemQueryParameters:PagedParameters
    {
        public string Operator { get; set; }

        public bool? IsSuccess { get; set; }
    }
}
