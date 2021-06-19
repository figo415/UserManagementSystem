using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Megarobo.KunPengLIMS.Application.RoleApp.Dtos;
using Megarobo.KunPengLIMS.Application.RoleApp;
using Megarobo.KunPengLIMS.Application.MenuApp.Dtos;
using Megarobo.KunPengLIMS.WebAPI.Models;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    /// <summary>
    /// 角色管理
    /// </summary>
    [Route("limsapi/roles")]
    [ApiController]
    public class RoleController : LimsControllerBase
    {
        private readonly IRoleAppService _service;

        public RoleController(IRoleAppService service)
        {
            _service = service;
        }

        /// <summary>
        /// 获取所有角色，根据角色名称和状态查询
        /// </summary>
        /// <returns>RoleDto列表</returns>
        [HttpGet]
        public ActionResult<ApiResult<IEnumerable<RoleDto>>> GetAllRoles([FromQuery]RoleResourceParameter parameter)
        {
            throw new NotImplementedException();
        }


        //private PageModel GetAllPageList(int startPage, int pageSize)
        //{
        //    int rowCount = 0;
        //    var result = _service.GetAllPageList(startPage, pageSize, out rowCount);
        //    return new PageModel
        //    {
        //        RowCount = rowCount,
        //        PageCount = (int) Math.Ceiling(Convert.ToDecimal(rowCount) / pageSize),
        //        Rows = result,
        //    };
        //}

        /// <summary>
        /// 根据主键获取角色
        /// </summary>
        /// <param name="roleId">Guid</param>
        /// <returns>RoleDto</returns>
        [HttpGet("{roleId}")]
        public ActionResult<ApiResult<RoleDto>> Get(Guid roleId)
        {
            var dto = _service.Get(roleId);
            return null;
        }

        

        /// <summary>
        /// 获取某个角色对应的菜单
        /// </summary>
        /// <param name="roleId">Guid</param>
        /// <returns>MenuDto列表</returns>
        [HttpGet("{roleId}/menus")]
        public ActionResult<ApiResult<IEnumerable<MenuDto>>> GetMenusByRole(Guid roleId)
        {
            var dtos = _service.GetAllMenuListByRole(roleId);
            return null;
        }

        /// <summary>
        /// 新增角色
        /// </summary>
        /// <param name="roleDto">RoleCreationDto</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<ApiStringResult> CreateRole(RoleCreationDto roleDto)
        {
            if (!ModelState.IsValid)
            {
                return new ApiStringResult
                {
                    Code=1,
                    Message = GetModelStateError()
                };
            }
            //if (roleDto.Id == Guid.Empty)
            //    roleDto.CreateTime = DateTime.Now;
            //dto.CreateUserId = 
            //if (_service.InsertOrUpdate(roleDto))
            {
                return new ApiStringResult { Code=0 };
            }
            return new ApiStringResult { Code=1 };
        }

        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="roleId">Guid</param>
        /// <param name="roleDto">RoleUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{roleId}")]
        public ActionResult<ApiStringResult> UpdateRole(Guid roleId,RoleUpdateDto roleDto)
        {
            if (!ModelState.IsValid)
            {
                return new ApiStringResult
                {
                    Code=1,
                    Message = GetModelStateError()
                };
            }
            //if (roleDto.Id == Guid.Empty)
            //    roleDto.CreateTime = DateTime.Now;
            //dto.CreateUserId = 
            //if (_service.InsertOrUpdate(roleDto))
            {
                return new ApiStringResult { Code=0 };
            }
            return new ApiStringResult { Code=1 };
        }

        /// <summary>
        /// 修改角色状态
        /// </summary>
        /// <param name="roleId">Guid</param>
        /// <param name="dto">RoleUpdateStatusDto</param>
        /// <returns></returns>
        [HttpPut("{roleId}/enable")]
        public ActionResult<ApiStringResult> EnableRole(Guid roleId,RoleUpdateStatusDto dto)
        {
            throw new NotImplementedException();
        }

        ///// <summary>
        ///// 根据主键删除角色
        ///// </summary>
        ///// <param name="roleId">Guid</param>
        ///// <returns></returns>
        //[HttpDelete("{roleId}")]
        //public WebApiResultModel DeleteRole(Guid roleId)
        //{
        //    try
        //    {
        //        _service.Delete(roleId);
        //        return new WebApiResultModel
        //        {
        //            Code=0
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        return new WebApiResultModel
        //        {
        //            Code=1,
        //            Message = ex.Message
        //        };
        //    }
        //}

        /// <summary>
        /// 批量删除角色
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        [HttpPut("deletemulti")]
        public ActionResult<ApiStringResult> DeleteRoles(List<Guid> ids)
        {
            try
            { 
                _service.DeleteBatch(ids);
                return new ApiStringResult
                {
                    Code=0
                };
            }
            catch (Exception ex)
            {
                return new ApiStringResult
                {
                    Code=1,
                    Message = ex.Message
                };
            }
        }
       
        private ApiStringResult SavePermission(Guid roleId, List<RoleMenuDto> roleMenus)
        {
            if (_service.UpdateRoleMenu(roleId, roleMenus))
            {
                return new ApiStringResult { Code=0 };
            }
            return new ApiStringResult { Code=1 };
        }
    }
}
