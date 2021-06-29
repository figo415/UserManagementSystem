using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Megarobo.KunPengLIMS.Application.Services;
using Megarobo.KunPengLIMS.Application.Dtos;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace Megarobo.KunPengLIMS.WebAPI.Filters
{
    public class LogFilterAttribute:ActionFilterAttribute
    {
        private readonly ILogItemAppService _logService;
        private readonly ILogger<LogFilterAttribute> _logger;

        public LogFilterAttribute(ILogItemAppService logService, ILogger<LogFilterAttribute> logger)
        {
            _logService = logService;
            _logger = logger;
        }

        public override void OnActionExecuted(ActionExecutedContext actionExecutedContext)
        {
            //var userInfo = ((System.Security.Claims.ClaimsIdentity)actionExecutedContext.HttpContext.User.Identity).Claims?.ToList();
            var dto = new LogItemCreationDto();
            dto.ModuleName = ((ControllerActionDescriptor)actionExecutedContext.ActionDescriptor).ControllerName;
            dto.OperationName = ((ControllerActionDescriptor)actionExecutedContext.ActionDescriptor).ActionName;
            //dto.Operator = userInfo?.Where(t => t.Type == "UserName")?.FirstOrDefault()?.Value;
            //dto.UserId = userInfo?.Where(t => t.Type == "UserId")?.FirstOrDefault()?.Value;
            dto.OperationType = actionExecutedContext.HttpContext.Request.Method;
            dto.RequestUrl = actionExecutedContext.HttpContext.Request.Path.Value;
            dto.RequestParameters = actionExecutedContext.HttpContext.Request.QueryString.Value;
            if (actionExecutedContext.Exception != null)
            {
                dto.IsSuccess = false;
                dto.ErrorMessage = actionExecutedContext.Exception.Message;
                dto.StackTrace = actionExecutedContext.Exception.StackTrace;
                _logger.LogError("{0}: {1} {2}{3} ERROR: {4}", actionExecutedContext.HttpContext.Response.StatusCode, dto.OperationType, dto.RequestUrl, dto.RequestParameters, dto.ErrorMessage);
            }
            else
            {
                dto.IsSuccess = true;
                _logger.LogInformation("{0}: {1} {2}{3}", actionExecutedContext.HttpContext.Response.StatusCode, dto.OperationType, dto.RequestUrl, dto.RequestParameters);
            }
            var result = _logService.InsertLogItem(dto);
            base.OnActionExecuted(actionExecutedContext);
        }

        private string ReadActionExcutedRequestBody(ActionExecutedContext context)
        {
            string requestBody = "";
            if (context != null)
            {
                var request = context.HttpContext.Request;
                request.Body.Position = 0;
                StreamReader stream = new StreamReader(request.Body);
                requestBody = stream.ReadToEnd();
                request.Body.Position = 0;
            }
            return requestBody;
        }

        private string GetActionExcutedResponseBody(ActionExecutedContext context)
        {
            string responseBody = "";
            if (context.Result != null)
            {
                if (context.Result is ObjectResult)
                    responseBody = JsonConvert.SerializeObject(((ObjectResult)context.Result).Value);
                if (context.Result is JsonResult)
                    responseBody = JsonConvert.SerializeObject(((JsonResult)context.Result).Value);
            }
            return responseBody;
        }
    }
}
