using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Externals
{
    public class InventoryHasLocationsItem
    {
        public int id { get; set; }

        public Location location { get; set; }

        public string boxInfo { get; set; }

        public int boxCols { get; set; }

        public int boxRows { get; set; }

        public string boxType { get; set; }

        public string name { get; set; }

        public string selectList { get; set; }

        public string selected { get; set; }

        public string localInfo { get; set; }
    }
}
