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

        public string Province { get; set; }

        public string City { get; set; }

        public string District { get; set; }

        public string Detail { get; set; }
    }
}
