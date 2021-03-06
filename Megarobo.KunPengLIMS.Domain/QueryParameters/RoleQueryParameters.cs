using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class RoleQueryParameters:PagedParameters
    {
        public string Name { get; set; }

        public bool? IsActive { get; set; }

        public override string ToString()
        {
            return string.Format("Name={0}, IsActive={1}, PageNumber={2}, PageSize={3}", Name, IsActive, PageNumber, PageSize);
        }
    }
}
