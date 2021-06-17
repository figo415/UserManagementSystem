using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Megarobo.KunPengLIMS.Application.MenuApp.Dtos;
using Megarobo.KunPengLIMS.Application.MenuApp;
using Megarobo.KunPengLIMS.WebAPI.Models;
using Microsoft.AspNetCore.Http;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    /// <summary>
    /// 菜单管理
    /// </summary>
    [Route("api/menus")]
    [ApiController]
    public class MenuController : LimsControllerBase
    {
        private readonly IMenuAppService _menuAppService;

        public MenuController(IMenuAppService menuAppService, Application.UserApp.IUserAppService userAppService)
        {
            _menuAppService = menuAppService;
        }

        /// <summary>
        /// 获取所有菜单，可根据菜单名称、状态和类型查询
        /// </summary>
        /// <returns>MenuDto列表</returns>
        [HttpGet]
        public ActionResult<ApiResult<IEnumerable<MenuDto>>> GetAllMenus([FromQuery] MenuResourceParameter parameter)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 根据主键获取菜单
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns>MenuDto</returns>
        [HttpGet("{menuId}")]
        public ActionResult<ApiResult<MenuDto>> GetMenu(Guid menuId)
        {
            var dto = _menuAppService.Get(menuId);
            return null;
        }

        ///// <summary>
        ///// 获取菜单树形结构
        ///// </summary>
        ///// <returns></returns>
        //[HttpGet("tree")]
        //public List<TreeModel> GetMenuTreeData()// 获取功能树JSON数据
        //{
        //    var menus = _menuAppService.GetAllList();
        //    List<TreeModel> treeModels = new List<TreeModel>();
        //    foreach (var menu in menus)
        //    {
        //        treeModels.Add(new TreeModel() { Id = menu.Id.ToString(), Text = menu.Name, Parent = menu.ParentId == Guid.Empty ? "#" : menu.ParentId.ToString() });
        //    }
        //    return treeModels;
        //}

        ///// <summary>
        ///// 获取某个菜单的下级菜单
        ///// </summary>
        ///// <param name="menuId">Guid</param>
        ///// <returns></returns>
        //[HttpGet("{menuId}/children")]
        //public PageModel GetMneusByParent(Guid menuId)// 获取子级功能列表
        //{
        //    throw new NotImplementedException();
        //    //int rowCount = 0;
        //    //var result = _menuAppService.GetMenusByParent(menuId, startPage, pageSize, out rowCount);
        //    //return new PageModel
        //    //{
        //    //    RowCount = rowCount,
        //    //    PageCount = (int) Math.Ceiling(Convert.ToDecimal(rowCount) / pageSize),
        //    //    Rows = result,
        //    //};
        //}

        /// <summary>
        /// 新增菜单
        /// </summary>
        /// <param name="menuDto">MenuCreationDto</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<ApiStringResult> CreateMenu(MenuCreationDto menuDto)
        {
            if (!ModelState.IsValid)
            {
                return new ApiStringResult
                {
                    Code=1,
                    Message = GetModelStateError()
                };
            }
            //if (_menuAppService.InsertOrUpdate(menuDto))
            {
                return new ApiStringResult { Code=0 };
            }
            return new ApiStringResult { Code=1 };
        }

        /// <summary>
        /// 修改菜单
        /// </summary>
        /// <param name="menuId">Guid</param>
        /// <param name="menuDto">MenuUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{menuId}")]
        public ActionResult<ApiStringResult> UpdateMenu(Guid menuId,MenuUpdateDto menuDto)
        {
            if (!ModelState.IsValid)
            {
                return new ApiStringResult
                {
                    Code=1,
                    Message = GetModelStateError()
                };
            }
            //if (_menuAppService.InsertOrUpdate(menuDto))
            {
                return new ApiStringResult { Code=0 };
            }
            return new ApiStringResult { Code=1 };
        }

        /// <summary>
        /// 修改菜单状态
        /// </summary>
        /// <param name="menuId">Guid</param>
        /// <param name="dto">MenuUpdateStatusDto</param>
        /// <returns></returns>
        [HttpPut("{menuId}/enable")]
        public ActionResult<ApiStringResult> EnableMenu(Guid menuId,MenuUpdateStatusDto dto)
        {
            throw new NotImplementedException();
        }

        ///// <summary>
        ///// 根据主键删除菜单
        ///// </summary>
        ///// <param name="menuId">Guid</param>
        ///// <returns></returns>
        //[HttpDelete("{menuId}")]
        //public WebApiResultModel DeleteMenu(Guid menuId)
        //{
        //    try
        //    {
        //        _menuAppService.Delete(menuId);
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
        /// 批量删除菜单
        /// </summary>
        /// <param name="ids">Guid列表</param>
        /// <returns></returns>
        [HttpPut("deletemulti")]
        public ActionResult<ApiStringResult> DeleteMenus(List<Guid> ids)
        {
            try
            {
                _menuAppService.DeleteBatch(ids);
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
