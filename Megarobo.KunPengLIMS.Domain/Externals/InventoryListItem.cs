using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Externals
{
    public class InventoryListItem
    {
        public int id { get; set; }

        public string itemName { get; set; }

        public string materialCode { get; set; }

        public string brand { get; set; }

        public string vendor { get; set; }

        public int number { get; set; }

        public string numUnit { get; set; }

        public string owner { get; set; }

        public string project { get; set; }

        public string addDate { get; set; }

        public string updateDate { get; set; }

        public string spec { get; set; }

        public string specUnit { get; set; }

        public string price { get; set; }

        public string endDate { get; set; }

        public string batchNum { get; set; }

        public string url { get; set; }

        public string warningNum { get; set; }

        public string articleNum { get; set; }

        public string priceUnit { get; set; }

        public string arrivalDate { get; set; }

        public string requestDate { get; set; }

        public string inventoryNote { get; set; }

        public string typeId { get; set; }

        public int labId { get; set; }

        public string materialDesc { get; set; }

        public string materialGroupName { get; set; }

        public string materialGroupCode { get; set; }

        public string materialGroupId { get; set; }

        public string locationId { get; set; }

        public string orderNumber { get; set; }

        public string deliveryReply { get; set; }

        public List<InventoryHasLocationsItem> inventoryHasLocations { get; set; }

        public string locationString { get; set; }

        public List<LocationItem> location { get; set; }

        public string addDates { get; set; }

        public string updateDates { get; set; }

        public string sort { get; set; }

        public string typeName { get; set; }

        public string type { get; set; }

        public string map { get; set; }

        public string ownerName { get; set; }
    }
}
