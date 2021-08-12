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
        private string _inventoryServerUrl;

        public InventoryService(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException("ConnectionString for Inventory System");
            }
            try
            {
                var pairs = connectionString.Split(';', StringSplitOptions.RemoveEmptyEntries);
                var dic = new Dictionary<string, string>();
                foreach (var pair in pairs)
                {
                    var kv = pair.Split("=", StringSplitOptions.RemoveEmptyEntries);
                    dic.Add(kv[0], kv[1]);
                }
                _inventoryServerUrl = dic["InventoryServerUrl"];
            }
            catch (Exception ex)
            {
                throw new ArgumentException("The correct Connection String for Inventory system is like: InventoryServerUrl=https://api.lims.test.aws.megarobo.tech;");
            }
        }

        public Task<InventoryData> GetInventory(InventoryParameters parameters)
        {
            var inventory = ApiHelper.PostWebApi<InventoryRoot>(_inventoryServerUrl,"/api/inventory/getInventoryList/show", "", parameters);
            if (inventory.code == 20000)
            {
                return Task.FromResult(inventory.data);
            }
            else
            {
                throw new Exception("Inventory API error: " + inventory.msg);
            }
        }

        public Task<List<Location>> GetLocations()
        {
            //var tokenresponse = await _apiHelper.GetToken();
            var paras = new Dictionary<string, object>();
            paras.Add("labId", 1);
            var locationroot = ApiHelper.GetWebApi<LocationRoot>(_inventoryServerUrl, "/api/location/getLocationList/show", "", paras);
            if (locationroot.code == 20000)
            {
                return Task.FromResult(locationroot.data.locationList);
            }
            else
            {
                throw new Exception("Inventory API (/api/location/getLocationList/show) error: " + locationroot.msg);
            }
        }

        public Task<List<Location>> GetLocation(Guid id)
        {
            var paras = new Dictionary<string, object>();
            paras.Add("guid", id);
            var locationRoot = ApiHelper.GetWebApi<LocationRoot>(_inventoryServerUrl, "/api/location/getLocationList/ByGuid", "", paras);
            if (locationRoot.code == 20000)
            {
                return Task.FromResult(locationRoot.data.locationList);
            }
            else
            {
                throw new Exception("Inventory API (/api/location/getLocationList/ByGuid?Guid=" + id + ") error: " + locationRoot.msg);
            }
        }

        public Task<bool> InsertLocation(LocationCreationRequest request)
        {
            var apiresponse = ApiHelper.PostWebApi<ApiResponse>(_inventoryServerUrl, "/api/inventory/editInventory", "", request);
            return Task.FromResult(apiresponse != null && apiresponse.code == 20000);
        }

        public Task<bool> DeleteLocation(Guid id)
        {
            var paras = new Dictionary<string, object>();
            paras.Add("Guid", id);
            var apiResponse = ApiHelper.GetWebApi<ApiResponse>(_inventoryServerUrl, "/api/location/deleteLocation/ByGuid", "", paras);
            return Task.FromResult(apiResponse != null && apiResponse.code == 20000);
        }
    }
}
