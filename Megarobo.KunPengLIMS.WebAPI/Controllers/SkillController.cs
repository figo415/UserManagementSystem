using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.SkillApp.Dtos;
using Megarobo.KunPengLIMS.WebAPI.Models;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    /// <summary>
    /// 技能管理
    /// </summary>
    [Route("limsapi/skills")]
    [ApiController]
    public class SkillController : LimsControllerBase
    {
        /// <summary>
        /// 获取所有技能，可根据技能名称查询
        /// </summary>
        /// <returns>SkillDto列表</returns>
        [HttpGet]
        public ActionResult<ApiResult<IEnumerable<SkillDto>>> GetAllSkills([FromQuery]SkillResourceParameter parameter)
        {
            throw new NotImplementedException();
        }

        ///// <summary>
        ///// 根据主键获取技能
        ///// </summary>
        ///// <param name="skillId">Guid</param>
        ///// <returns></returns>
        //[HttpGet("{skillId}")]
        //public SkillDto GetSkill(Guid skillId)
        //{
        //    throw new NotImplementedException();
        //}

        /// <summary>
        /// 获取某个技能的下级技能
        /// </summary>
        /// <param name="skillId">Guid</param>
        /// <returns></returns>
        [HttpGet("{skillId}/children")]
        public ActionResult<ApiResult<IEnumerable<SkillDto>>> GetSkillsByParent(Guid skillId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 新增技能
        /// </summary>
        /// <param name="skillDto">SkillCreationDto</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<ApiStringResult> CreateSkill(SkillCreationDto skillDto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 修改技能
        /// </summary>
        /// <param name="skillId">Guid</param>
        /// <param name="skillDto">SkillUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{skillId}")]
        public ActionResult<ApiStringResult> UpdateSkill(Guid skillId,SkillUpdateDto skillDto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 批量删除技能
        /// </summary>
        /// <param name="ids">Guid列表</param>
        /// <returns></returns>
        [HttpPut("deletemulti")]
        public ActionResult<ApiStringResult> DeleteSkills(List<Guid> ids)
        {
            throw new NotImplementedException();
        }

        ///// <summary>
        ///// 根据主键删除技能
        ///// </summary>
        ///// <param name="skillId">Guid</param>
        ///// <returns></returns>
        //[HttpDelete("{skillId}")]
        //public IActionResult DeleteSkill(Guid skillId)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
