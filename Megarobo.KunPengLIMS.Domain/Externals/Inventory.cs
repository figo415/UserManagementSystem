using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Externals
{
    public class InventoryData
    {
        /// <summary>
        /// 数据总数
        /// </summary>
        public int total { get; set; }

        public List<InventoryListItem> inventoryList { get; set; }
    }

    public class Inventory
    {
        public string msg { get; set; }

        public int code { get; set; }

        public InventoryData data { get; set; }
    }
}