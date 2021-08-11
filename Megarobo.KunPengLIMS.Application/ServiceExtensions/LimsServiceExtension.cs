using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Megarobo.KunPengLIMS.Application.Services;

namespace Megarobo.KunPengLIMS.Application.ServiceExtensions
{
    public static class LimsServiceExtension
    {
        public static void AddLims(this IServiceCollection services)
        {
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

            services.AddScoped<IOrderAppService, OrderAppService>();
            services.AddScoped<IMolecularCloningAppService, MolecularCloningAppService>();
            services.AddScoped<IPlasmidPurificationAppService, PlasmidPurificationAppService>();
            services.AddScoped<IQpcrDetectionAppService, QpcrDetectionAppService>();
            services.AddScoped<ISdsPageDetectionAppService, SdsPageDetectionAppService>();
            services.AddScoped<ISterilityDetectionAppService, SterilityDetectionAppService>();
            services.AddScoped<IStockInAppService, StockInAppService>();
            services.AddScoped<IShipmentAppService, ShipmentAppService>();
            services.AddScoped<IFileAppService, FileAppService>();
        }
    }
}
