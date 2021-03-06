using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.PlatformAbstractions;
using Megarobo.KunPengLIMS.Infrastructure;
using System.Runtime.InteropServices;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Infrastructure.RepoImplementations;
using Megarobo.KunPengLIMS.WebAPI.Filters;
using Megarobo.KunPengLIMS.Application.Services;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.WebAPI.Converters;

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
            services.AddControllers(cfg => cfg.Filters.Add<JsonExceptionFilter>())
                .AddJsonOptions(opt => opt.JsonSerializerOptions.Converters.Add(new DatetimeJsonConverter()));

            #region Database
            //services.AddDbContext<LimsDbContext>(options => options.UseMySql(Configuration.GetConnectionString("Mysql")));
            var dbhostname = Environment.GetEnvironmentVariable("DB_HOSTNAME", RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? EnvironmentVariableTarget.Machine : EnvironmentVariableTarget.Process);
            var dbport = Environment.GetEnvironmentVariable("DB_PORT", RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? EnvironmentVariableTarget.Machine : EnvironmentVariableTarget.Process);
            var dbusername = Environment.GetEnvironmentVariable("DB_USERNAME", RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? EnvironmentVariableTarget.Machine : EnvironmentVariableTarget.Process);
            var dbpassword = Environment.GetEnvironmentVariable("DB_PASSWORD", RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? EnvironmentVariableTarget.Machine : EnvironmentVariableTarget.Process);
            var dbname = Environment.GetEnvironmentVariable("DB_NAME", RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? EnvironmentVariableTarget.Machine : EnvironmentVariableTarget.Process);
            var connectionString = "Host={0};Port={1};User ID={2};Password={3};Database={4};Pooling=true;";
            if (!string.IsNullOrEmpty(dbhostname) && !string.IsNullOrEmpty(dbport) && !string.IsNullOrEmpty(dbusername) && !string.IsNullOrEmpty(dbpassword) && !string.IsNullOrEmpty(dbname))
            {
                connectionString = string.Format(connectionString, dbhostname, dbport, dbusername, dbpassword, dbname);
            }
            else
            {
                connectionString = Configuration.GetConnectionString("Postgre");
            }
            services.AddDbContext<LimsDbContext>(options => options.UseNpgsql(connectionString));
            #endregion

            services.AddScoped<IUserAppService, UserAppService>();
            services.AddScoped<IDepartmentAppService, DepartmentAppService>();
            services.AddScoped<ISkillAppService, SkillAppService>();
            services.AddScoped<IRoleAppService, RoleAppService>();
            services.AddScoped<IMenuAppService, MenuAppService>();
            services.AddScoped<IDictItemAppService, DictItemAppService>();
            services.AddScoped<ILogItemAppService, LogItemAppService>();

            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

            services.AddScoped<LogFilterAttribute>();

            services.AddAutoMapper(typeof(DeleteMultiDto));

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

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
