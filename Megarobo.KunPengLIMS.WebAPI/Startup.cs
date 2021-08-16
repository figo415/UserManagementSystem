using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Megarobo.KunPengLIMS.WebAPI.Filters;
using Megarobo.KunPengLIMS.WebAPI.Converters;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain.Externals;
using Megarobo.KunPengLIMS.Infrastructure;
using Microsoft.IdentityModel.Logging;
using Megarobo.KunPengLIMS.Application.ServiceExtensions;
using Megarobo.KunPengLIMS.Infrastructure.ServiceExtensions;

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
            //services.AddControllers();
            services.AddControllers(cfg => { 
                cfg.Filters.Add<JsonExceptionFilter>();
                cfg.Filters.Add<ModelVerificationFilter>();
                cfg.Filters.Add<KeycloakAuthorizeFilter>();
            })
                .AddJsonOptions(opt => { 
                    opt.JsonSerializerOptions.Converters.Add(new DatetimeJsonConverter());
                    opt.JsonSerializerOptions.Converters.Add(new NullableDatetimeJsonConverter());
                    opt.JsonSerializerOptions.IgnoreNullValues = true;
                }) ;

            services.AddScoped<LogFilterAttribute>();

            #region Database
            //services.AddDbContext<LimsDbContext>(options => options.UseMySql(Configuration.GetConnectionString("Mysql")));
            var connectionString = Environment.GetEnvironmentVariable("Postgres", RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? EnvironmentVariableTarget.Machine : EnvironmentVariableTarget.Process);
            if (string.IsNullOrEmpty(connectionString))
            {
                connectionString = Configuration.GetConnectionString("PostgreLocal");
            }
            services.AddDbContext<LimsDbContext>(options => options.UseNpgsql(connectionString));
            #endregion

            services.AddLims();

            services.AddAutoMapper(typeof(DeleteMultiDto));

            #region InventoryAPI
            //var inventoryBaseUrl = Environment.GetEnvironmentVariable("INVENTORY_BASEURL", RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? EnvironmentVariableTarget.Machine : EnvironmentVariableTarget.Process);
            //var inventoryAuthUrl = Environment.GetEnvironmentVariable("INVENTORY_AUTHURL", RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? EnvironmentVariableTarget.Machine : EnvironmentVariableTarget.Process);
            //var inventoryUsername = Environment.GetEnvironmentVariable("INVENTORY_USERNAME", RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? EnvironmentVariableTarget.Machine : EnvironmentVariableTarget.Process);
            //var inventoryPassword = Environment.GetEnvironmentVariable("INVENTORY_PASSWORD", RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? EnvironmentVariableTarget.Machine : EnvironmentVariableTarget.Process);
            //if(string.IsNullOrEmpty(inventoryBaseUrl) && string.IsNullOrEmpty(inventoryAuthUrl) && string.IsNullOrEmpty(inventoryUsername) && string.IsNullOrEmpty(inventoryPassword))
            //{
            //    services.Configure<InventoryApiInfo>(Configuration.GetSection("InventoryApiInfo"));
            //}
            //else
            //{
            //    services.Configure<InventoryApiInfo>(i => { i.InventoryBaseUrl = inventoryBaseUrl; i.AuthUrl = inventoryAuthUrl; i.UserName = inventoryUsername; i.Password = inventoryPassword; i.ClientId = "web-ui"; i.GrantType = "password"; });
            //}
            #endregion

            services.AddLimsRepo();
            var inventoryConnectionString = Environment.GetEnvironmentVariable("InventorySystem", RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? EnvironmentVariableTarget.Machine : EnvironmentVariableTarget.Process);
            if (string.IsNullOrEmpty(inventoryConnectionString))
            {
                inventoryConnectionString = Configuration.GetConnectionString("InventorySystem");
            }
            services.AddInventory(inventoryConnectionString);
            var awss3ConnectionString = Environment.GetEnvironmentVariable("AwsS3", RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? EnvironmentVariableTarget.Machine : EnvironmentVariableTarget.Process);
            if (string.IsNullOrEmpty(awss3ConnectionString))
            {
                awss3ConnectionString = Configuration.GetConnectionString("AwsS3");
            }
            services.AddAwss3(awss3ConnectionString);
            var keycloakConnectionString = Environment.GetEnvironmentVariable("Keycloak", RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? EnvironmentVariableTarget.Machine : EnvironmentVariableTarget.Process);
            if (string.IsNullOrEmpty(keycloakConnectionString))
            {
                keycloakConnectionString = Configuration.GetConnectionString("Keycloak");
            }
            services.AddKeycloak(keycloakConnectionString);

            #region Swagger
            // Register the Swagger generator, defining one or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Megarobo.KunPengLIMS",
                    Description = "WebAPI list of KunPengLIMS",
                    //TermsOfService = new Uri("https://example.com/terms"),
                    //Contact = new OpenApiContact
                    //{
                    //    Name = "Shayne Boyer",
                    //    Email = string.Empty,
                    //    Url = new Uri("https://twitter.com/spboyer"),
                    //},
                    //License = new OpenApiLicense
                    //{
                    //    Name = "Use under LICX",
                    //    Url = new Uri("https://example.com/license"),
                    //}
                });
                //Set the comments path for the swagger json and ui.
                //var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                //var xmlPath = Path.Combine(basePath, "Megarobo.KunPengLIMS.WebAPI.xml");

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            #region Swagger
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "KunPengLIMS API V1");
                //c.RoutePrefix = string.Empty;
            });
            #endregion

            IdentityModelEventSource.ShowPII = true;

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
