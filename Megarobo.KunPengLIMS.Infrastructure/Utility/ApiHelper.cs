using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Megarobo.KunPengLIMS.Domain.Externals;
using System.Net.Http;

namespace Megarobo.KunPengLIMS.Infrastructure.Utility
{
    public class ApiHelper
    {
        private static string _baseUrl;

        public static void SetBaseUrl(string url)
        {
            _baseUrl = url;
        }

        public static T GetWebApi<T>(string resource, string token, Dictionary<string, object> dicParams = null)
        {
            T result = default(T);
            try
            {
                var client = new RestSharp.RestClient(_baseUrl);
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
                    if (!response.Content.Contains("message"))
                    {
                        result = JsonConvert.DeserializeObject<T>(response.Content);
                    }
                }
                var log = string.Format("{0}: GET {1}{2}", (int)response.StatusCode, _baseUrl, resource);
                Console.WriteLine(log);
            }
            catch (Exception ex)
            {
                var log = string.Format("500: GET {0}{1} Error: {2}", _baseUrl, resource, ex.Message);
                Console.WriteLine(log);
            }
            return result;
        }

        public static T PostWebApi<T>(string resource, string token, object obj)
        {
            T result = default(T);
            var client = new RestSharp.RestClient(_baseUrl);
            var request = new RestSharp.RestRequest(resource, RestSharp.Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddHeader("token", token);
            var jb = JsonConvert.SerializeObject(obj);
            request.AddJsonBody(jb);
            var rspse = client.Execute<T>(request);
            if (rspse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                if (!rspse.Content.Contains("message")) //{"code":50000,"message":" 用户不存在，请重新登录"}
                {
                    result = JsonConvert.DeserializeObject<T>(rspse.Content);
                }
            }
            var log = string.Format("{0}: POST {1}{2}", (int)rspse.StatusCode, _baseUrl, resource);
            Console.WriteLine(log);
            return result;
        }

        public static async Task<TokenResponse> GetToken()
        {
            try
            {
                TokenResponse result = null;
                var paramList = new List<KeyValuePair<string, string>>();
                paramList.Add(new KeyValuePair<string, string>("username", "admin@admin.com"));
                paramList.Add(new KeyValuePair<string, string>("password", "123456"));
                paramList.Add(new KeyValuePair<string, string>("client_id", "web-ui"));
                paramList.Add(new KeyValuePair<string, string>("grant_type", "password"));
                var client = new HttpClient();
                var resp = await client.PostAsync(new Uri("https://keycloak.dev.aws.megarobo.tech/auth/realms/lims-test/protocol/openid-connect/token"), new FormUrlEncodedContent(paramList));
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
    }
}
