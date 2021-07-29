using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class StockInDto
    {
        public Guid Id { get; set; }

        public string ContractCode { get; set; }

        public string CarrierCode { get; set; }

        public DateTime StockInDate { get; set; }

        public string Location { get; set; }

        public string Status { get; set; }
    }
}
