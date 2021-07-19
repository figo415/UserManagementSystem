using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class TakeQueryParameters:PagedParameters
    {
        public string ProjectName { get; set; }

        public int TakeNum { get; set; }

        public string Status { get; set; }

        public override string ToString()
        {
            return string.Format("ProjectName={0}, TakeNum={1}, Status={2}", ProjectName, TakeNum, Status);
        }
    }
}
