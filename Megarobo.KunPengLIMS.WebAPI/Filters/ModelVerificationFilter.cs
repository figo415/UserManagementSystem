using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;
using Megarobo.KunPengLIMS.WebAPI.Models;

namespace Megarobo.KunPengLIMS.WebAPI.Filters
{
    public class ModelVerificationFilter:IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        /// <summary>
        /// Action执行前验证DTO
        /// </summary>
        /// <param name="context"></param>
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var message = string.Empty;
                foreach (var item in context.ModelState.Values)
                {
                    foreach (var error in item.Errors)
                    {
                        message += error.ErrorMessage;
                    }
                }
                var apierror = new ApiStringResult()
                {
                    Code = 5,
                    Message = "Model state is not valid",
                    Data = message
                };
                context.Result = new ObjectResult(apierror) { StatusCode = StatusCodes.Status400BadRequest };
            }
        }
    }
}
