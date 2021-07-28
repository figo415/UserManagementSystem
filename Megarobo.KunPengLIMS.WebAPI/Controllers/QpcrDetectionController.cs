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
    /// qPCR检测
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/qpcrs")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    public class QpcrDetectionController : ControllerBase
    {
        private readonly IQpcrDetectionAppService _service;
        private readonly ILogger<QpcrDetectionController> _logger;

        public QpcrDetectionController(IQpcrDetectionAppService service, ILogger<QpcrDetectionController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取qPCR检测，可根据合同编号、合同类型、载体编号、状态或创建时间查询
        /// </summary>
        /// <param name="parameters">QpcrDetectionQueryParameters</param>
        /// <returns>QpcrDetectionDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<QpcrDetectionApiResult>> GetQpcrDetections([FromQuery] QpcrDetectionQueryParameters parameters)
        {
            _logger.LogInformation("Query string for QpcrDetection: {0}", parameters);
            var pageddtos = await _service.GetQpcrDetectionsByPage(parameters);
            return QpcrDetectionApiResult.Succeed(pageddtos, pageddtos.TotalCount);
        }

        /// <summary>
        /// 完成qPCR检测
        /// </summary>
        /// <param name="qpcrDetectionId">Guid</param>
        /// <param name="updateDto">QpcrDetectionUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{qpcrDetectionId}")]
        public async Task<ActionResult<StringApiResult>> UpdateQpcrDetection(Guid qpcrDetectionId, QpcrDetectionUpdateDto updateDto)
        {
            try
            {
                var result = await _service.UpdateQpcrDetection(qpcrDetectionId, updateDto);
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
