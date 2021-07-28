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
    /// SDS-PAGE检测
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/sdspages")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    public class SdsPageDetectionController : ControllerBase
    {
        private readonly ISdsPageDetectionAppService _service;
        private readonly ILogger<SdsPageDetectionController> _logger;

        public SdsPageDetectionController(ISdsPageDetectionAppService service, ILogger<SdsPageDetectionController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取SDS-PAGE检测，可根据合同编号、合同类型、载体编号、状态或创建时间查询
        /// </summary>
        /// <param name="parameters">SdsPageDetectionQueryParameters</param>
        /// <returns>SdsPageDetectionDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<SdsPageDetectionApiResult>> GetSdsPageDetections([FromQuery] SdsPageDetectionQueryParameters parameters)
        {
            _logger.LogInformation("Query string for SdsPageDetection: {0}", parameters);
            var pageddtos = await _service.GetSdsPageDetectionsByPage(parameters);
            return SdsPageDetectionApiResult.Succeed(pageddtos, pageddtos.TotalCount);
        }

        /// <summary>
        /// 完成SDS-PAGE检测
        /// </summary>
        /// <param name="sdsPageDetectionId">Guid</param>
        /// <param name="updateDto">SdsPageDetectionUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{sdsPageDetectionId}")]
        public async Task<ActionResult<StringApiResult>> UpdateSdsPageDetection(Guid sdsPageDetectionId, SdsPageDetectionUpdateDto updateDto)
        {
            try
            {
                var result = await _service.UpdateSdsPageDetection(sdsPageDetectionId, updateDto);
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
