using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace Megarobo.KunPengLIMS.WebAPI.Filters
{
    public class KeycloakAuthorizeFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var token = context.HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last()
            ?? context.HttpContext.Request.Headers["X-Token"].FirstOrDefault()
            ?? context.HttpContext.Request.Query["Token"].FirstOrDefault()
            ?? context.HttpContext.Request.Cookies["Token"];
            if (token == null || !VerifyToken(context.HttpContext, token))
            {
                context.Result = new UnauthorizedResult();
            }
        }

        private bool VerifyToken(HttpContext context, string token)
        {
            var url = "https://keycloak.dev.aws.megarobo.tech/auth/realms/lims-test/protocol/openid-connect/userinfo";
            var request = (HttpWebRequest)WebRequest.Create(url);
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
            request.Method = "GET";
            //request.Credentials = CredentialCache.DefaultCredentials;
            request.Headers.Add("Authorization", $"Bearer {token}");
            request.KeepAlive = false;
            var response = (HttpWebResponse)request.GetResponse();
            var responseStream = response.GetResponseStream();
            var streamReader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
            var content = streamReader.ReadToEnd();
            //JObject bupo = JsonConvert.DeserializeObject<JObject>(retString);
            streamReader.Close();
            responseStream.Close();
            return (!string.IsNullOrEmpty(content) && !content.Contains("error"));

            //try
            //{
            //    var tokenHandler = new JwtSecurityTokenHandler();
            //    var key = Encoding.ASCII.GetBytes(_authOptions.Security);
            //    tokenHandler.ValidateToken(token, new TokenValidationParameters
            //    {
            //        ValidateIssuerSigningKey = true,
            //        IssuerSigningKey = new SymmetricSecurityKey(key),
            //        ValidateIssuer = false,
            //        ValidateAudience = false,
            //        ClockSkew = TimeSpan.Zero // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
            //    }, out SecurityToken validatedToken);
            //    var jwtToken = (JwtSecurityToken)validatedToken;
            //    var user = jwtToken.Claims.First(x => x.Type == "user").Value.ToJsonEntity<DyUser>();
            //    //写入认证信息，方便业务类使用
            //    var claimsIdentity = new ClaimsIdentity(new Claim[] { new Claim("user", jwtToken.Claims.First(x => x.Type == "user").Value) });
            //    Thread.CurrentPrincipal = new ClaimsPrincipal(claimsIdentity);
            //    // attach user to context on successful jwt validation
            //    context.Items["User"] = user;
            //}
            //catch
            //{
            //    // do nothing if jwt validation fails
            //    // user is not attached to context so request won't have access to secure routes
            //    throw;
            //}
        }

        private bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true; //总是接受
        }
    }
}
