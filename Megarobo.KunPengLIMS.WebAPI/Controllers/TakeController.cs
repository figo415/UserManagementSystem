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
    /// Take管理
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/takes")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    public class TakeController : ControllerBase
    {
        private readonly ITakeAppService _service;
        private readonly ILogger<TakeController> _logger;

        public TakeController(ITakeAppService service, ILogger<TakeController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取Take，可根据项目名称、Take号或状态查询
        /// </summary>
        /// <param name="parameters">TakeQueryParameters</param>
        /// <returns>TakeDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<ApiResult<TakeDtoList>>> GetTakes([FromQuery] TakeQueryParameters parameters)
        {
            _logger.LogInformation("Query string for Take: {0}", parameters);
            var pageddtos = await _service.GetTakesByPage(parameters);
            var list = new TakeDtoList(pageddtos);
            return ApiResult<TakeDtoList>.HasData(list, pageddtos.TotalCount);
        }

        /// <summary>
        /// 添加Take
        /// </summary>
        /// <param name="creationDto">TakeCreationDto</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<StringApiResult>> CreateTake(TakeCreationDto creationDto)
        {
            try
            {
                var result = await _service.InsertTake(creationDto);
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
        /// 修改Take
        /// </summary>
        /// <param name="takeId">Guid</param>
        /// <param name="updateDto">TakeUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{takeId}")]
        public async Task<ActionResult<StringApiResult>> UpdateTake(Guid takeId, TakeUpdateDto updateDto)
        {
            try
            {
                var result = await _service.UpdateTake(takeId, updateDto);
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
        /// 终止Take
        /// </summary>
        /// <param name="takeId">Guid</param>
        /// <param name="updateDto">TakeUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{takeId}/status")]
        public Task<ActionResult<StringApiResult>> UpdateStatusOfTake(Guid takeId, TakeUpdateDto updateDto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 批量删除Take
        /// </summary>
        /// <param name="dto">DeleteMultiDto</param>
        /// <returns></returns>
        [HttpPut("deletemulti")]
        public async Task<ActionResult<StringApiResult>> DeleteTake(DeleteMultiDto dto)
        {
            try
            {
                var result = await _service.DeleteTakes(dto);
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
