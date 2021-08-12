using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Megarobo.KunPengLIMS.Domain.ExternalDefinitions;
using Megarobo.KunPengLIMS.Infrastructure.ExternalImplementations;

namespace Megarobo.KunPengLIMS.Infrastructure.ServiceExtensions
{
    public static class KeycloakServiceExtension
    {
        public static void AddKeycloak(this IServiceCollection services, string connectionString)
        {
            var keycloakInstance = new KeycloakService(connectionString);
            services.AddSingleton<IKeycloakService>(keycloakInstance);
        }
    }
}
