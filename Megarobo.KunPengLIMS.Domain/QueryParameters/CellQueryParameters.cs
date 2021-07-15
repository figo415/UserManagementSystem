using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class CellQueryParameters:PagedParameters
    {
        public string Name { get; set; }

        public string TissueType { get; set; }

        public string CellLineType { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public override string ToString()
        {
            return string.Format("Name={0}, TissueType={1}, CellLineType={2}, StartDate={3}, EndDate={4}", Name, TissueType, CellLineType, StartDate, EndDate);
        }
    }
}
