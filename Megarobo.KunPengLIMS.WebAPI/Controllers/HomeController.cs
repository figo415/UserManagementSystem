using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Megarobo.KunPengLIMS.WebAPI.Filters;
using System.Net;
using System.IO;
using System.Text;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    [AllowAnonymous]
    [Route("limsapi/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        /// <summary>
        /// 用于健康检查
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(string.Format("Welcome to LIMS! {0}", DateTime.Now));
        }
    }
}
