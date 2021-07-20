using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.Application.Services;
using Megarobo.KunPengLIMS.WebAPI.Models;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.WebAPI.Filters;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    /// <summary>
    /// 角色管理
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/roles")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    public class RoleController : ControllerBase
    {
        private readonly IRoleAppService _service;
        private readonly ILogger<RoleController> _logger;

        public RoleController(IRoleAppService service, ILogger<RoleController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取所有角色，可根据角色名称和状态查询
        /// </summary>
        /// <param name="parameters">RoleQueryParameters</param>
        /// <returns>RoleDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<RoleApiResult>> GetRoles([FromQuery]RoleQueryParameters parameters)
        {
            _logger.LogInformation("Query string for Role: {0}", parameters);
            //var pageddtos = await _service.GetRolesByPage(parameters);
            var pageddtos = await _service.GetRolesWithMenuByPage(parameters);
            return RoleApiResult.Succeed(pageddtos, pageddtos.TotalCount);
        }

        ///// <summary>
        ///// 根据主键获取角色
        ///// </summary>
        ///// <param name="roleId">Guid</param>
        ///// <returns>RoleDto</returns>
        //[HttpGet("{roleId}")]
        //public async Task<ActionResult<ApiResult<RoleDto>>> GetRole(Guid roleId)
        //{
        //    throw new NotImplementedException();
        //}

        /// <summary>
        /// 获取某个角色对应的菜单列表
        /// </summary>
        /// <param name="roleId">Guid</param>
        /// <returns>MenuDto列表</returns>
        [HttpGet("{roleId}/menus")]
        public async Task<ActionResult<MenuApiResult>> GetMenusForRole(Guid roleId)
        {
            var dtos = await _service.GetMenusForRole(roleId);
            return MenuApiResult.Succeed(dtos, dtos.Count());
        }

        /// <summary>
        /// 新增角色
        /// </summary>
        /// <param name="roleDto">RoleCreationDto</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<StringApiResult>> CreateRole(RoleCreationDto roleDto)
        {
            try
            {
                var result = await _service.InsertRole(roleDto);
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
        /// 修改角色
        /// </summary>
        /// <param name="roleId">Guid</param>
        /// <param name="roleDto">RoleUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{roleId}")]
        public async Task<ActionResult<StringApiResult>> UpdateRole(Guid roleId,RoleUpdateDto roleDto)
        {
            try
            {
                var result = await _service.UpdateRole(roleId, roleDto);
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
        /// 修改角色状态
        /// </summary>
        /// <param name="roleId">Guid</param>
        /// <param name="dto">RoleUpdateStatusDto</param>
        /// <returns></returns>
        [HttpPut("{roleId}/enable")]
        public async Task<ActionResult<StringApiResult>> EnableRole(Guid roleId,RoleUpdateStatusDto dto)
        {
            try
            {
                var result = await _service.EnableRole(roleId, dto);
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
        /// 批量删除角色
        /// </summary>
        /// <param name="dto">DeleteMultiDto</param>
        /// <returns></returns>
        [HttpPut("deletemulti")]
        public async Task<ActionResult<StringApiResult>> DeleteRoles(DeleteMultiDto dto)
        {
            try
            {
                var result = await _service.DeleteRoles(dto);
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
