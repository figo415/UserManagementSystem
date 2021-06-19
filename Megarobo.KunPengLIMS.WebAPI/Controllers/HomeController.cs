using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
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
            return Ok(string.Format("Welcome! {0}", DateTime.Now));
        }
    }
}
