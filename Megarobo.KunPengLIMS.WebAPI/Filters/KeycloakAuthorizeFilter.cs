using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using System.Net;
using System.IO;
using System.Net.Security;
using Megarobo.KunPengLIMS.Domain.ExternalDefinitions;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Megarobo.KunPengLIMS.WebAPI.Filters
{
    public class KeycloakAuthorizeFilter : IAuthorizationFilter
    {
        private readonly IKeycloakService _keycloak;
        
        public KeycloakAuthorizeFilter(IKeycloakService keycloak)
        {
            _keycloak = keycloak;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if(!HasAllowAnonymous(context))
            {
                var token = context.HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last()
            ?? context.HttpContext.Request.Headers["X-Token"].FirstOrDefault()
            ?? context.HttpContext.Request.Query["Token"].FirstOrDefault()
            ?? context.HttpContext.Request.Cookies["Token"];
                if (token != null)
                {
                    var isTokenValid = VerifyToken(context.HttpContext, token);
                    if(!isTokenValid)
                    {
                        context.Result = new UnauthorizedResult();
                    }
                }
                else
                {
                    context.Result = new UnauthorizedResult();
                }
            }
        }

        private bool VerifyToken(HttpContext context, string token)
        {
            var userinfo = _keycloak.CheckToken(token);
            if(userinfo!=null)
            {
                var claimsIdentity = new ClaimsIdentity(new Claim[] { new Claim(ClaimTypes.Name, userinfo.preferred_username) });
                context.User.AddIdentity(claimsIdentity);
                return true;
            }
            return false;
        }

        private bool HasAllowAnonymous(AuthorizationFilterContext context)
        {
            //return true;
            var filters = context.Filters;
            for (var i = 0; i < filters.Count; i++)
            {
                if (filters[i] is IAllowAnonymousFilter)
                {
                    return true;
                }
            }

            // When doing endpoint routing, MVC does not add AllowAnonymousFilters for AllowAnonymousAttributes that
            // were discovered on controllers and actions. To maintain compat with 2.x,
            // we'll check for the presence of IAllowAnonymous in endpoint metadata.
            var endpoint = context.HttpContext.GetEndpoint();
            if (endpoint?.Metadata?.GetMetadata<IAllowAnonymous>() != null)
            {
                return true;
            }
            return false;
        }
    }
}
