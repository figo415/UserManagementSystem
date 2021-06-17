using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.Application.LogItemApp.Dtos;
using Megarobo.KunPengLIMS.WebAPI.Models;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    /// <summary>
    /// 日志项管理
    /// </summary>
    [Route("api/logitems")]
    [ApiController]
    public class LogitemController : LimsControllerBase
    {
        /// <summary>
        /// 获取所有日志项，可根据用户名称或者状态来查询
        /// </summary>
        /// <returns>LogItemDto列表</returns>
        [HttpGet]
        public ActionResult<ApiResult<IEnumerable<LogItemDto>>> GetAllLogItems([FromQuery] LogItemResourceParameter parameter)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 根据主键获取日志项
        /// </summary>
        /// <param name="logItemId">int</param>
        /// <returns>LogItemDto</returns>
        [HttpGet("{logItemId}")]
        public ActionResult<ApiResult<LogItemDto>> GetLogItem(int logItemId)
        {
            throw new NotImplementedException();
        }
    }
}
