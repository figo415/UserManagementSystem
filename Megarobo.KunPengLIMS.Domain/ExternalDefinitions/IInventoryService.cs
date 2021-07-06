using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain.Externals;

namespace Megarobo.KunPengLIMS.Domain.ExternalDefinitions
{
    public interface IInventoryService
    {
        Task<InventoryData> GetInventory(InventoryParameters parameters);
    }
}
