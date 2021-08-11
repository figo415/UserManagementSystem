using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class ShipmentDto
    {
        public Guid Id { get; set; }

        public string ContractCode { get; set; }

        public string CarrierCode { get; set; }

        public DateTime ShipmentDate { get; set; }

        public List<string> Address { get; set; }

        public string Detail { get; set; }

        public string CompleteAddress { get; set; }

        public string Status { get; set; }
    }
}
