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
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.PlatformAbstractions;
using Megarobo.KunPengLIMS.Infrastructure;
using System.Runtime.InteropServices;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Infrastructure.RepoImplementations;
using Megarobo.KunPengLIMS.Application;
using Megarobo.KunPengLIMS.WebAPI.Filters;
using Megarobo.KunPengLIMS.Application.UserApp;
using Megarobo.KunPengLIMS.Application.DepartmentApp;

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
            services.AddControllers(cfg => cfg.Filters.Add<JsonExceptionFilter>());

            //services.AddDbContext<LimsDbContext>(options => options.UseMySql(Configuration.GetConnectionString("Default")));//Read from appsettings.json
            //var connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING", RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? EnvironmentVariableTarget.Machine : EnvironmentVariableTarget.Process);
            var connectionString = "Host=host.docker.internal;Port=5432;User ID=postgres;Password=megarobo;Database=limsdb;Pooling=true;";
            services.AddDbContext<LimsDbContext>(options => options.UseNpgsql(connectionString));
            //services.AddDbContext<LimsDbContext>(options => options.UseNpgsql(Configuration.GetConnectionString("Postgre")));

            services.AddScoped<IUserAppService, UserAppService>();
            services.AddScoped<IDepartmentAppService, DepartmentAppService>();

            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

            services.AddAutoMapper(typeof(DeleteMultiDto));

            #region Swagger
            //// Register the Swagger generator, defining one or more Swagger documents
            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo
            //    {
            //        Version = "v1",
            //        Title = "Megarobo.KunPengLIMS",
            //        Description = "WebAPI list of KunPengLIMS",
            //        //TermsOfService = new Uri("https://example.com/terms"),
            //        //Contact = new OpenApiContact
            //        //{
            //        //    Name = "Shayne Boyer",
            //        //    Email = string.Empty,
            //        //    Url = new Uri("https://twitter.com/spboyer"),
            //        //},
            //        //License = new OpenApiLicense
            //        //{
            //        //    Name = "Use under LICX",
            //        //    Url = new Uri("https://example.com/license"),
            //        //}
            //    });
            //    //Set the comments path for the swagger json and ui.
            //    //var basePath = PlatformServices.Default.Application.ApplicationBasePath;
            //    //var xmlPath = Path.Combine(basePath, "Megarobo.KunPengLIMS.WebAPI.xml");

            //    // Set the comments path for the Swagger JSON and UI.
            //    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            //    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            //    c.IncludeXmlComments(xmlPath);
            //});
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
            //// Enable middleware to serve generated Swagger as a JSON endpoint.
            //app.UseSwagger();
            //// Enable middleware to serve swagger-ui (HTML, JS, CSS etc.), specifying the Swagger JSON endpoint.
            //app.UseSwaggerUI(c =>
            //{
            //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "KunPengLIMS API V1");
            //    //c.RoutePrefix = string.Empty;
            //});
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
