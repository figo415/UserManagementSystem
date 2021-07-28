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
    /// 发货记录
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/shipments")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    public class ShipmentController : ControllerBase
    {
        private readonly IShipmentAppService _service;
        private readonly ILogger<ShipmentController> _logger;

        public ShipmentController(IShipmentAppService service, ILogger<ShipmentController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取发货记录，可根据合同编号、合同类型、载体编号、状态或创建时间查询
        /// </summary>
        /// <param name="parameters">ShipmentQueryParameters</param>
        /// <returns>ShipmentDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<ShipmentApiResult>> GetShipments([FromQuery] ShipmentQueryParameters parameters)
        {
            _logger.LogInformation("Query string for Shipment: {0}", parameters);
            var pageddtos = await _service.GetShipmentsByPage(parameters);
            return ShipmentApiResult.Succeed(pageddtos, pageddtos.TotalCount);
        }

        /// <summary>
        /// 完成发货记录
        /// </summary>
        /// <param name="shipmentId">Guid</param>
        /// <param name="updateDto">ShipmentUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{shipmentId}")]
        public async Task<ActionResult<StringApiResult>> UpdateShipment(Guid shipmentId, ShipmentUpdateDto updateDto)
        {
            try
            {
                var result = await _service.UpdateShipment(shipmentId, updateDto);
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
