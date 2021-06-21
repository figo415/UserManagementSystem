using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.LogItemApp.Dtos;
using Megarobo.KunPengLIMS.WebAPI.Models;
using Megarobo.KunPengLIMS.Application.LogItemApp;
using Megarobo.KunPengLIMS.Domain.QueryParameters;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    /// <summary>
    /// 日志项管理
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/logitems")]
    [ApiController]
    public class LogitemController : LimsControllerBase
    {
        private readonly ILogItemAppService _service;
        private readonly ILogger<LogitemController> _logger;

        public LogitemController(ILogItemAppService service, ILogger<LogitemController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取所有日志项，可根据用户名称或者状态来查询
        /// </summary>
        /// <returns>LogItemDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<ApiResult<LogItemDtoList>>> GetLogItems([FromQuery] LogItemQueryParameters parameters)
        {
            _logger.LogInformation("Query string for LogItem: Operator={0}", parameters.Operator);
            var pageddtos = await _service.GetLogItemsByPage(parameters);
            var list = new LogItemDtoList(pageddtos);
            return ApiResult<LogItemDtoList>.HasData(list, pageddtos.TotalCount);
        }

        /// <summary>
        /// 根据主键获取日志项
        /// </summary>
        /// <param name="logItemId">int</param>
        /// <returns>LogItemDto</returns>
        [HttpGet("{logItemId}")]
        public async Task<ActionResult<ApiResult<LogItemDto>>> GetLogItem(int logItemId)
        {
            throw new NotImplementedException();
        }
    }
}
