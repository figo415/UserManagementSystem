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
    /// 位置管理
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/positions")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    public class PositionController : ControllerBase
    {
        private readonly IPositionAppService _service;
        private readonly ILogger<PositionController> _logger;

        public PositionController(IPositionAppService service, ILogger<PositionController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取位置，可根据名称查询
        /// </summary>
        /// <param name="parameters">PositionQueryParameters</param>
        /// <returns>PositionDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<ApiResult<LocationDtoList>>> GetPositions([FromQuery] PositionQueryParameters parameters)
        {
            _logger.LogInformation("Query string for Position: {0}", parameters);
            var dtos = await _service.GetPositions();
            var list = new LocationDtoList(dtos);
            return ApiResult<LocationDtoList>.HasData(list, dtos.Count());
        }
    }
}
