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
    /// 分子克隆
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/clonings")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    public class MolecularCloningController : ControllerBase
    {
        private readonly IMolecularCloningAppService _service;
        private readonly ILogger<MolecularCloningController> _logger;

        public MolecularCloningController(IMolecularCloningAppService service, ILogger<MolecularCloningController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取分子克隆，可根据合同编号、合同类型、载体编号、状态或创建时间查询
        /// </summary>
        /// <param name="parameters">MolecularCloningQueryParameters</param>
        /// <returns>MolecularCloningDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<MolecularCloningApiResult>> GetMolecularClonings([FromQuery] MolecularCloningQueryParameters parameters)
        {
            _logger.LogInformation("Query string for MolecularCloning: {0}", parameters);
            var pageddtos = await _service.GetMolecularCloningsByPage(parameters);
            return MolecularCloningApiResult.Succeed(pageddtos, pageddtos.TotalCount);
        }

        /// <summary>
        /// 完成分子克隆
        /// </summary>
        /// <param name="molecularId">Guid</param>
        /// <param name="updateDto">MolecularCloningUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{molecularId}")]
        public async Task<ActionResult<StringApiResult>> UpdateMolecularCloning(Guid molecularId, MolecularCloningUpdateDto updateDto)
        {
            try
            {
                var result = await _service.UpdateMolecularCloning(molecularId, updateDto);
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
