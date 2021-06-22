using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class RoleQueryParameters:PagedParameters
    {
        public string Name { get; set; }

        public bool? IsActive { get; set; }
    }
}
