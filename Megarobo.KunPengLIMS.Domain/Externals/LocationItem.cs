using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Externals
{
    public class LocationItem
    {
        public int value { get; set; }

        public string label { get; set; }

        public int boxId { get; set; }

        public int pid { get; set; }

        public string labId { get; set; }

        public string name { get; set; }

        public string boxCols { get; set; }

        public string boxRows { get; set; }

        public string boxType { get; set; }

        public string selectedList { get; set; }

        public List<BoxStoreItem> boxStore { get; set; }

        public string localInfo { get; set; }
    }
}
