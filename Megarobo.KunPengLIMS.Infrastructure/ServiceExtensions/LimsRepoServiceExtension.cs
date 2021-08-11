using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Infrastructure.RepoImplementations;
using Microsoft.Extensions.DependencyInjection;

namespace Megarobo.KunPengLIMS.Infrastructure.ServiceExtensions
{
    public static class LimsRepoServiceExtension
    {
        public static void AddLimsRepo(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
