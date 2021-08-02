using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using Megarobo.KunPengLIMS.Application.Services;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.WebAPI.Models;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.WebAPI.Filters;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    /// <summary>
    /// 无菌检测
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/sterilities")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    [AllowAnonymous]
    public class SterilityDetectionController : ControllerBase
    {
        private readonly ISterilityDetectionAppService _service;
        private readonly ILogger<SterilityDetectionController> _logger;

        public SterilityDetectionController(ISterilityDetectionAppService service, ILogger<SterilityDetectionController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取无菌检测，可根据合同编号、合同类型、载体编号、状态或创建时间查询
        /// </summary>
        /// <param name="parameters">SterilityDetectionQueryParameters</param>
        /// <returns>SterilityDetectionDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<SterilityDetectionApiResult>> GetSterilityDetections([FromQuery] SterilityDetectionQueryParameters parameters)
        {
            _logger.LogInformation("Query string for SterilityDetection: {0}", parameters);
            var pageddtos = await _service.GetSterilityDetectionsByPage(parameters);
            return SterilityDetectionApiResult.Succeed(pageddtos, pageddtos.TotalCount);
        }

        /// <summary>
        /// 完成无菌检测
        /// </summary>
        /// <param name="sterilityDetectionId">Guid</param>
        /// <param name="updateDto">SterilityDetectionUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{sterilityDetectionId}")]
        public async Task<ActionResult<StringApiResult>> UpdateSterilityDetection(Guid sterilityDetectionId, SterilityDetectionUpdateDto updateDto)
        {
            try
            {
                var result = await _service.UpdateSterilityDetection(sterilityDetectionId, updateDto);
                if (result)
                {
                    return StringApiResult.Succeed();
                }
                return StringApiResult.Fail();
            }
            catch (Exception ex)
            {
                return StringApiResult.Error(ex.Message);
            }
        }
    }
}
