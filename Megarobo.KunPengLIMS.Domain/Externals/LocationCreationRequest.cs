using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Externals
{
    public class LocationCreationRequest
    {
        public Guid id { get; set; }

        public string name { get; set; }

        public List<LocationForCreation> positions { get; set; }
    }

    public class LocationForCreation
    {
        public int value { get; set; }

        public string label { get; set; }

        public int? boxId { get; set; }

        public int pid { get; set; }

        public int labId { get; set; }

        public string name { get; set; }

        public int? boxCols { get; set; }

        public int? boxRows { get; set; }

        public string boxType { get; set; }

        public List<string> selectedList { get; set; }

        public List<BoxStore> boxStore { get; set; }

        public string localInfo { get; set; }

        public List<LocationForCreation> children { get; set; }
    }
}
