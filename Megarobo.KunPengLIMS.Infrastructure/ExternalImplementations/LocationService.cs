using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain.Externals;
using Megarobo.KunPengLIMS.Domain.ExternalDefinitions;
using Megarobo.KunPengLIMS.Infrastructure.Utility;

namespace Megarobo.KunPengLIMS.Infrastructure.ExternalImplementations
{
    public class LocationService:ILocationService
    {
        private readonly ApiHelper _apiHelper;

        public LocationService(ApiHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task<List<Location>> GetLocations()
        {
            //var tokenresponse = await _apiHelper.GetToken();
            var paras = new Dictionary<string, object>();
            paras.Add("labId", 1);
            var locationroot = _apiHelper.GetWebApi<LocationRoot>("/api/location/getLocationList/show", "", paras);
            if(locationroot.code==20000)
            {
                return locationroot.data.locationList;
            }
            else
            {
                throw new Exception("Inventory API error: " + locationroot.msg);
            }
        }

        public async Task<List<Location>> GetLocation(Guid id)
        {
            var paras= new Dictionary<string, object>();
            paras.Add("guid", id);
            var locationRoot = _apiHelper.GetWebApi<LocationRoot>("/api/location/getLocationList/ByGuid", "", paras);
            if (locationRoot.code == 20000)
            {
                return locationRoot.data.locationList;
            }
            else
            {
                throw new Exception("Inventory API error: " + locationRoot.msg);
            }
        }

        public Task<bool> InsertLocation(LocationCreationRequest request)
        {
            var apiresponse = _apiHelper.PostWebApi<ApiResponse>("/api/inventory/editInventory", "", request);
            return Task.FromResult(apiresponse.code == 20000);
        }
    }
}
