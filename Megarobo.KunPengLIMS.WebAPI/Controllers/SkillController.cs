using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.Services;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.WebAPI.Models;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.WebAPI.Filters;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    /// <summary>
    /// 技能管理
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/skills")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    public class SkillController : ControllerBase
    {
        private readonly ISkillAppService _service;
        private readonly ILogger<SkillController> _logger;

        public SkillController(ISkillAppService service, ILogger<SkillController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取所有技能，可根据技能名称查询
        /// </summary>
        /// <param name="parameters">SkillQueryParameters</param>
        /// <returns>SkillDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<ApiResult<SkillDtoList>>> GetSkills([FromQuery]SkillQueryParameters parameters)
        {
            _logger.LogInformation("Query string for Skill: {0}", parameters);
            if(string.IsNullOrEmpty(parameters.SkillName))
            {
                var dtos = await _service.GetSkillTree(parameters);
                var dtolist = new SkillDtoList(dtos);
                return ApiResult<SkillDtoList>.HasData(dtolist, dtos.Count());
            }
            var pageddtos = await _service.GetSkillsByPage(parameters);
            var list = new SkillDtoList(pageddtos);
            return ApiResult<SkillDtoList>.HasData(list, pageddtos.Count());
        }

        /// <summary>
        /// 新增技能
        /// </summary>
        /// <param name="skillDto">SkillCreationDto</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<StringApiResult>> CreateSkill(SkillCreationDto skillDto)
        {
            try
            {
                var result = await _service.InsertSkill(skillDto);
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
        /// 修改技能
        /// </summary>
        /// <param name="skillId">Guid</param>
        /// <param name="skillDto">SkillUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{skillId}")]
        public async Task<ActionResult<StringApiResult>> UpdateSkill(Guid skillId,SkillUpdateDto skillDto)
        {
            try
            {
                var result = await _service.UpdateSkill(skillId, skillDto);
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
        /// 批量删除技能
        /// </summary>
        /// <param name="dto">DeleteMultiDto</param>
        /// <returns></returns>
        [HttpPut("deletemulti")]
        public async Task<ActionResult<StringApiResult>> DeleteSkills(DeleteMultiDto dto)
        {
            try
            {
                var result = await _service.DeleteSkills(dto);
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
