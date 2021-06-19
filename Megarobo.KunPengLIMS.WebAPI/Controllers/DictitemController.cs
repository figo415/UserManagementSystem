using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.DictItemApp.Dtos;
using Megarobo.KunPengLIMS.WebAPI.Models;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    /// <summary>
    /// 字典项管理
    /// </summary>
    [Route("limsapi/dictitems")]
    [ApiController]
    public class DictitemController : LimsControllerBase
    {
        /// <summary>
        /// 获取所有字典项，可根据字典名称或者字典类型查询
        /// </summary>
        /// <returns>DictItemDto列表</returns>
        [HttpGet]
        public ActionResult<ApiResult<IEnumerable<DictItemDto>>> GetAllDictItems([FromQuery] DictItemResourceParameter parameter)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 根据主键获取字典项
        /// </summary>
        /// <param name="dictItemId">Guid</param>
        /// <returns>DictItemDto</returns>
        [HttpGet("{dictItemId}")]
        public ActionResult<ApiResult<DictItemDto>> GetDictItem(Guid dictItemId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 新增字典项
        /// </summary>
        /// <param name="dictItemDto">DictItemCreationDto</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<ApiStringResult> CreateDictItem(DictItemCreationDto dictItemDto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 修改字典项
        /// </summary>
        /// <param name="dictItemId">Guid</param>
        /// <param name="dictItemDto">DictItemUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{dictItemId}")]
        public ActionResult<ApiStringResult> UpdateDictItem(Guid dictItemId,DictItemUpdateDto dictItemDto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 维护字典项的值，包括添加、修改、删除
        /// </summary>
        /// <param name="dictItemId">Guid</param>
        /// <param name="dto">DictItemUpdateValueDto</param>
        /// <returns></returns>
        [HttpPut("{dictItemId}/values")]
        public ActionResult<ApiStringResult> MaintainValuesForDictItem(Guid dictItemId,DictItemUpdateValueDto dto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 批量删除字典项
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        [HttpPut("deletemulti")]
        public ActionResult<ApiStringResult> DeleteDictItems(List<Guid> ids)
        {
            throw new NotImplementedException();
        }
    }
}
