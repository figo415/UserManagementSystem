using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using Megarobo.KunPengLIMS.WebAPI.Models;

namespace Megarobo.KunPengLIMS.WebAPI.Filters
{
    public class RequestAuthorizeAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //从http请求头里面获取身份验证信息，验证Jwt
            var jwtKey = context.HttpContext.Request.Headers["Authorization"].ToString();
            var a = jwtKey.Substring(7);
            var jwtSecurityToken = new JwtSecurityTokenHandler().ReadJwtToken(a);
            var c = jwtSecurityToken.Claims;
            context.HttpContext.Items.Add("ceshi", c);


            if (!string.IsNullOrEmpty(jwtKey))
            {

                context.HttpContext.Request.Headers.Add("ddd", "ddd");
            }
            //如果取不到身份验证信息，并且不允许匿名访问，则返回未验证401
            else
            {
                var apierror = new StringApiResult()
                {
                    Code = 5,
                    Message = "请求未授权",
                    Data = "请求未授权"
                };
                context.Result = new ObjectResult(apierror) { StatusCode = StatusCodes.Status401Unauthorized };
            }
        }
    }
}
