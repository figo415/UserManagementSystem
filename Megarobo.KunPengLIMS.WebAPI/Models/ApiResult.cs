using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Megarobo.KunPengLIMS.Application;

namespace Megarobo.KunPengLIMS.WebAPI.Models
{
    /// <summary>
    /// WebAPI返回数据的统一格式
    /// </summary>
    public class ApiResult<T>
    {
        /// <summary>
        /// 状态码：0表示成功，其他正数表示失败
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// 附加消息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 此次查询的数据总条数
        /// </summary>
        public int RowCount { get; set; }

        /// <summary>
        /// 对于查询API，保存实际的数据
        /// </summary>
        public T Data { get; set; }

        public static ApiResult<T> HasData(T value,int total)
        {
            var result = new ApiResult<T>();
            result.Code = 0;
            result.Message = "Success";
            result.RowCount = total;
            result.Data = value;
            return result;
        }
    }

    /// <summary>
    /// 用于返回新增、修改和删除API的结果
    /// </summary>
    public class StringApiResult:ApiResult<string>
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
