using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class DictItemQueryParameters:PagedParameters
    {
        public string KeyName { get; set; }

        public string Type { get; set; }
    }
}
