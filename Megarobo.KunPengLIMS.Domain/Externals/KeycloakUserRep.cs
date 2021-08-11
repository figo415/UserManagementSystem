using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Externals
{
    public class KeycloakUserRep
    {
        public string id { get; set; }

        public string username { get; set; }

        public string email { get; set; }

        public bool emailVerified { get; set; }

        public bool enabled { get; set; }

        public List<KeycloakCredentialRep> credentials { get; set; }
    }
}
