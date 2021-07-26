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
    /// 订单管理
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/orders")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    public class OrderController : ControllerBase
    {
        private readonly IOrderAppService _service;
        private readonly ILogger<OrderController> _logger;

        public OrderController(IOrderAppService service, ILogger<OrderController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取订单，可根据合同号、载体编号、合同类型、订单状态或创建时间查询
        /// </summary>
        /// <param name="parameters">OrderQueryParameters</param>
        /// <returns>OrderDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<OrderApiResult>> GetOrders([FromQuery] OrderQueryParameters parameters)
        {
            _logger.LogInformation("Query string for Order: {0}", parameters);
            var pageddtos = await _service.GetOrdersByPage(parameters);
            return OrderApiResult.Succeed(pageddtos, pageddtos.TotalCount);
        }

        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="creationDto">OrderCreationDto</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<StringApiResult>> CreateOrder(OrderCreationDto creationDto)
        {
            try
            {
                var result = await _service.InsertOrder(creationDto);
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

        /// <summary>
        /// 修改订单
        /// </summary>
        /// <param name="orderId">Guid</param>
        /// <param name="updateDto">OrderUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{orderId}")]
        public async Task<ActionResult<StringApiResult>> UpdateOrder(Guid orderId, OrderUpdateDto updateDto)
        {
            try
            {
                var result = await _service.UpdateOrder(orderId, updateDto);
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

        /// <summary>
        /// 取消订单
        /// </summary>
        /// <param name="orderId">Guid</param>
        /// <param name="updateDto">OrderUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{orderId}/cancel")]
        public async Task<ActionResult<StringApiResult>> CancelOrder(Guid orderId, OrderUpdateDto updateDto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 分子克隆
        /// </summary>
        /// <param name="orderId">Guid</param>
        /// <param name="updateDto">OrderUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{orderId}/clone")]
        public async Task<ActionResult<StringApiResult>> CloneMolecule(Guid orderId, OrderUpdateDto updateDto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 质粒纯化
        /// </summary>
        /// <param name="orderId">Guid</param>
        /// <param name="updateDto">OrderUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{orderId}/purify")]
        public async Task<ActionResult<StringApiResult>> PurifyPlasmid(Guid orderId, OrderUpdateDto updateDto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 进入生产
        /// </summary>
        /// <param name="orderId">Guid</param>
        /// <param name="updateDto">OrderUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{orderId}/produce")]
        public async Task<ActionResult<StringApiResult>> StartProduce(Guid orderId, OrderUpdateDto updateDto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// QC & 入库
        /// </summary>
        /// <param name="orderId">Guid</param>
        /// <param name="updateDto">OrderUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{orderId}/stockin")]
        public async Task<ActionResult<StringApiResult>> TestStockIn(Guid orderId, OrderUpdateDto updateDto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 完成
        /// </summary>
        /// <param name="orderId">Guid</param>
        /// <param name="updateDto">OrderUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{orderId}/finish")]
        public async Task<ActionResult<StringApiResult>> FinishOrder(Guid orderId, OrderUpdateDto updateDto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 批量删除订单
        /// </summary>
        /// <param name="dto">DeleteMultiDto</param>
        /// <returns></returns>
        [HttpPut("deletemulti")]
        public async Task<ActionResult<StringApiResult>> DeleteCell(DeleteMultiDto dto)
        {
            try
            {
                var result = await _service.DeleteOrders(dto);
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
