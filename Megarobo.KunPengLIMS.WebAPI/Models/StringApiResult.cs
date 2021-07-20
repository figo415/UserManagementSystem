using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    /// <summary>
    /// 用于返回新增、修改和删除API的结果
    /// </summary>
    public class StringApiResult : ApiResult<string>
    {
        public static StringApiResult Succeed()
        {
            return new StringApiResult()
            {
                Code = 0,
                Message = "Success"
            };
        }

        public static StringApiResult Fail()
        {
            return new StringApiResult()
            {
                Code = 1,
                Message = "Failed"
            };
        }

        public static StringApiResult Error(string msg)
        {
            return new StringApiResult()
            {
                Code = 2,
                Message = msg
            };
        }
    }
}
