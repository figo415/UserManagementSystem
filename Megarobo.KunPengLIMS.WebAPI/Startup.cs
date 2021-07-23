using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.PlatformAbstractions;
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Runtime.InteropServices;
using Megarobo.KunPengLIMS.WebAPI.Filters;
using Megarobo.KunPengLIMS.WebAPI.Converters;
using Megarobo.KunPengLIMS.Application.Services;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Domain.Externals;
using Megarobo.KunPengLIMS.Domain.ExternalDefinitions;
using Megarobo.KunPengLIMS.Infrastructure;
using Megarobo.KunPengLIMS.Infrastructure.RepoImplementations;
using Megarobo.KunPengLIMS.Infrastructure.ExternalImplementations;
using Megarobo.KunPengLIMS.Infrastructure.Utility;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Newtonsoft.Json.Linq;
using Microsoft.IdentityModel.Logging;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;

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
                .AddJsonOptions(opt => { opt.JsonSerializerOptions.Converters.Add(new DatetimeJsonConverter()); opt.JsonSerializerOptions.Converters.Add(new NullableDatetimeJsonConverter()); }) ;

            #region JWT

            //    services.AddAuthentication(options =>
            //    {
            //        //Sets cookie authentication scheme
            //        options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //        options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //        options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
            //    })
            //.AddCookie(cookie =>
            //{
            //    //Sets the cookie name and maxage, so the cookie is invalidated.
            //    cookie.Cookie.Name = "keycloak.cookie";
            //    cookie.Cookie.MaxAge = TimeSpan.FromMinutes(60);
            //    cookie.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
            //    cookie.SlidingExpiration = true;
            //})
            // .AddOpenIdConnect(options =>
            // {
            //     /*
            //      * ASP.NET core uses the http://*:5000 and https://*:5001 ports for default communication with the OIDC middleware
            //      * The app requires load balancing services to work with :80 or :443
            //      * These needs to be added to the keycloak client, in order for the redirect to work.
            //      * If you however intend to use the app by itself then,
            //      * Change the ports in launchsettings.json, but beware to also change the options.CallbackPath and options.SignedOutCallbackPath!
            //      * Use LB services whenever possible, to reduce the config hazzle :)
            //     */

            //     //Use default signin scheme
            //     options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //     options.Authority = "http://localhost:8080/auth/realms/locallims";// Configuration.GetSection("Keycloak")["ServerRealm"];
            //     options.ClientId = "webapi";// Configuration.GetSection("Keycloak")["ClientId"];
            //     options.ClientSecret = "d8e1534d-c340-4943-8084-ed71b9cf149d";// Configuration.GetSection("Keycloak")["ClientSecret"];
            //     options.MetadataAddress = "http://localhost:8080/auth/realms/locallims/.well-known/openid-configuration";// Configuration.GetSection("Keycloak")["Metadata"];
            //     options.Configuration = new OpenIdConnectConfiguration();
            //     options.RequireHttpsMetadata = false;
            //     options.GetClaimsFromUserInfoEndpoint = true;
            //     options.Scope.Add("openid");
            //     options.Scope.Add("profile");
            //     options.SaveTokens = true;
            //     //Token response type, will sometimes need to be changed to IdToken, depending on config.
            //     options.ResponseType = OpenIdConnectResponseType.Code;
            //     //SameSite is needed for Chrome/Firefox, as they will give http error 500 back, if not set to unspecified.
            //     options.NonceCookie.SameSite = SameSiteMode.Unspecified;
            //     options.CorrelationCookie.SameSite = SameSiteMode.Unspecified;
            //     options.TokenValidationParameters = new TokenValidationParameters
            //     {
            //         NameClaimType = "name",
            //         RoleClaimType = ClaimTypes.Role,
            //         ValidateIssuer = true
            //     };
            // });

            //services.AddAuthentication(options =>
            //{
            //    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //})
            //    .AddJwtBearer(options =>
            //    {
            //        options.TokenValidationParameters = new TokenValidationParameters
            //        {
            //            ValidateAudience = true,
            //            ValidateLifetime = true,
            //            ValidateIssuer = true,
            //            ValidateIssuerSigningKey = true,
            //            ValidIssuer= "http://localhost:8080/auth/realms/locallims/test",
            //            ValidAudience= "accounttes",
            //            IssuerSigningKey=new SymmetricSecurityKey(Encoding.UTF8.GetBytes("938diejsiwiriqusk12"))
            //        };
            //    });
            //    .AddJwtBearer(options =>
            //{
            //    options.Authority = "http://localhost:8080/auth/realms/locallims";
            //    options.RequireHttpsMetadata = false;
            //    options.Audience = "account";
            //    options.MetadataAddress = "http://localhost:8080/auth/realms/locallims/.well-known/openid-configuration";
            //    options.Configuration = new OpenIdConnectConfiguration();
            //    options.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        //ValidIssuer = "http://localhost:8080/auth/realms/LIMS",
            //        //ValidAudience = "account",
            //        //NameClaimType = "preferred_username"
            //        //IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("UsLtrk2vnIIadCvyRYoMb_jKvk25dqKGUARZD-7QRwI"))
            //    };
                //options.Events = new JwtBearerEvents
                //{
                //    OnTokenValidated = context =>
                //    {
                //        var identity = context.Principal.Identity as ClaimsIdentity;
                //        var access = context.Principal.Claims.FirstOrDefault(p => p.Type == "realm_access");
                //        var jo = JObject.Parse(access.Value);
                //        foreach (var role in jo["roles"].Values())
                //        {
                //            identity.AddClaim(new Claim(ClaimTypes.Role, role.ToString()));
                //        }
                //        return Task.CompletedTask;
                //    }
                //};
            //});

            #endregion

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
                connectionString = Configuration.GetConnectionString("PostgreLocal");
            }
            services.AddDbContext<LimsDbContext>(options => options.UseNpgsql(connectionString));
            #endregion

            #region AppService
            services.AddScoped<IUserAppService, UserAppService>();
            services.AddScoped<IDepartmentAppService, DepartmentAppService>();
            services.AddScoped<ISkillAppService, SkillAppService>();
            services.AddScoped<IRoleAppService, RoleAppService>();
            services.AddScoped<IMenuAppService, MenuAppService>();
            services.AddScoped<IDictItemAppService, DictItemAppService>();
            services.AddScoped<ILogItemAppService, LogItemAppService>();
            services.AddScoped<ISpeciesAppService, SpeciesAppService>();
            services.AddScoped<ICellAppService, CellAppService>();
            services.AddScoped<IDeviceAppService, DeviceAppService>();
            services.AddScoped<ILabwareAppService, LabwareAppService>();
            services.AddScoped<IReagentAppService, ReagentAppService>();
            services.AddScoped<IPositionAppService, PositionAppService>();
            services.AddScoped<ISampleAppService, SampleAppService>();
            #endregion

            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

            services.AddScoped<LogFilterAttribute>();
            services.AddScoped<RequestAuthorizeAttribute>();

            services.AddAutoMapper(typeof(DeleteMultiDto));

            #region InventoryAPI
            var inventoryBaseUrl = Environment.GetEnvironmentVariable("INVENTORY_BASEURL", RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? EnvironmentVariableTarget.Machine : EnvironmentVariableTarget.Process);
            var inventoryAuthUrl = Environment.GetEnvironmentVariable("INVENTORY_AUTHURL", RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? EnvironmentVariableTarget.Machine : EnvironmentVariableTarget.Process);
            var inventoryUsername = Environment.GetEnvironmentVariable("INVENTORY_USERNAME", RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? EnvironmentVariableTarget.Machine : EnvironmentVariableTarget.Process);
            var inventoryPassword = Environment.GetEnvironmentVariable("INVENTORY_PASSWORD", RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? EnvironmentVariableTarget.Machine : EnvironmentVariableTarget.Process);
            if(string.IsNullOrEmpty(inventoryBaseUrl) && string.IsNullOrEmpty(inventoryAuthUrl) && string.IsNullOrEmpty(inventoryUsername) && string.IsNullOrEmpty(inventoryPassword))
            {
                services.Configure<InventoryApiInfo>(Configuration.GetSection("InventoryApiInfo"));
            }
            else
            {
                services.Configure<InventoryApiInfo>(i => { i.InventoryBaseUrl = inventoryBaseUrl; i.AuthUrl = inventoryAuthUrl; i.UserName = inventoryUsername; i.Password = inventoryPassword; i.ClientId = "web-ui"; i.GrantType = "password"; });
            }
            services.AddScoped<ApiHelper>();
            services.AddScoped<IInventoryService, InventoryService>();
            services.AddScoped<ILocationService, LocationService>();
            #endregion

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

            //app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
