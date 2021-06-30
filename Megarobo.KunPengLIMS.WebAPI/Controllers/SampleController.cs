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
    /// 样本管理
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/samples")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    public class SampleController : ControllerBase
    {
        private readonly ISampleAppService _service;
        private readonly ILogger<SampleController> _logger;

        public SampleController(ISampleAppService service, ILogger<SampleController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取样本，可根据样本名称、任务名称、状态查询
        /// </summary>
        /// <param name="parameters">SpeciesQueryParameters</param>
        /// <returns>SampleDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<ApiResult<SampleDtoList>>> GetSamples([FromQuery]SampleQueryParameters parameters)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 添加样本
        /// </summary>
        /// <param name="creationDto">SampleCreationDto</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<ApiStringResult>> CreateSample(SampleCreationDto creationDto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 修改样本
        /// </summary>
        /// <param name="sampleId">Guid</param>
        /// <param name="updateDto">SampleUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{sampleId}")]
        public async Task<ActionResult<ApiStringResult>> UpdateSpecies(Guid sampleId, SampleUpdateDto updateDto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 批量删除样本
        /// </summary>
        /// <param name="dto">DeleteMultiDto</param>
        /// <returns></returns>
        [HttpPut("deletemulti")]
        public async Task<ActionResult<ApiStringResult>> DeleteSample(DeleteMultiDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
