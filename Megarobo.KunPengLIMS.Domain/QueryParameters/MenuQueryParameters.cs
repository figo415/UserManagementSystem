using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class MenuQueryParameters//:PagedParameters
    {
        public string Name { get; set; }

        public int? Type { get; set; }

        public bool? IsActive { get; set; }
    }
}
