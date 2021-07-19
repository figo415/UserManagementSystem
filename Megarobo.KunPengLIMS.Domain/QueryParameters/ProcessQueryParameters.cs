using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class ProcessQueryParameters:PagedParameters
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public override string ToString()
        {
            return string.Format("Name={0}, Type={1}, StartDate={2}, EndDate={3}", Name, Type, StartDate, EndDate);
        }
    }
}
