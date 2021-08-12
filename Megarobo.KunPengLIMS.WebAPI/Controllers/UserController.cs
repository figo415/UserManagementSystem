using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Megarobo.KunPengLIMS.Application.Services;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.WebAPI.Models;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.WebAPI.Filters;
using Microsoft.AspNetCore.Authorization;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    /// <summary>
    /// 用户管理
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/users")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    [AllowAnonymous]
    public class UserController : ControllerBase
    {
        private readonly IUserAppService _service;
        private readonly ILogger<UserController> _logger;

        public UserController(IUserAppService service,ILogger<UserController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取所有用户，可根据用户名称、手机号码、状态或者创建时间查询
        /// </summary>
        /// <param name="parameters">UserQueryParameters</param>
        /// <returns>UserDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<UserApiResult>> GetUsers([FromQuery]UserQueryParameters parameters)
        {
            _logger.LogInformation("Query string for User: {0}", parameters);
            var pageddtos = await _service.GetUsersByPage(parameters);
            return UserApiResult.Succeed(pageddtos, pageddtos.TotalCount);
        }

        ///// <summary>
        ///// 根据主键获取用户
        ///// </summary>
        ///// <param name="userId">Guid</param>
        ///// <returns>UserDto</returns>
        //[HttpGet("{userId}")]
        //public async Task<ActionResult<ApiResult<UserDto>>> GetUser(Guid userId)
        //{
        //    var userdto = await _service.GetUser(userId);
        //    return ApiResult<UserDto>.HasData(userdto, 1);
        //}

        [HttpGet("info")]
        public async Task<ActionResult<ApiResult<UserWithRightsDto>>> GetUserByToken()
        {
            var username = User.Claims.First(t => t.Type == System.Security.Claims.ClaimTypes.Name).Value;
            var result = await _service.GetUserByToken(username);
            return ApiResult<UserWithRightsDto>.HasSingleData(result);
        }

        /// <summary>
        /// 获取用户的技能列表
        /// </summary>
        /// <param name="userId">Guid</param>
        /// <returns>SkillDto列表</returns>
        [HttpGet("{userId}/skills")]
        public async Task<ActionResult<SkillApiResult>> GetSkillsForUser(Guid userId)
        {
            var dtos = await _service.GetSkillsForUser(userId);
            return SkillApiResult.Succeed(dtos, dtos.Count());
        }

        /// <summary>
        ///获取用户的部门角色列表
        /// </summary>
        /// <param name="userId">Guid</param>
        /// <returns>UserDepartmentRoleDto列表</returns>
        [HttpGet("{userId}/departmentroles")]
        public async Task<ActionResult<UserDepartmentRoleApiResult>> GetDepartmentRolesForUser(Guid userId)
        {
            var dtos = await _service.GetDepartmentRolesForUser(userId);
            return UserDepartmentRoleApiResult.Succeed(dtos, dtos.Count());
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <remarks></remarks>
        /// <param name="userDto">UserCreationDto</param>
        /// <returns></returns>
        // <response code="201">Returns the newly created item</response>
        // <response code="400">If the item is null</response> 
        [HttpPost]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<StringApiResult>> CreateUser(UserCreationDto userDto)
        {
            try
            {
                var result = await _service.InsertUser(userDto);
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
        /// 修改用户
        /// </summary>
        /// <param name="userId">Guid</param>
        /// <param name="userDto">UserUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{userId}")]
        public async Task<ActionResult<StringApiResult>> UpdateUser(Guid userId,UserUpdateDto userDto)
        {
            try
            {
                var result = await _service.UpdateUser(userId, userDto);
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
        /// 修改用户状态
        /// </summary>
        /// <param name="userId">Guid</param>
        /// <param name="dto">UserUpdateStatusDto</param>
        /// <returns></returns>
        [HttpPut("{userId}/enable")]
        public async Task<ActionResult<StringApiResult>> EnableUser(Guid userId,UserUpdateStatusDto dto)
        {
            try
            {
                var result = await _service.EnableUser(userId, dto);
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
        /// 重置密码
        /// </summary>
        /// <param name="userId">Guid</param>
        /// <param name="dto">UserUpdatePasswordDto</param>
        /// <returns></returns>
        [HttpPut("{userId}/password")]
        public async Task<ActionResult<StringApiResult>> ResetPassword(Guid userId,UserUpdatePasswordDto dto)
        {
            try
            {
                var result = await _service.ResetPassword(userId, dto);
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
        /// 批量删除用户
        /// </summary>
        /// <param name="dto">DeleteMultiDto</param>
        /// <returns></returns>
        [HttpPut("deletemulti")]
        public async Task<ActionResult<StringApiResult>> DeleteUsers(DeleteMultiDto dto)
        {
            try
            {
                var result = await _service.DeleteUsers(dto);
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
