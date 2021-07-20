using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Application.Exceptions;
using Megarobo.KunPengLIMS.Domain;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Domain.Entities;
using Megarobo.KunPengLIMS.Domain.ExternalDefinitions;
using Megarobo.KunPengLIMS.Domain.Externals;

namespace Megarobo.KunPengLIMS.Application.Services
{
    public class DeviceAppService:IDeviceAppService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;
        private readonly ILocationService _locationService;

        public DeviceAppService(IRepositoryWrapper wrapper, IMapper mapper, ILocationService locationService)
        {
            _repoWrapper = wrapper;
            _mapper = mapper;
            _locationService = locationService;
        }

        public async Task<PagedList<DeviceDto>> GetDevicesByPage(DeviceQueryParameters parameters)
        {
            var pagedDevices = await _repoWrapper.DeviceRepo.GetDevicesByPage(parameters);
            var pagedDtos = _mapper.Map<List<DeviceDto>>(pagedDevices);
            foreach(var dto in pagedDtos)
            {
                var locationlist = await _locationService.GetLocation(dto.Id);
                dto.Positions = _mapper.Map<List<LocationDto>>(locationlist);
            }
            return new PagedList<DeviceDto>(pagedDtos, pagedDevices.TotalCount, pagedDevices.PageNumber, pagedDevices.PageSize);
        }

        public async Task<bool> InsertDevice(DeviceCreationDto dto)
        {
            var existed = await _repoWrapper.DeviceRepo.GetDeviceByName(dto.Name);
            if (existed.Any())
            {
                throw new AlreadyExistedException("Device with Name=" + dto.Name + " is already existed");
            }
            var device = _mapper.Map<Device>(dto);
            device.Id = Guid.NewGuid();
            device.CreatedAt = DateTime.Now;
            device.IsDeleted = false;
            _repoWrapper.DeviceRepo.Create(device);
            var result = await _repoWrapper.DeviceRepo.SaveAsync();
            if(result)
            {
                result = await InsertDeviceLocation(device.Id, dto.Name, dto.Positions);
                if(!result)
                {
                     await DeleteDevice(device.Id);
                }
            }
            return result;
        }

        private async Task<bool> InsertDeviceLocation(Guid deviceId, string name, List<LocationDto> positions)
        {
            var request = new LocationCreationRequest();
            request.id = deviceId;
            request.name = name;
            request.positions = _mapper.Map<List<Location>>(positions);
            var result = await _locationService.InsertLocation(request);
            return result;
        }

        public async Task<bool> UpdateDevice(Guid deviceId, DeviceUpdateDto dto)
        {
            var device = await _repoWrapper.DeviceRepo.GetByIdAsync(deviceId);
            if (device == null)
            {
                throw new NotExistedException("Device with Guid=" + deviceId + " is not existed");
            }
            if(dto.Name!=device.Name)
            {
                var existed = await _repoWrapper.DeviceRepo.GetDeviceByName(dto.Name);
                if (existed.Any())
                {
                    throw new AlreadyExistedException("Device with Name=" + dto.Name + " is already existed");
                }
            }
            _mapper.Map(dto, device, typeof(DeviceUpdateDto), typeof(Device));
            device.LastModifiedAt = DateTime.Now;
            _repoWrapper.DeviceRepo.Update(device);
            var result = await _repoWrapper.DeviceRepo.SaveAsync();
            if (result)
            {
                result = await InsertDeviceLocation(device.Id, device.Name, dto.Positions);
                if(!result)
                {

                }
            }
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
                await _locationService.DeleteLocation(device.Id);
            }
            var result = await _repoWrapper.DeviceRepo.SaveAsync();
            return result;
        }

        private async Task<bool> DeleteDevice(Guid deviceId)
        {
            var device = await _repoWrapper.DeviceRepo.GetByIdAsync(deviceId);
            if(device==null)
            {
                return false;
            }
            _repoWrapper.DeviceRepo.Delete(device);
            var result = await _repoWrapper.DeviceRepo.SaveAsync();
            return result;
        }
    }
}
