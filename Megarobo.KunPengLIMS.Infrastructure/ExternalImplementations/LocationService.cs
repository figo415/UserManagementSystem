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

        public async Task<LocationData> GetLocations()
        {
            var tokenresponse = await _apiHelper.GetToken();
            var paras = new Dictionary<string, object>();
            paras.Add("labId", 1);
            var locationroot = _apiHelper.GetWebApi<LocationRoot>("/api/location/getLocationList", tokenresponse.access_token, paras);
            return locationroot.data;
        }
    }
}
