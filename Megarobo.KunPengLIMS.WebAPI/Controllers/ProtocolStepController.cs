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
    /// ProtocolStep管理
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/protocolsteps")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    public class ProtocolStepController : ControllerBase
    {
        private readonly IProtocolStepAppService _service;
        private readonly ILogger<ProtocolStepController> _logger;

        public ProtocolStepController(IProtocolStepAppService service, ILogger<ProtocolStepController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取ProtocolStep，可根据描述或Note查询
        /// </summary>
        /// <param name="parameters">ProtocolStepQueryParameters</param>
        /// <returns>ProtocolStepDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<ProtocolStepApiResult>> GetProtocolSteps([FromQuery] ProtocolStepQueryParameters parameters)
        {
            _logger.LogInformation("Query string for ProtocolStep: {0}", parameters);
            var dtos = await _service.GetProtocolStepTree(parameters);
            return ProtocolStepApiResult.Succeed(dtos, dtos.Count());
        }

        /// <summary>
        /// 添加ProtocolStep
        /// </summary>
        /// <param name="creationDto">CellCreationDto</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<StringApiResult>> CreateProtocolStep(ProtocolStepCreationDto creationDto)
        {
            try
            {
                var result = await _service.InsertProtocolStep(creationDto);
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
        /// 修改ProcotolStep
        /// </summary>
        /// <param name="protocolStepId">Guid</param>
        /// <param name="updateDto">ProtocolStepUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{protocolStepId}")]
        public async Task<ActionResult<StringApiResult>> UpdateProtocolStep(Guid protocolStepId, ProtocolStepUpdateDto updateDto)
        {
            try
            {
                var result = await _service.UpdateProtocolStep(protocolStepId, updateDto);
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
        /// 批量删除ProtocolStep
        /// </summary>
        /// <param name="dto">DeleteMultiDto</param>
        /// <returns></returns>
        [HttpPut("deletemulti")]
        public async Task<ActionResult<StringApiResult>> DeleteProtocolStep(DeleteMultiDto dto)
        {
            try
            {
                var result = await _service.DeleteProtocolSteps(dto);
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
