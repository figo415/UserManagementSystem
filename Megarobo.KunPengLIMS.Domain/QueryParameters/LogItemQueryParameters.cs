using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class LogItemQueryParameters:PagedParameters
    {
        public string Operator { get; set; }

        public bool? IsSuccess { get; set; }

        public override string ToString()
        {
            return string.Format("Operator={0}, IsSuccess={1}, PageNumber={2}, PageSize={3}", Operator, IsSuccess, PageNumber, PageSize);
        }
    }
}
