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
    /// 入库记录
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/stockins")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    [AllowAnonymous]
    public class StockInController : ControllerBase
    {
        private readonly IStockInAppService _service;
        private readonly ILogger<StockInController> _logger;

        public StockInController(IStockInAppService service, ILogger<StockInController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取入库记录，可根据合同编号、合同类型、载体编号、状态或创建时间查询
        /// </summary>
        /// <param name="parameters">StockInQueryParameters</param>
        /// <returns>StockInDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<StockInApiResult>> GetStockIns([FromQuery] StockInQueryParameters parameters)
        {
            _logger.LogInformation("Query string for StockIn: {0}", parameters);
            var pageddtos = await _service.GetStockInsByPage(parameters);
            return StockInApiResult.Succeed(pageddtos, pageddtos.TotalCount);
        }

        /// <summary>
        /// 完成入库记录
        /// </summary>
        /// <param name="stockInId">Guid</param>
        /// <param name="updateDto">StockInUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{stockInId}")]
        public async Task<ActionResult<StringApiResult>> UpdateStockIn(Guid stockInId, StockInUpdateDto updateDto)
        {
            try
            {
                var result = await _service.UpdateStockIn(stockInId, updateDto);
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
