using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class PositionQueryParameters:PagedParameters
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("Name={0}", Name);
        }
    }
}
