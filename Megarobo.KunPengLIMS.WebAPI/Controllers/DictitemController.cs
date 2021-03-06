using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Services;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.WebAPI.Models;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.WebAPI.Filters;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    /// <summary>
    /// 字典项管理
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/dictitems")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    public class DictitemController : LimsControllerBase
    {
        private readonly IDictItemAppService _service;
        private readonly ILogger<DictitemController> _logger;

        public DictitemController(IDictItemAppService service, ILogger<DictitemController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取所有字典项，可根据字典名称或者字典类型查询
        /// </summary>
        /// <param name="parameters">DictItemQueryParameters</param>
        /// <returns>DictItemDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<ApiResult<DictItemDtoList>>> GetDictItems([FromQuery] DictItemQueryParameters parameters)
        {
            _logger.LogInformation("Query string for DictItem: {0}", parameters);
            var pageddtos = await _service.GetDictItemsByPage(parameters);
            var list = new DictItemDtoList(pageddtos);
            return ApiResult<DictItemDtoList>.HasData(list, pageddtos.TotalCount);
        }

        /// <summary>
        /// 根据主键获取字典项
        /// </summary>
        /// <param name="dictItemId">Guid</param>
        /// <returns>DictItemDto</returns>
        [HttpGet("{dictItemId}")]
        public ActionResult<ApiResult<DictItemDto>> GetDictItem(Guid dictItemId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 新增字典项
        /// </summary>
        /// <param name="dictItemDto">DictItemCreationDto</param>
        /// <returns></returns>
        [HttpPost]
        public  async Task<ActionResult<ApiStringResult>> CreateDictItem(DictItemCreationDto dictItemDto)
        {
            try
            {
                var result = await _service.InsertDictItem(dictItemDto);
                if (result)
                {
                    return ApiStringResult.Succeed();
                }
                return ApiStringResult.Fail();
            }
            catch (Exception ex)
            {
                return ApiStringResult.Error(ex.Message);
            }
        }

        /// <summary>
        /// 修改字典项
        /// </summary>
        /// <param name="dictItemId">Guid</param>
        /// <param name="dictItemDto">DictItemUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{dictItemId}")]
        public async Task<ActionResult<ApiStringResult>> UpdateDictItem(Guid dictItemId,DictItemUpdateDto dictItemDto)
        {
            try
            {
                var result = await _service.UpdateDictItem(dictItemId, dictItemDto);
                if (result)
                {
                    return ApiStringResult.Succeed();
                }
                return ApiStringResult.Fail();
            }
            catch (Exception ex)
            {
                return ApiStringResult.Error(ex.Message);
            }
        }

        /// <summary>
        /// 维护字典项的值，包括添加、修改、删除
        /// </summary>
        /// <param name="dictItemId">Guid</param>
        /// <param name="dto">DictItemUpdateValueDto</param>
        /// <returns></returns>
        [HttpPut("{dictItemId}/values")]
        public async Task<ActionResult<ApiStringResult>> MaintainValuesForDictItem(Guid dictItemId,DictItemUpdateValueDto dto)
        {
            try
            {
                var result = await _service.UpdateDictItemValues(dictItemId, dto);
                if (result)
                {
                    return ApiStringResult.Succeed();
                }
                return ApiStringResult.Fail();
            }
            catch (Exception ex)
            {
                return ApiStringResult.Error(ex.Message);
            }
        }

        /// <summary>
        /// 批量删除字典项
        /// </summary>
        /// <param name="dto">DeleteMultiDto</param>
        /// <returns></returns>
        [HttpPut("deletemulti")]
        public async Task<ActionResult<ApiStringResult>> DeleteDictItems(DeleteMultiDto dto)
        {
            try
            {
                var result = await _service.DeleteDictItems(dto);
                if (result)
                {
                    return ApiStringResult.Succeed();
                }
                return ApiStringResult.Fail();
            }
            catch (Exception ex)
            {
                return ApiStringResult.Error(ex.Message);
            }
        }
    }
}
