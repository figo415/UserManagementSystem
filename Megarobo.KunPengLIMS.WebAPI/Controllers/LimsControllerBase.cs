using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Megarobo.KunPengLIMS.Infrastructure.Utility.Convert;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    public abstract class LimsControllerBase : ControllerBase
    {
        //public override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    byte[] result; 
        //    filterContext.HttpContext.Session.TryGetValue("CurrentUser",out result);
        //    if (result == null)
        //    {
        //        filterContext.Result = new RedirectResult("/Login/Index");
        //        return;
        //    }
        //    base.OnActionExecuting(filterContext);
        //}

        /// <summary>
        /// 获取服务端验证的第一条错误信息
        /// </summary>
        /// <returns></returns>
        protected string GetModelStateError()
        {
            foreach (var item in ModelState.Values)
            {
                if (item.Errors.Count > 0)
                {
                    return item.Errors[0].ErrorMessage;
                }
            }
            return "";
        }
    }
}
