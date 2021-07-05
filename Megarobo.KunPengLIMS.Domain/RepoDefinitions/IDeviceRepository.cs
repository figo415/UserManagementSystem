using System;
using System.Collections.Generic;
using System.Text;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface IDeviceRepository:IRepositoryBase<Device>,IRepositoryBase2<Device,Guid>
    {
        System.Threading.Tasks.Task<PagedList<Device>> GetDevicesByPage(DeviceQueryParameters parameters);
    }
}
