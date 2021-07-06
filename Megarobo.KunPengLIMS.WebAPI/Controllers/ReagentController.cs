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
    /// 试剂管理
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/reagents")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    public class ReagentController : ControllerBase
    {
        private readonly IReagentAppService _service;
        private readonly ILogger<ReagentController> _logger;

        public ReagentController(IReagentAppService service, ILogger<ReagentController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取试剂，可根据名称、类型或创建时间查询
        /// </summary>
        /// <param name="parameters">ReagentQueryParameters</param>
        /// <returns>ReagentDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<ApiResult<ReagentDtoList>>> GetReagents([FromQuery] ReagentQueryParameters parameters)
        {
            _logger.LogInformation("Query string for Labware: {0}", parameters);
            var pageddtos = await _service.GetReagents(parameters);
            var list = new ReagentDtoList(pageddtos);
            return ApiResult<ReagentDtoList>.HasData(list, pageddtos.TotalCount);
        }
    }
}
