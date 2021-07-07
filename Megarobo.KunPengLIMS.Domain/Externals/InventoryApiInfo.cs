using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Externals
{
    public class InventoryApiInfo
    {
        public string InventoryBaseUrl { get; set; }

        public string AuthUrl { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string ClientId { get; set; }

        public string GrantType { get; set; }
    }
}
