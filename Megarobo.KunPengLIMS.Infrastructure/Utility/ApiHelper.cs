using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Megarobo.KunPengLIMS.Domain.Externals;
using System.Net.Http;
using RestSharp;
using System.Net;

namespace Megarobo.KunPengLIMS.Infrastructure.Utility
{
    public class ApiHelper
    {
        public static T GetWebApi<T>(string baseUrl,string resource, string token, Dictionary<string, object> dicParams = null) where T:ApiResponse,new()
        {
            T result = default(T);
            try
            {
                var client = new RestClient(baseUrl);
                var request = new RestRequest(resource, Method.GET);
                request.AddHeader("token", token);
                if (dicParams != null)
                {
                    foreach (var pair in dicParams)
                    {
                        request.AddParameter(pair.Key, pair.Value);
                    }
                }
                var response = client.Execute(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (response.Content.Contains("message"))
                    {
                        var apiresponse = JsonConvert.DeserializeObject<NonQueryApiResponse>(response.Content);
                        result = new T();
                        result.msg = apiresponse.message;
                        result.code = apiresponse.code;
                    }
                    else
                    {
                        result = JsonConvert.DeserializeObject<T>(response.Content);
                    }
                }
                var log = string.Format("{0}: GET {1}{2}", (int)response.StatusCode, baseUrl, resource);
                Console.WriteLine(log);
            }
            catch (Exception ex)
            {
                var log = string.Format("500: GET {0}{1} Error: {2}", baseUrl, resource, ex.Message);
                Console.WriteLine(log);
            }
            return result;
        }

        public static T PostWebApi<T>(string baseUrl, string resource, string token, object obj) where T: ApiResponse,new()
        {
            T result = default(T);
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource, Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddHeader("token", token);
            var jb = JsonConvert.SerializeObject(obj);
            request.AddJsonBody(jb);
            var response = client.Execute<T>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                if (response.Content.Contains("message")) //{"code":50000,"message":" 用户不存在，请重新登录"}
                {
                    var apiresponse = JsonConvert.DeserializeObject<NonQueryApiResponse>(response.Content);
                    result = new T();
                    result.msg = apiresponse.message;
                    result.code = apiresponse.code;
                }
                else
                {
                    result = JsonConvert.DeserializeObject<T>(response.Content, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
                }
            }
            var log = string.Format("{0}: POST {1}{2}", (int)response.StatusCode, baseUrl, resource);
            Console.WriteLine(log);
            return result;
        }
    }
}
