using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Externals
{
    public class LocationListItem
    {
        public int value { get; set; }

        public string label { get; set; }

        public int? boxId { get; set; }

        public int pid { get; set; }

        public int labId { get; set; }

        public string name { get; set; }

        public List<LocationListItem> children { get; set; }

        public int? boxCols { get; set; }

        public int? boxRows { get; set; }

        public string boxType { get; set; }

        public string selectedList { get; set; }

        public List<BoxStoreItem> boxStore { get; set; }

        public string localInfo { get; set; }
    }

    public class LocationData
    {
        public List<LocationListItem> locationList { get; set; }
    }

    public class LocationRoot
    {
        public string msg { get; set; }

        public int code { get; set; }

        public LocationData data { get; set; }
    }
}
