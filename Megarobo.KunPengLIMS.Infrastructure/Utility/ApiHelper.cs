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
        private InventoryApiInfo _info;

        public ApiHelper(IOptions<InventoryApiInfo> options)
        {
            _info = options.Value;
        }

        public T GetWebApi<T>(string resource, string token, Dictionary<string, object> dicParams = null) where T:ApiResponse,new()
        {
            T result = default(T);
            try
            {
                var client = new RestSharp.RestClient(_info.InventoryBaseUrl);
                var request = new RestSharp.RestRequest(resource, RestSharp.Method.GET);
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
                var log = string.Format("{0}: GET {1}{2}", (int)response.StatusCode, _info.InventoryBaseUrl, resource);
                Console.WriteLine(log);
            }
            catch (Exception ex)
            {
                var log = string.Format("500: GET {0}{1} Error: {2}", _info.InventoryBaseUrl, resource, ex.Message);
                Console.WriteLine(log);
            }
            return result;
        }

        public static T GetWithAuth<T>(string authurl, string resource, string token, Dictionary<string, object> dicParams = null) 
        {
            T result = default(T);
            try
            {
                var client = new RestSharp.RestClient(authurl);
                var request = new RestSharp.RestRequest(resource, RestSharp.Method.GET);
                request.AddHeader("Authorization", $"Bearer {token}");
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
                    result = JsonConvert.DeserializeObject<T>(response.Content);
                }
                var log = string.Format("{0}: GET {1}{2}", (int)response.StatusCode, authurl, resource);
                Console.WriteLine(log);
            }
            catch (Exception ex)
            {
                var log = string.Format("500: GET {0}{1} Error: {2}", authurl, resource, ex.Message);
                Console.WriteLine(log);
            }
            return result;
        }

        public T PostWebApi<T>(string resource, string token, object obj) where T: ApiResponse,new()
        {
            T result = default(T);
            var client = new RestSharp.RestClient(_info.InventoryBaseUrl);
            var request = new RestSharp.RestRequest(resource, RestSharp.Method.POST);
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
            var log = string.Format("{0}: POST {1}{2}", (int)response.StatusCode, _info.InventoryBaseUrl, resource);
            Console.WriteLine(log);
            return result;
        }

        public async Task<TokenResponse> GetToken()
        {
            try
            {
                TokenResponse result = null;
                var paramList = new List<KeyValuePair<string, string>>();
                paramList.Add(new KeyValuePair<string, string>("username", _info.UserName));
                paramList.Add(new KeyValuePair<string, string>("password", _info.Password));
                paramList.Add(new KeyValuePair<string, string>("client_id", _info.ClientId));
                paramList.Add(new KeyValuePair<string, string>("grant_type", _info.GrantType));
                var client = new HttpClient();
                var resp = await client.PostAsync(new Uri(_info.AuthUrl), new FormUrlEncodedContent(paramList));
                resp.EnsureSuccessStatusCode();
                var content = await resp.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<TokenResponse>(content);
                return result;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        private TokenResponse GetToken2()
        {
            var client = new RestClient(_info.AuthUrl);
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("application/x-www-form-urlencoded", $"client_id={_info.ClientId}&grant_type={_info.GrantType}&username={_info.UserName}&password={_info.Password}", ParameterType.RequestBody);
            var response = client.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                return null;
            }
            var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(response.Content);
            return tokenResponse;
        }
    }
}
