using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Domain.ExternalDefinitions
{
    public interface IKeycloakService
    {
        bool CreateUser(string username, string email);
    }
}
