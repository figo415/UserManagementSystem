using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Infrastructure.RepoImplementations;
using Megarobo.KunPengLIMS.WebAPI.Filters;
using Megarobo.KunPengLIMS.Infrastructure.Utility;
using Megarobo.KunPengLIMS.Domain.ExternalDefinitions;
using Megarobo.KunPengLIMS.Infrastructure.ExternalImplementations;

namespace Megarobo.KunPengLIMS.WebAPI.ServiceExtenstions
{
    public static class RepositoryExtension
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

            services.AddScoped<LogFilterAttribute>();

            services.AddScoped<ApiHelper>();

            services.AddScoped<IInventoryService, InventoryService>();

            services.AddScoped<ILocationService, LocationService>();

            services.AddScoped<IAwss3Service, Awss3Service>();
        }
    }
}
