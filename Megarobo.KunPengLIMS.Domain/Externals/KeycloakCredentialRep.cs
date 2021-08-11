using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.Externals
{
    public class KeycloakCredentialRep
    {
        /// <summary>
        /// password
        /// </summary>
        public string type { get; set; }

        public string value { get; set; }

        public bool temporary { get; set; }
    }
}
