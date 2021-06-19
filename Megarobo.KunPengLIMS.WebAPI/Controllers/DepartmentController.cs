using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Megarobo.KunPengLIMS.Application.DepartmentApp;
using Megarobo.KunPengLIMS.WebAPI.Models;
using Megarobo.KunPengLIMS.Application.DepartmentApp.Dtos;
using Megarobo.KunPengLIMS.Application.UserApp.Dtos;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    /// <summary>
    /// 部门管理
    /// </summary>
    [Route("limsapi/departments")]
    [ApiController]
    public class DepartmentController : LimsControllerBase
    {
        private readonly IDepartmentAppService _service;

        public DepartmentController(IDepartmentAppService service)
        {
            _service = service;
        }

        /// <summary>
        /// 获取所有部门，可根据部门名称或者状态查询
        /// </summary>
        /// <returns>DepartmentDto列表</returns>
        [HttpGet]
        public ActionResult<ApiResult<IEnumerable<DepartmentDto>>> GetAllDepartments([FromQuery]DepartmentResourceParameter parameter)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 根据主键获取部门
        /// </summary>
        /// <param name="departmentId">Guid</param>
        /// <returns>DepartmentDto</returns>
        [HttpGet("{departmentId}")]
        public ActionResult<ApiResult<DepartmentDto>> GetDepartment(Guid departmentId)
        {
            var dto = _service.Get(departmentId);
            return null;
        }

        ///// <summary>
        ///// 获取部门树形结构
        ///// </summary>
        ///// <returns></returns>
        //[HttpGet("Tree")]
        //public List<TreeModel> GetTreeData()
        //{
        //    var dtos = _service.GetAllList();
        //    List<TreeModel> treeModels = new List<TreeModel>();
        //    foreach (var dto in dtos)
        //    {
        //        treeModels.Add(new TreeModel() { Id = dto.Id.ToString(), Text = dto.Name, Parent = dto.ParentId == Guid.Empty ? "#" : dto.ParentId.ToString() });
        //    }
        //    return treeModels;
        //}

        /// <summary>
        /// 获取某个部门下的用户
        /// </summary>
        /// <param name="departmentId">Guid</param>
        /// <returns></returns>
        [HttpGet("{departmentId}/users")]
        public ActionResult<ApiResult<IEnumerable<UserDto>>> GetUsersByDepartment(Guid departmentId)
        {
            throw new NotImplementedException();
            //int rowCount = 0;
            //var result = new object();// _service.GetUserByDepartment(departmentId, startPage, pageSize, out rowCount);
            ////var roles = _roleService.GetAllList();
            //return new PageModel
            //{
            //    RowCount = rowCount,
            //    PageCount = (int) Math.Ceiling(Convert.ToDecimal(rowCount) / pageSize),
            //    Rows = result,
            //    //roles = roles
            //};
        }

        ///// <summary>
        ///// 获取某个部门的下级部门
        ///// </summary>
        ///// <param name="departmentId">Guid</param>
        ///// <param name="startPage"></param>
        ///// <param name="pageSize"></param>
        ///// <returns></returns>
        //[HttpGet("{departmentId}/children")]
        //public PageModel GetDepartmentsByParent(Guid departmentId, int startPage, int pageSize)// 获取子级列表
        //{
        //    int rowCount = 0;
        //    var result = _service.GetChildrenByParent(departmentId, startPage, pageSize, out rowCount);
        //    return new PageModel
        //    {
        //        RowCount = rowCount,
        //        PageCount = (int)Math.Ceiling(Convert.ToDecimal(rowCount) / pageSize),
        //        Rows = result
        //    };
        //}

        /// <summary>
        /// 新增部门
        /// </summary>
        /// <param name="departmentDto">DepartmentCreationDto</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<ApiStringResult> CreateDepartment(DepartmentCreationDto departmentDto)
        {
            if (!ModelState.IsValid)
            {
                return new ApiStringResult
                {
                    Code = 1,
                    Message = GetModelStateError()
                };
            }
            //if (_service.InsertOrUpdate(departmentDto))
            {
                return new ApiStringResult { Code=0,Message = "Success" };
            }
            return new ApiStringResult { Code=1,Message = "Faild" };
        }

        /// <summary>
        /// 修改部门
        /// </summary>
        /// <param name="departmentId">Guid</param>
        /// <param name="departmentDto">DepartmentUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{departmentId}")]
        public ActionResult<ApiStringResult> UpdateDepartment(Guid departmentId,DepartmentUpdateDto departmentDto)
        {
            if (!ModelState.IsValid)
            {
                return new ApiStringResult
                {
                    Code=1,
                    Message = GetModelStateError()
                };
            }
            //if (_service.InsertOrUpdate(departmentDto))
            {
                return new ApiStringResult { Code=0 };
            }
            return new ApiStringResult { Code=1 };
        }

        ///// <summary>
        ///// 根据主键删除部门
        ///// </summary>
        ///// <param name="departmentId">Guid</param>
        ///// <returns></returns>
        //[HttpDelete("{departmentId}")]
        //public WebApiResultModel DeleteDepartment(Guid departmentId)
        //{
        //    try
        //    {
        //        _service.Delete(departmentId);
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
        /// 批量删除部门
        /// </summary>
        /// <param name="ids">Guid列表</param>
        /// <returns></returns>
        [HttpPut("deletemulti")]
        public ActionResult<ApiStringResult> DeleteDepartments(List<Guid> ids)
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
    }
}
