using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Megarobo.KunPengLIMS.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Megarobo.KunPengLIMS.WebAPI.Filters
{
    public class JsonExceptionFilter : IExceptionFilter
    {
        public IWebHostEnvironment Environment { get; }

        public ILogger Logger { get; }

        public JsonExceptionFilter(IWebHostEnvironment env,ILogger<Program> logger)
        {
            Environment = env;
            Logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            var error = new StringApiResult();
            if(Environment.IsDevelopment())
            {
                error.Code = 2;
                error.Message = context.Exception.Message;
                error.Data = context.Exception.ToString();
            }
            else
            {
                if(context.HttpContext.Request.Headers.ContainsKey("Verbose"))
                {
                    var request = context.HttpContext.Request;
                    error.Code = 2;
                    error.Message = string.Format("{0} {1}://{2}{3}{4}{5} at {6} run into error.", request.Method, request.Scheme, request.Host.Value, request.Path, request.QueryString.HasValue ? "?" : string.Empty, request.QueryString.HasValue ? request.QueryString.Value : string.Empty, DateTime.Now);
                    error.Data = context.Exception.ToString();
                }
                else
                {
                    error.Code = 2;
                    error.Message = DateTime.Now + ": Server error";
                    error.Data = context.Exception.Message;
                }
            }
            context.Result = new ObjectResult(error) { StatusCode = StatusCodes.Status500InternalServerError };

            var sb = new StringBuilder();
            sb.AppendLine($"Service in exception: {context.Exception.Message}");
            sb.AppendLine(context.Exception.ToString());
            Logger.LogCritical(sb.ToString());
        }
    }
}
