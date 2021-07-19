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
    /// 流程管理
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/nodes")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    public class ProcessController : ControllerBase
    {
        private readonly IProcessAppService _service;
        private readonly ILogger<ProcessController> _logger;

        public ProcessController(IProcessAppService service, ILogger<ProcessController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取流程，可根据流程名称、流程类型或创建时间查询
        /// </summary>
        /// <param name="parameters">ProcessQueryParameters</param>
        /// <returns>ProcessDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<ApiResult<ProcessDtoList>>> GetProcesses([FromQuery] ProcessQueryParameters parameters)
        {
            _logger.LogInformation("Query string for Process: {0}", parameters);
            var pageddtos = await _service.GetProcessesByPage(parameters);
            var list = new ProcessDtoList(pageddtos);
            return ApiResult<ProcessDtoList>.HasData(list, pageddtos.TotalCount);
        }

        /// <summary>
        /// 添加流程
        /// </summary>
        /// <param name="creationDto">ProcessCreationDto</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<StringApiResult>> CreateProcess(ProcessCreationDto creationDto)
        {
            try
            {
                var result = await _service.InsertProcess(creationDto);
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
        /// 修改流程
        /// </summary>
        /// <param name="processId">Guid</param>
        /// <param name="updateDto">ProcessUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{processId}")]
        public async Task<ActionResult<StringApiResult>> UpdateProcess(Guid processId, ProcessUpdateDto updateDto)
        {
            try
            {
                var result = await _service.UpdateProcess(processId, updateDto);
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
        /// 批量删除流程
        /// </summary>
        /// <param name="dto">DeleteMultiDto</param>
        /// <returns></returns>
        [HttpPut("deletemulti")]
        public async Task<ActionResult<StringApiResult>> DeleteProcess(DeleteMultiDto dto)
        {
            try
            {
                var result = await _service.DeleteProcesses(dto);
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
