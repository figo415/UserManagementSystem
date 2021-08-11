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
        public static void AddKeycloak(this IServiceCollection services)
        {
            services.AddScoped<IKeycloakService, KeycloakService>();
        }
    }
}
