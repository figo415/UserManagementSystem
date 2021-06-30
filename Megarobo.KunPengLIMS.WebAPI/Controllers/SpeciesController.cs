using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Megarobo.KunPengLIMS.Application.Services;
using Megarobo.KunPengLIMS.Application.Dtos;
using Megarobo.KunPengLIMS.WebAPI.Models;
using Megarobo.KunPengLIMS.Domain.QueryParameters;
using Megarobo.KunPengLIMS.WebAPI.Filters;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    /// <summary>
    /// 物种管理
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/species")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    public class SpeciesController : ControllerBase
    {
        private readonly ISpeciesAppService _service;
        private readonly ILogger<SpeciesController> _logger;

        public SpeciesController(ISpeciesAppService service, ILogger<SpeciesController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取物种，可根据中文、英文、拉丁文或创建时间查询
        /// </summary>
        /// <param name="parameters">SpeciesQueryParameters</param>
        /// <returns>SpeciesDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<ApiResult<SpeciesDtoList>>> GetSpecies([FromQuery] SpeciesQueryParameters parameters)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 添加物种
        /// </summary>
        /// <param name="creationDto">SpeciesCreationDto</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<ApiStringResult>> CreateSpecies(SpeciesCreationDto creationDto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 修改物种
        /// </summary>
        /// <param name="speciesId">Guid</param>
        /// <param name="updateDto">SpeciesUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{speciesId}")]
        public async Task<ActionResult<ApiStringResult>> UpdateSpecies(Guid speciesId, SpeciesUpdateDto updateDto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 批量删除物种
        /// </summary>
        /// <param name="dto">DeleteMultiDto</param>
        /// <returns></returns>
        [HttpPut("deletemulti")]
        public async Task<ActionResult<ApiStringResult>> DeleteSpecies(DeleteMultiDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
