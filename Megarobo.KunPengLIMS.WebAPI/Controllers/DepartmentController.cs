using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Megarobo.KunPengLIMS.Application.DepartmentApp;
using Megarobo.KunPengLIMS.WebAPI.Models;
using Megarobo.KunPengLIMS.Application.DepartmentApp.Dtos;
using Megarobo.KunPengLIMS.Application.UserApp.Dtos;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.Application;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    /// <summary>
    /// 部门管理
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/departments")]
    [ApiController]
    public class DepartmentController : LimsControllerBase
    {
        private readonly IDepartmentAppService _service;
        private readonly ILogger<DepartmentController> _logger;

        public DepartmentController(IDepartmentAppService service, ILogger<DepartmentController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取所有部门，可根据部门名称或者状态查询
        /// </summary>
        /// <param name="parameters">DepartmentQueryParameters</param>
        /// <returns>DepartmentDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<ApiResult<DepartmentDtoList>>> GetDepartments([FromQuery] DepartmentQueryParameters parameters)
        {
            _logger.LogInformation("Query string for Department: Name={0}", parameters.Name);
            //var pageddtos = await _service.GetDepartmentsByPage(parameters);
            var pageddtos = await _service.GetDepartmentTree(parameters);
            var list = new DepartmentDtoList(pageddtos);
            return ApiResult<DepartmentDtoList>.HasData(list, pageddtos.Count());
        }

        /// <summary>
        /// 根据主键获取部门
        /// </summary>
        /// <param name="departmentId">Guid</param>
        /// <returns>DepartmentDto</returns>
        [HttpGet("{departmentId}")]
        public async Task<ActionResult<ApiResult<DepartmentDto>>> GetDepartment(Guid departmentId)
        {
            var departmentdto = await _service.GetDepartment(departmentId);
            return ApiResult<DepartmentDto>.HasData(departmentdto, 0);
        }

        /// <summary>
        /// 获取某个部门下的用户
        /// </summary>
        /// <param name="departmentId">Guid</param>
        /// <returns>UserDto列表</returns>
        [HttpGet("{departmentId}/users")]
        public async Task<ActionResult<ApiResult<UserDtoList>>> GetUsersByDepartment(Guid departmentId,[FromQuery]PagedParameters parameters)
        {
            var pageddtos = await _service.GetUsersByDepartment(departmentId, parameters);
            var list = new UserDtoList(pageddtos);
            return ApiResult<UserDtoList>.HasData(list, pageddtos.TotalCount);
        }

        /// <summary>
        /// 新增部门
        /// </summary>
        /// <param name="departmentDto">DepartmentCreationDto</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<ApiStringResult>> CreateDepartment(DepartmentCreationDto departmentDto)
        {
            try
            {
                var result = await _service.InsertDepartment(departmentDto);
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
        /// 修改部门
        /// </summary>
        /// <param name="departmentId">Guid</param>
        /// <param name="departmentDto">DepartmentUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{departmentId}")]
        public async Task<ActionResult<ApiStringResult>> UpdateDepartment(Guid departmentId,DepartmentUpdateDto departmentDto)
        {
            try
            {
                var result = await _service.UpdateDepartment(departmentId, departmentDto);
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
        /// 修改部门状态
        /// </summary>
        /// <param name="departmentId">Guid</param>
        /// <param name="dto">DepartmentUpdateStatusDto</param>
        /// <returns></returns>
        [HttpPut("{departmentId}/enable")]
        public async Task<ActionResult<ApiStringResult>> EnableDepartment(Guid departmentId, DepartmentUpdateStatusDto dto)
        {
            try
            {
                var result = await _service.EnableDepartment(departmentId, dto);
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
        /// 批量删除部门
        /// </summary>
        /// <param name="ids">Guid列表</param>
        /// <returns></returns>
        [HttpPut("deletemulti")]
        public async Task<ActionResult<ApiStringResult>> DeleteDepartments(DeleteMultiDto dto)
        {
            try
            {
                var result = await _service.DeleteDepartments(dto);
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
