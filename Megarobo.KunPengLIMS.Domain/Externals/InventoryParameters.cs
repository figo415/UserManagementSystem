using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Externals
{
    public class InventoryParameters
    {
        public InventoryParameters()
        {
            itemName = "";
            labId = 1;
            page = 1;
            pageSize = 20;
            sort = new Sort();
        }

        public int labId { get; set; }

        public int page { get; set; }

        public int pageSize { get; set; }

        public string itemName { get; set; }

        public Sort sort { get; set; }
    }

    public class Sort
    {
        public Sort()
        {
            label = "";
            way = "";
        }

        public string label { get; set; }

        public string way { get; set; }
    }
}
