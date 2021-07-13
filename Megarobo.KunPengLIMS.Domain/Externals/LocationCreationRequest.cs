using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Externals
{
    public class LocationCreationRequest
    {
        public Guid id { get; set; }

        public string name { get; set; }

        public List<Location> positions { get; set; }
    }
}
