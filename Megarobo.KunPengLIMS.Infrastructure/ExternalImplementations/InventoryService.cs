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
        private readonly ApiHelper _apiHelper;

        public InventoryService(ApiHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task<InventoryData> GetInventory(InventoryParameters parameters)
        {
            var tokenresponse = await _apiHelper.GetToken();
            var inventory = _apiHelper.PostWebApi<InventoryRoot>("/api/inventory/getInventoryList/show", tokenresponse.access_token, parameters);
            if (inventory.code == 20000)
            {
                return inventory.data;
            }
            else
            {
                throw new Exception("Inventory API error: " + inventory.msg);
            }
        }
    }
}
