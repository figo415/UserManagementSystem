using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class PlasmidPurificationQueryParameters:PagedParameters
    {
        public string ContractCode { get; set; }

        public string CarrierCode { get; set; }

        public string ContractType { get; set; }

        public string PlasmidType { get; set; }

        public string Status { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public override string ToString()
        {
            return string.Format("ContractCode={0}, CarrierCode={1}, ContractType={2}, PlasmidType={4}, Status={5}, StartDate={6}, EndDate={7}", ContractCode, CarrierCode, ContractType, PlasmidType, Status, StartDate, EndDate);
        }
    }
}
