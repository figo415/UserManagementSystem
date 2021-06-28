using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class MenuQueryParameters:PagedParameters
    {
        public string Name { get; set; }

        public int? Type { get; set; }

        public bool? IsActive { get; set; }

        public override string ToString()
        {
            return string.Format("Name={0}, Type={1}, IsActive={2}", Name, Type, IsActive);
        }
    }
}
