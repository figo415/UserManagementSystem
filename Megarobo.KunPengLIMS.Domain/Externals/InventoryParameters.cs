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

        /// <summary>
        /// 0是试剂，1是耗材
        /// </summary>
        public int IsReagent { get; set; }

        public int labId { get; set; }

        public int page { get; set; }

        public int pageSize { get; set; }

        public string itemName { get; set; }

        public DateTime[] addDates { get; set; }

        public Sort sort { get; set; }

        //public int typeId { get; set; }

        //public string brand { get; set; }

        //public DateTime[] endDates { get; set; }

        //public int[] location { get; set; }

        //public int owner { get; set; }
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
