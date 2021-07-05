using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Megarobo.KunPengLIMS.Application.Services;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.WebAPI.Models;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.WebAPI.Filters;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    /// <summary>
    /// 设备管理
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/devices")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceAppService _service;
        private readonly ILogger<DeviceController> _logger;

        public DeviceController(IDeviceAppService service, ILogger<DeviceController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取设备，可根据名称、类型或创建时间查询
        /// </summary>
        /// <param name="parameters">DeviceQueryParameters</param>
        /// <returns>DeviceDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<ApiResult<DeviceDtoList>>> GetDevices([FromQuery] DeviceQueryParameters parameters)
        {
            _logger.LogInformation("Query string for Device: {0}", parameters);
            var pageddtos = await _service.GetDevicesByPage(parameters);
            var list = new DeviceDtoList(pageddtos);
            return ApiResult<DeviceDtoList>.HasData(list, pageddtos.TotalCount);
        }

        /// <summary>
        /// 添加设备
        /// </summary>
        /// <param name="creationDto">DeviceCreationDto</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<ApiStringResult>> CreateDevice(DeviceCreationDto creationDto)
        {
            try
            {
                var result = await _service.InsertDevice(creationDto);
                if (result)
                {
                    return ApiStringResult.Succeed();
                }
                return ApiStringResult.Fail();
            }
            catch (Exception ex)
            {
                return ApiStringResult.Error(ex.Message);
            }
        }

        /// <summary>
        /// 修改设备
        /// </summary>
        /// <param name="deviceId">Guid</param>
        /// <param name="updateDto">DeviceUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{deviceId}")]
        public async Task<ActionResult<ApiStringResult>> UpdateDevice(Guid deviceId, DeviceUpdateDto updateDto)
        {
            try
            {
                var result = await _service.UpdateDevice(deviceId, updateDto);
                if (result)
                {
                    return ApiStringResult.Succeed();
                }
                return ApiStringResult.Fail();
            }
            catch (Exception ex)
            {
                return ApiStringResult.Error(ex.Message);
            }
        }

        /// <summary>
        /// 批量删除设备
        /// </summary>
        /// <param name="dto">DeleteMultiDto</param>
        /// <returns></returns>
        [HttpPut("deletemulti")]
        public async Task<ActionResult<ApiStringResult>> DeleteSpecies(DeleteMultiDto dto)
        {
            try
            {
                var result = await _service.DeleteDevices(dto);
                if (result)
                {
                    return ApiStringResult.Succeed();
                }
                return ApiStringResult.Fail();
            }
            catch (Exception ex)
            {
                return ApiStringResult.Error(ex.Message);
            }
        }
    }
}
