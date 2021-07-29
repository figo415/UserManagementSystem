using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class OrderQueryParameters:PagedParameters
    {
        public string ContractCode { get; set; }

        public string ContractType { get; set; }

        public string Status { get; set; }

        public string CarrierCode { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public override string ToString()
        {
            return string.Format("ContractCode={0}, ContractType={1}, Status={2}, CarrierCode={3}, StartDate={4}, EndDate={5}", ContractCode, ContractType, Status, CarrierCode, StartDate, EndDate);
        }
    }
}
