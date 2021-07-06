using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain.Externals;
using Megarobo.KunPengLIMS.Domain.ExternalDefinitions;
using Megarobo.KunPengLIMS.Infrastructure.Utility;

namespace Megarobo.KunPengLIMS.Infrastructure.ExternalImplementations
{
    public class InventoryService:IInventoryService
    {
        public async Task<InventoryData> GetInventory(InventoryParameters parameters)
        {
            var tokenresponse = await ApiHelper.GetToken();
            var inventory = ApiHelper.PostWebApi<Inventory>("/api/inventory/getInventoryList", tokenresponse.access_token, parameters);
            return inventory.data;
        }
    }
}
