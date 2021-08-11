using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class ShipmentUpdateDto
    {
        public DateTime ShipmentDate { get; set; }

        public string Consignee { get; set; }

        public string ContactNumber { get; set; }

        public List<string> Address { get; set; }

        public string Detail { get; set; }
    }
}
