using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Megarobo.KunPengLIMS.Application.UserApp;
using Megarobo.KunPengLIMS.Application.SkillApp.Dtos;
using Megarobo.KunPengLIMS.Application.UserApp.Dtos;
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
        /// 获取所有用户，可根据用户名称、手机号码、部门名称、技能名称、状态或者创建时间查询
        /// </summary>
        /// <returns>UserDto列表</returns>
        [HttpGet]
        public ActionResult<ApiResult<IEnumerable<UserDto>>> GetAllUsers([FromQuery]UserResourceParameter parameter)
        {
            var result = new ApiResult<IEnumerable<UserDto>>();
            var users = _service.GetAllUsers().Skip(parameter.PageSize * (parameter.PageNumber - 1)).Take(parameter.PageSize);
            result.Data = users;
            return null; ;
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
            var result = new ApiResult<UserDto>();
            result.Code = 0;
            result.Message = string.Empty;
            result.Data = userdto;
            return null;
        }

        /// <summary>
        /// 获取用户的技能列表
        /// </summary>
        /// <param name="userId">Guid</param>
        /// <returns>SkillDto列表</returns>
        [HttpGet("{userId}/skills")]
        public ActionResult<ApiResult<IEnumerable<SkillDto>>> GetSkillsForUser(Guid userId)
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
        public ActionResult<ApiResult<IEnumerable<UserDepartmentRoleDto>>> GetDepartmentRolesForUser(Guid userId)
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
        public ActionResult<ApiStringResult> CreateUser(UserCreationDto userDto)
        {
            try
            {
                //if (userDto.Id == Guid.Empty)
                //{
                //    userDto.Id = Guid.NewGuid();
                //}
                //var userRoles = new List<UserRoleDto>();
                //foreach (var role in roles.Split(','))
                //{
                //    userRoles.Add(new UserRoleDto() { UserId = dto.Id, RoleId = Guid.Parse(role) });
                //}
                //userDto.UserRoles = userRoles;
                //var user = _service.InsertOrUpdate(userDto);
                return new ApiStringResult { Code=0, Message = "Success" };
            }
            catch (Exception ex)
            {
                return new ApiStringResult {  Code= 1, Message = ex.Message };
            }
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="userId">Guid</param>
        /// <param name="userDto">UserUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{userId}")]
        public ActionResult<ApiStringResult> UpdateUser(Guid userId,UserUpdateDto userDto)
        {
            try
            {
                //if (userDto.Id == Guid.Empty)
                //{
                //    userDto.Id = Guid.NewGuid();
                //}
                //var userRoles = new List<UserRoleDto>();
                //foreach (var role in roles.Split(','))
                //{
                //    userRoles.Add(new UserRoleDto() { UserId = dto.Id, RoleId = Guid.Parse(role) });
                //}
                //userDto.UserRoles = userRoles;
                //var user = _service.InsertOrUpdate(userDto);
                return new ApiStringResult { Code=0, Message = "Success" };
            }
            catch (Exception ex)
            {
                return new ApiStringResult { Code = 1, Message = ex.Message };
            }
        }

        /// <summary>
        /// 修改用户状态
        /// </summary>
        /// <param name="userId">Guid</param>
        /// <param name="dto">UserUpdateStatusDto</param>
        /// <returns></returns>
        [HttpPut("{userId}/enable")]
        public ActionResult<ApiStringResult> UpdateUserStatus(Guid userId,UserUpdateStatusDto dto)
        {
            return new ApiStringResult { Code = 0, Message = "Success" };
        }

        /// <summary>
        /// 重置密码
        /// </summary>
        /// <param name="userId">Guid</param>
        /// <param name="dto">UserUpdatePasswordDto</param>
        /// <returns></returns>
        [HttpPut("{userId}/password")]
        public ActionResult<ApiStringResult> ResetPassword(Guid userId,UserUpdatePasswordDto dto)
        {
            return new ApiStringResult { Code = 0, Message = "Success" };
        }

        ///// <summary>
        ///// 根据Guid删除用户
        ///// </summary>
        ///// <param name="userId">Guid</param>
        ///// <returns></returns>
        //[HttpDelete("{userId}")]
        //public WebApiResultModel DeleteUser(Guid userId)
        //{
        //    try
        //    {
        //        _service.Delete(userId);
        //        return new WebApiResultModel
        //        {
        //            Code=0,
        //            Message = "Success"
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        return new WebApiResultModel
        //        {
        //            Code = 1,
        //            Message = ex.Message
        //        };
        //    }
        //}

        /// <summary>
        /// 批量删除用户
        /// </summary>
        /// <param name="ids">Guid列表</param>
        /// <returns></returns>
        [HttpPut("deletemulti")]
        public ActionResult<ApiStringResult> DeleteUsers(List<Guid> ids)
        {
            try
            {
                _service.DeleteBatch(ids);
                return new ApiStringResult
                {
                    Code = 0,
                    Message = "Success"
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
    }
}
