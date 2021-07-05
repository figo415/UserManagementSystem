using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Application.Dtos;
using AutoMapper;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Application.Exceptions;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public class DeviceAppService:IDeviceAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public DeviceAppService(IRepositoryWrapper wrapper, IMapper mapper)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
        }

        public async Task<PagedList<DeviceDto>> GetDevicesByPage(DeviceQueryParameters parameters)
        {
            var pagedDevices = await _repoWrapper.DeviceRepo.GetDevicesByPage(parameters);
            var pagedDtos = _mapper.Map<IEnumerable<DeviceDto>>(pagedDevices);
            return new PagedList<DeviceDto>(pagedDtos.ToList(), pagedDevices.TotalCount, pagedDevices.CurrentPage, pagedDevices.PageSize);
        }

        public async Task<bool> InsertDevice(DeviceCreationDto dto)
        {
            var device = _mapper.Map<Device>(dto);
            device.Id = Guid.NewGuid();
            device.CreatedAt = DateTime.Now;
            device.IsDeleted = false;
            _repoWrapper.DeviceRepo.Create(device);
            var result = await _repoWrapper.DeviceRepo.SaveAsync();
            return result;
        }

        public async Task<bool> UpdateDevice(Guid deviceId, DeviceUpdateDto dto)
        {
            var device = await _repoWrapper.DeviceRepo.GetByIdAsync(deviceId);
            if (device == null)
            {
                throw new NotExistedException("Device with Guid=" + deviceId + " is not existed");
            }
            _mapper.Map(dto, device, typeof(DeviceUpdateDto), typeof(Device));
            device.LastModifiedAt = DateTime.Now;
            _repoWrapper.DeviceRepo.Update(device);
            var result = await _repoWrapper.DeviceRepo.SaveAsync();
            return result;
        }

        public async Task<bool> DeleteDevices(DeleteMultiDto dto)
        {
            foreach (var deviceId in dto.Guids)
            {
                var device = await _repoWrapper.DeviceRepo.GetByIdAsync(deviceId);
                if (device == null)
                {
                    continue;
                }
                device.IsDeleted = true;
                device.LastModifiedAt = DateTime.Now;
                _repoWrapper.DeviceRepo.Update(device);
            }
            var result = await _repoWrapper.DeviceRepo.SaveAsync();
            return result;
        }
    }
}
