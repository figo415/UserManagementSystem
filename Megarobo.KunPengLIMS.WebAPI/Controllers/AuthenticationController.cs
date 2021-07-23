using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Configuration;
using Megarobo.KunPengLIMS.WebAPI.Models;
using Megarobo.KunPengLIMS.Application.Services;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    /// <summary>
    /// 登录
    /// </summary>
    [Route("limsapi/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserAppService _userAppService;

        public IConfiguration Configuration { get; }

        public AuthenticationController(IUserAppService userAppService, IConfiguration configuration)
        {
            _userAppService = userAppService;
            Configuration = configuration;
        }

        /// <summary>
        /// 验证用户名和密码
        /// </summary>
        /// <param name="requestDto">AuthRequestDto</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<StringApiResult>> AuthenticateUser(AuthRequestDto requestDto)
        {
            Console.WriteLine(DateTime.Now + ": AuthenticateUser: " + requestDto.UserName);
            var result = new StringApiResult();
            //var responseDto = new AuthResponseDto();
            //var user =  _userAppService.CheckUser(requestDto.UserName, requestDto.Password);
            //if (user != null)
            //{
            //    result.Code = 0;
            //    result.Message = "登录成功";
            //}
            //else
            //{
            //    result.Code = 1;
            //    result.Message = "登录失败";
            //}
            //var resource = "/api/organizations/codeinternal/" + requestDto.ORGANIZATION_CODE;
            //var organizationDto = WebApiHelper.GetWebApi<OrganizationDto>("http://192.168.0.109:8010", resource);
            //if(organizationDto!=null)
            //{
            //    sys_usr sysusr;
            //    var code = 0;
            //    var iscode = int.TryParse(requestDto.USR_NAME, out code);
            //    if(iscode)
            //    {
            //        sysusr = await _repoWrapper.SysUsrRepo.GetSysUsrByCode(organizationDto.ROWID, requestDto.USR_NAME);
            //    }
            //    else
            //    {
            //        sysusr = await _repoWrapper.SysUsrRepo.GetSysUsrByName(organizationDto.ROWID, requestDto.USR_NAME);
            //    }
            //    if (sysusr != null && sysusr.USR_PWD == requestDto.USR_PWD)
            //    {
            //        result.code = 1;
            //        result.msg = "登录成功";
            //        responseDto.ORGANIZATION_ROWID = organizationDto.ROWID;
            //        responseDto.ORGANIZATION_CODE = organizationDto.ORGANIZATION_CODE;
            //        responseDto.ORGANIZATION_NAME = organizationDto.ORGANIZATION_NAME;
            //        responseDto.ROWID = sysusr.ROWID;
            //        responseDto.USR_CODE = sysusr.USR_CODE;
            //        responseDto.USR_NAME = sysusr.USR_NAME;
            //        responseDto.USR_DEPT = sysusr.USR_DEPT;
            //        result.data = responseDto;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(DateTime.Now + "： 未获取到组织");
            //}
            return result;
        }

        [HttpPost("token",Name =nameof(GenerateToken))]
        public IActionResult GenerateToken(AuthRequestDto dto)
        {
            if(dto.UserName!="fsun" || dto.Password!="megarobo")
            {
                return Unauthorized();
            }
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub,dto.UserName)
            };
            var seckey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("938diejsiwiriqusk12"));
            var signcred = new SigningCredentials(seckey, SecurityAlgorithms.HmacSha256);
            var jwttoken = new JwtSecurityToken(issuer: "http://localhost:8080/auth/realms/locallims/test", audience: "accounttest", claims = claims, expires: DateTime.Now.AddMinutes(3), signingCredentials: signcred);
            return Ok(new { token=new JwtSecurityTokenHandler().WriteToken(jwttoken),expiration=TimeZoneInfo.ConvertTimeFromUtc(jwttoken.ValidTo,TimeZoneInfo.Local)});
        }
    }
}

public class AuthRequestDto
{
    [Required(ErrorMessage = "用户名不能为空。")]
    public string UserName { get; set; }

    [Required(ErrorMessage = "密码不能为空。")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}
