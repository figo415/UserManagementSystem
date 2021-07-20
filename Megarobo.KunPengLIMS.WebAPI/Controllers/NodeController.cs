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
    /// 节点管理
    /// </summary>
    [Produces("application/json")]
    [Route("limsapi/nodes")]
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    public class NodeController : ControllerBase
    {
        private readonly INodeAppService _service;
        private readonly ILogger<NodeController> _logger;

        public NodeController(INodeAppService service, ILogger<NodeController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// 获取节点，可根据节点名称、节点类型或创建时间查询
        /// </summary>
        /// <param name="parameters">NodeQueryParameters</param>
        /// <returns>NodeDto列表</returns>
        [HttpGet]
        public async Task<ActionResult<NodeApiResult>> GetNodes([FromQuery] NodeQueryParameters parameters)
        {
            _logger.LogInformation("Query string for Node: {0}", parameters);
            var pageddtos = await _service.GetNodesByPage(parameters);
            return NodeApiResult.Succeed(pageddtos, pageddtos.TotalCount);
        }

        /// <summary>
        /// 添加节点
        /// </summary>
        /// <param name="creationDto">NodeCreationDto</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<StringApiResult>> CreateNode(NodeCreationDto creationDto)
        {
            try
            {
                var result = await _service.InsertNode(creationDto);
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
        /// 修改细胞
        /// </summary>
        /// <param name="nodeId">Guid</param>
        /// <param name="updateDto">NodeUpdateDto</param>
        /// <returns></returns>
        [HttpPut("{nodeId}")]
        public async Task<ActionResult<StringApiResult>> UpdateNode(Guid nodeId, NodeUpdateDto updateDto)
        {
            try
            {
                var result = await _service.UpdateNode(nodeId, updateDto);
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
        /// 批量删除节点
        /// </summary>
        /// <param name="dto">DeleteMultiDto</param>
        /// <returns></returns>
        [HttpPut("deletemulti")]
        public async Task<ActionResult<StringApiResult>> DeleteNode(DeleteMultiDto dto)
        {
            try
            {
                var result = await _service.DeleteNodes(dto);
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
