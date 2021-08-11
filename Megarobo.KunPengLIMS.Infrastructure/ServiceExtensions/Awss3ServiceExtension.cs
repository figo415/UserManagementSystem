using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Megarobo.KunPengLIMS.Domain.ExternalDefinitions;
using Megarobo.KunPengLIMS.Infrastructure.ExternalImplementations;

namespace Megarobo.KunPengLIMS.Infrastructure.ServiceExtensions
{
    public static class Awss3ServiceExtension
    {
        public static void AddAwss3(this IServiceCollection services)
        {
            services.AddScoped<IAwss3Service, Awss3Service>();
        }
    }
}
