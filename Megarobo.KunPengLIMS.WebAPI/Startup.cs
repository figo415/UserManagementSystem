using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.PlatformAbstractions;
using Megarobo.KunPengLIMS.Infrastructure;
using System.Runtime.InteropServices;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Infrastructure.RepoImplementations;
using Megarobo.KunPengLIMS.Application;

namespace Megarobo.KunPengLIMS.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //services.AddDbContext<LimsDbContext>(options => options.UseMySql(Configuration.GetConnectionString("Default")));//Read from appsettings.json
            var connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING", RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? EnvironmentVariableTarget.Machine : EnvironmentVariableTarget.Process);
            services.AddDbContext<LimsDbContext>(options => options.UseNpgsql(connectionString));
            //services.AddDbContext<LimsDbContext>(options => options.UseNpgsql(Configuration.GetConnectionString("Postgre")));

            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

            services.AddAutoMapper(typeof(DeleteMultiDto));

            // Register the Swagger generator, defining one or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v1",
                    Title = "Megarobo.KunPengLIMS",
                    Description = "WebAPI list of KunPengLIMS",
                });
                //Set the comments path for the swagger json and ui.
                //var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                //var xmlPath = Path.Combine(basePath, "Megarobo.KunPengLIMS.WebAPI.xml");
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath, true);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "KunPengLIMS API V1");
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
