using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.ExternalDefinitions;
using Megarobo.KunPengLIMS.Infrastructure.Utility;

namespace Megarobo.KunPengLIMS.Infrastructure.ExternalImplementations
{
    public class KeycloakService:IKeycloakService
    {
        private readonly ApiHelper _apiHelper;

        public KeycloakService(ApiHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public bool CreateUser(string username, string email)
        {
            throw new NotImplementedException();
        }
    }
}
