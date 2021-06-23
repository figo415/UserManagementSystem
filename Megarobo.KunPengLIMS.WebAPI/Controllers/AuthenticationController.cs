using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Megarobo.KunPengLIMS.WebAPI.Models;
using Megarobo.KunPengLIMS.Application.Services;

namespace Megarobo.KunPengLIMS.WebAPI.Controllers
{
    /// <summary>
    /// 登录
    /// </summary>
    [Route("limsapi/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        //private readonly IRepositoryWrapper _repoWrapper;

        //public AuthenticationController(IRepositoryWrapper repoWrapper)
        //{
        //    _repoWrapper = repoWrapper;
        //}

        private IUserAppService _userAppService;

        public AuthenticationController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        /// <summary>
        /// 验证用户名和密码
        /// </summary>
        /// <param name="requestDto">AuthRequestDto</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<ApiStringResult>> AuthenticateUser(AuthRequestDto requestDto)
        {
            Console.WriteLine(DateTime.Now + ": AuthenticateUser: " + requestDto.UserName);
            var result = new ApiStringResult();
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
    }
}
