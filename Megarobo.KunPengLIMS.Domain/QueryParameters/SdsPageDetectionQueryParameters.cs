using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.QueryParameters
{
    public class SdsPageDetectionQueryParameters:PagedParameters
    {
        public string ContractCode { get; set; }

        public string CarrierCode { get; set; }

        public string Status { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public override string ToString()
        {
            return string.Format("ContractCode={0}, CarrierCode={1}, Status={2}, StartDate={3}, EndDate={4}", ContractCode, CarrierCode, Status, StartDate, EndDate);
        }
    }
}
