using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain.Externals;

namespace Megarobo.KunPengLIMS.Domain.ExternalDefinitions
{
    public interface ILocationService
    {
        Task<List<Location>> GetLocations();

        Task<List<Location>> GetLocation(Guid id);

        Task<bool> InsertLocation(LocationCreationRequest request);
    }
}
