using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public interface IDeviceAppService
    {
        Task<PagedList<DeviceDto>> GetDevicesByPage(DeviceQueryParameters parameters);

        Task<bool> InsertDevice(DeviceCreationDto dto);

        Task<bool> UpdateDevice(Guid deviceId, DeviceUpdateDto dto);

        Task<bool> DeleteDevices(DeleteMultiDto dto);
    }
}
