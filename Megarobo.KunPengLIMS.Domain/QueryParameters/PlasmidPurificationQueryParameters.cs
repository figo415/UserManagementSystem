using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class PlasmidPurificationQueryParameters
    {
        public string ContractCode { get; set; }

        public string CarrierCode { get; set; }

        public string ContractType { get; set; }

        public string PlasmidType { get; set; }

        public string Status { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
