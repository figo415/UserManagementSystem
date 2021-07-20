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
    /// 细胞管理
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/cells")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    public class CellController : ControllerBase
    {
        private readonly ICellAppService _service;
        private readonly ILogger<CellController> _logger;

        public CellController(ICellAppService service, ILogger<CellController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取细胞，可根据名称、组织类型、细胞系种类或创建时间查询
        /// </summary>
        /// <param name="parameters">CellQueryParameters</param>
        /// <returns>CellDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<CellApiResult>> GetCells([FromQuery] CellQueryParameters parameters)
        {
            _logger.LogInformation("Query string for Cell: {0}", parameters);
            var pageddtos = await _service.GetCellsByPage(parameters);
            //var list = new CellDtoList(pageddtos);
            //return ApiResult<CellDtoList>.HasData(list, pageddtos.TotalCount);
            return CellApiResult.Succeed(pageddtos, pageddtos.TotalCount);
        }

        /// <summary>
        /// 添加细胞
        /// </summary>
        /// <param name="creationDto">CellCreationDto</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<StringApiResult>> CreateCell(CellCreationDto creationDto)
        {
            try
            {
                var result = await _service.InsertCell(creationDto);
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
        /// 修改细胞
        /// </summary>
        /// <param name="cellId">Guid</param>
        /// <param name="updateDto">CellUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{cellId}")]
        public async Task<ActionResult<StringApiResult>> UpdateCell(Guid cellId, CellUpdateDto updateDto)
        {
            try
            {
                var result = await _service.UpdateCell(cellId, updateDto);
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
        /// 批量删除细胞
        /// </summary>
        /// <param name="dto">DeleteMultiDto</param>
        /// <returns></returns>
        [HttpPut("deletemulti")]
        public async Task<ActionResult<StringApiResult>> DeleteCell(DeleteMultiDto dto)
        {
            try
            {
                var result = await _service.DeleteCells(dto);
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
