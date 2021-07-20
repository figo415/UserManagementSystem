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
    /// 细胞管理
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/projects")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectAppService _service;
        private readonly ILogger<ProjectController> _logger;

        public ProjectController(IProjectAppService service, ILogger<ProjectController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取项目，可根据项目名称、流程名称或状态查询
        /// </summary>
        /// <param name="parameters">ProjectQueryParameters</param>
        /// <returns>ProjectDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<ProjectApiResult>> GetProjects([FromQuery] ProjectQueryParameters parameters)
        {
            _logger.LogInformation("Query string for Project: {0}", parameters);
            var pageddtos = await _service.GetProjectsByPage(parameters);
            return ProjectApiResult.Succeed(pageddtos, pageddtos.TotalCount);
        }

        /// <summary>
        /// 获取单个项目
        /// </summary>
        /// <param name="projectId">Guid</param>
        /// <returns>ProjectDto</returns>
        [HttpGet("{projectId}")]
        public Task<ActionResult<ApiResult<ProjectDto>>> GetProject(Guid projectId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 添加项目
        /// </summary>
        /// <param name="creationDto">ProjectCreationDto</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<StringApiResult>> CreateProject(ProjectCreationDto creationDto)
        {
            try
            {
                var result = await _service.InsertProject(creationDto);
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
        /// 修改项目
        /// </summary>
        /// <param name="projectId">Guid</param>
        /// <param name="updateDto">ProjectUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{projectId}")]
        public async Task<ActionResult<StringApiResult>> UpdateProject(Guid projectId, ProjectUpdateDto updateDto)
        {
            try
            {
                var result = await _service.UpdateProject(projectId, updateDto);
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
        /// 修改项目流程
        /// </summary>
        /// <param name="projectId">Guid</param>
        /// <param name="updateDto">ProjectUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{projectId}/process")]
        public Task<ActionResult<StringApiResult>> UpdateProcessOfProject(Guid projectId, ProjectUpdateDto updateDto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 终止流程
        /// </summary>
        /// <param name="projectId">Guid</param>
        /// <param name="updateDto">ProjectUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{projectId}/status")]
        public Task<ActionResult<StringApiResult>> UpdateStatusOfProject(Guid projectId, ProjectUpdateDto updateDto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 批量删除项目
        /// </summary>
        /// <param name="dto">DeleteMultiDto</param>
        /// <returns></returns>
        [HttpPut("deletemulti")]
        public async Task<ActionResult<StringApiResult>> DeleteProject(DeleteMultiDto dto)
        {
            try
            {
                var result = await _service.DeleteProjects(dto);
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
