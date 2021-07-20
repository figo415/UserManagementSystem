using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Application.Services;
using Megarobo.KunPengLIMS.WebAPI.Models;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.WebAPI.Filters;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    /// <summary>
    /// 菜单管理
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/menus")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    public class MenuController : ControllerBase
    {
        private readonly IMenuAppService _service;
        private readonly ILogger<UserController> _logger;

        public MenuController(IMenuAppService service, ILogger<UserController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取所有菜单，可根据菜单名称、状态和类型查询
        /// </summary>
        /// <param name="parameters">MenuQueryParameters</param>
        /// <returns>MenuDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<MenuApiResult>> GetMenus([FromQuery] MenuQueryParameters parameters)
        {
            _logger.LogInformation("Query string for Menu: {0}", parameters);
            if(string.IsNullOrEmpty(parameters.Name))
            {
                var dtos = await _service.GetMenuTree(parameters);
                return MenuApiResult.Succeed(dtos, dtos.Count());
            }
            var pageddtos = await _service.GetMenusByPage(parameters);
            return MenuApiResult.Succeed(pageddtos, pageddtos.TotalCount);
        }

        ///// <summary>
        ///// 根据主键获取菜单
        ///// </summary>
        ///// <param name="menuId">Guid</param>
        ///// <returns>MenuDto</returns>
        //[HttpGet("{menuId}")]
        //public async Task<ActionResult<ApiResult<MenuDto>>> GetMenu(Guid menuId)
        //{
        //    throw new NotImplementedException();
        //}

        /// <summary>
        /// 新增菜单
        /// </summary>
        /// <param name="menuDto">MenuCreationDto</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<StringApiResult>> CreateMenu(MenuCreationDto menuDto)
        {
            try
            {
                var result = await _service.InsertMenu(menuDto);
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
        /// 修改菜单
        /// </summary>
        /// <param name="menuId">Guid</param>
        /// <param name="menuDto">MenuUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{menuId}")]
        public async Task<ActionResult<StringApiResult>> UpdateMenu(Guid menuId,MenuUpdateDto menuDto)
        {
            try
            {
                var result = await _service.UpdateMenu(menuId, menuDto);
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
        /// 修改菜单状态
        /// </summary>
        /// <param name="menuId">Guid</param>
        /// <param name="dto">MenuUpdateStatusDto</param>
        /// <returns></returns>
        [HttpPut("{menuId}/enable")]
        public async Task<ActionResult<StringApiResult>> EnableMenu(Guid menuId,MenuUpdateStatusDto dto)
        {
            try
            {
                var result = await _service.EnableMenu(menuId, dto);
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
        /// 批量删除菜单
        /// </summary>
        /// <param name="dto">DeleteMultiDto</param>
        /// <returns></returns>
        [HttpPut("deletemulti")]
        public async Task<ActionResult<StringApiResult>> DeleteMenus(DeleteMultiDto dto)
        {
            try
            {
                var result = await _service.DeleteMenus(dto);
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
