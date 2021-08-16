using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Megarobo.KunPengLIMS.Domain.ExternalDefinitions;
using Megarobo.KunPengLIMS.Infrastructure.ExternalImplementations;
using Megarobo.KunPengLIMS.Infrastructure.Utility;

namespace Megarobo.KunPengLIMS.Infrastructure.ServiceExtensions
{
    public static class InventoryServiceExtension
    {
        public static void AddInventory(this IServiceCollection services,string connectionString)
        {
            var inventoryInstance = new InventoryService(connectionString);
            Console.WriteLine("Inventory system connection string: " + connectionString);
            services.AddSingleton<IInventoryService>(inventoryInstance);
        }
    }
}
