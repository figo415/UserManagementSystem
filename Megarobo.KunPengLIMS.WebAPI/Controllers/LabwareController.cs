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
    /// 耗材管理
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/labwares")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    public class LabwareController : ControllerBase
    {
        private readonly ILabwareAppService _service;
        private readonly ILogger<LabwareController> _logger;

        public LabwareController(ILabwareAppService service, ILogger<LabwareController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取耗材，可根据名称、类型或创建时间查询
        /// </summary>
        /// <param name="parameters">LabwareQueryParameters</param>
        /// <returns>LabwareDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<LabwareApiResult>> GetLabwares([FromQuery] LabwareQueryParameters parameters)
        {
            _logger.LogInformation("Query string for Labware: {0}", parameters);
            var pageddtos = await _service.GetLabwares(parameters);
            return LabwareApiResult.Succeed(pageddtos, pageddtos.TotalCount);
        }
    }
}
