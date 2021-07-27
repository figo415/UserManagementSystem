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
    /// 质粒纯化
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/purifications")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    public class PlasmidPurificationController : ControllerBase
    {
        private readonly IPlasmidPurificationAppService _service;
        private readonly ILogger<PlasmidPurificationController> _logger;

        public PlasmidPurificationController(IPlasmidPurificationAppService service, ILogger<PlasmidPurificationController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取质粒纯化，可根据合同编号、合同类型、载体编号、质粒类型、状态或创建时间查询
        /// </summary>
        /// <param name="parameters">PlasmidPurificationQueryParameters</param>
        /// <returns>PlasmidPurificationDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<PlasmidPurificationApiResult>> GetPlasmidPurifications([FromQuery] PlasmidPurificationQueryParameters parameters)
        {
            _logger.LogInformation("Query string for PlasmidPurification: {0}", parameters);
            var pageddtos = await _service.GetPlasmidPurificationsByPage(parameters);
            return PlasmidPurificationApiResult.Succeed(pageddtos, pageddtos.TotalCount);
        }

        /// <summary>
        /// 完成质粒纯化
        /// </summary>
        /// <param name="plasmidPurificationId">Guid</param>
        /// <param name="updateDto">PlasmidPurificationUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{plasmidPurificationId}")]
        public async Task<ActionResult<StringApiResult>> UpdatePlasmidPurification(Guid plasmidPurificationId, PlasmidPurificationUpdateDto updateDto)
        {
            try
            {
                var result = await _service.UpdatePlasmidPurification(plasmidPurificationId, updateDto);
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
