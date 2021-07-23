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
            var result = new List<string>();
            foreach (var claim in User.Claims)
            {
                result.Add(claim.Type + ": " + claim.Value);
            }
            result.Add("username: " + User.Identity.Name);
            result.Add("IsAdmin: " + User.IsInRole("admin").ToString());
            return Ok(result);
            //return Ok(string.Format("Welcome! {0}", DateTime.Now));
        }
    }
}
