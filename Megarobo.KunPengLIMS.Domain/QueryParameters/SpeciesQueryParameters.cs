using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class SpeciesQueryParameters:PagedParameters
    {
        public string ChineseName { get; set; }

        public string EnglishName { get; set; }

        public string LatinName { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
