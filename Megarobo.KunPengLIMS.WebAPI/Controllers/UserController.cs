using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Megarobo.KunPengLIMS.Application.UserApp;
using Megarobo.KunPengLIMS.Application.SkillApp.Dtos;
using Megarobo.KunPengLIMS.Application.UserApp.Dtos;
using Megarobo.KunPengLIMS.Application;
using Megarobo.KunPengLIMS.WebAPI.Models;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    /// <summary>
    /// 用户管理
    /// </summary>
    [Route("api/users")]
    [ApiController]
    public class UserController : LimsControllerBase
    {
        private readonly IUserAppService _service;

        public UserController(IUserAppService service)
        {
            _service = service;
        }

        /// <summary>
        /// 获取所有用户，可根据用户名称、手机号码、状态或者创建时间查询
        /// </summary>
        /// <returns>UserDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<ApiResult<UserDtoList>>> GetUsers([FromQuery]UserResourceParameter parameter)
        {
            var users = await _service.GetUsers(parameter);
            var pagedUsers = users.Skip(parameter.PageSize * (parameter.PageNumber - 1)).Take(parameter.PageSize).ToList();
            return ApiResult<UserDtoList>.HasData(null);
        }

        /// <summary>
        /// 根据主键获取用户
        /// </summary>
        /// <param name="userId">Guid</param>
        /// <returns>UserDto</returns>
        [HttpGet("{userId}")]
        public async Task<ActionResult<ApiResult<UserDto>>> GetUser(Guid userId)
        {
            var userdto = await _service.GetUser(userId);
            return ApiResult<UserDto>.HasData(userdto);
        }

        /// <summary>
        /// 获取用户的技能列表
        /// </summary>
        /// <param name="userId">Guid</param>
        /// <returns>SkillDto列表</returns>
        [HttpGet("{userId}/skills")]
        public ActionResult<ApiResult<SkillDtoList>> GetSkillsForUser(Guid userId)
        {
            var result = new ApiResult<IEnumerable<SkillDto>>();
            result.Data = new List<SkillDto>();
            return null;
        }

        /// <summary>
        ///获取用户的部门角色列表
        /// </summary>
        /// <param name="userId">Guid</param>
        /// <returns>UserDepartmentRoleDto列表</returns>
        [HttpGet("{userId}/departmentroles")]
        public ActionResult<ApiResult<UserDepartmentRoleDtoList>> GetDepartmentRolesForUser(Guid userId)
        {
            var result = new ApiResult<IEnumerable<UserDepartmentRoleDto>>();
            result.Data = new List<UserDepartmentRoleDto>();
            return null;
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="userDto">UserCreationDto</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<ApiStringResult>> CreateUser(UserCreationDto userDto)
        {
            try
            {
                var result = await _service.InsertUser(userDto);
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
        /// 修改用户
        /// </summary>
        /// <param name="userId">Guid</param>
        /// <param name="userDto">UserUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{userId}")]
        public async Task<ActionResult<ApiStringResult>> UpdateUser(Guid userId,UserUpdateDto userDto)
        {
            try
            {
                var result = await _service.UpdateUser(userId, userDto);
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
        /// 修改用户状态
        /// </summary>
        /// <param name="userId">Guid</param>
        /// <param name="dto">UserUpdateStatusDto</param>
        /// <returns></returns>
        [HttpPut("{userId}/enable")]
        public async Task<ActionResult<ApiStringResult>> EnableUser(Guid userId,UserUpdateStatusDto dto)
        {
            try
            {
                var result = await _service.EnableUser(userId, dto);
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
        /// 重置密码
        /// </summary>
        /// <param name="userId">Guid</param>
        /// <param name="dto">UserUpdatePasswordDto</param>
        /// <returns></returns>
        [HttpPut("{userId}/password")]
        public async Task<ActionResult<ApiStringResult>> ResetPassword(Guid userId,UserUpdatePasswordDto dto)
        {
            try
            {
                var result = await _service.ResetPassword(userId, dto);
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
        /// 批量删除用户
        /// </summary>
        /// <param name="dto">DeleteMultiDto</param>
        /// <returns></returns>
        [HttpPut("deletemulti")]
        public async Task<ActionResult<ApiStringResult>> DeleteUsers(DeleteMultiDto dto)
        {
            try
            {
                var result = await _service.DeleteUsers(dto);
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
