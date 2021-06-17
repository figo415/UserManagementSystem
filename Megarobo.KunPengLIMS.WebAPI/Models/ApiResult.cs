using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        /// 对于查询API，保存实际的数据
        /// </summary>
        public T Data { get; set; }

        //public virtual object Data { get; set; }
    }

    //public class ApiResult<T>:ApiResult
    //{
    //    private T _data;

    //    public override object Data { get => _data; set => _data = (T)value; }
    //}

    /// <summary>
    /// 用于返回新增、修改和删除API的结果
    /// </summary>
    public class ApiStringResult:ApiResult<string>
    {

    }
}
