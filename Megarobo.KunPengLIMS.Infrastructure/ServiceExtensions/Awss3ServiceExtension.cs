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
        public static void AddAwss3(this IServiceCollection services, string connectionString)
        {
            var s3instance = new Awss3Service(connectionString);
            Console.WriteLine("AWS S3 connection string: " + connectionString);
            services.AddSingleton<IAwss3Service>(s3instance);
        }
    }
}
