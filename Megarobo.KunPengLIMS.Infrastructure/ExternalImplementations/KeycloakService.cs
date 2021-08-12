using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Megarobo.KunPengLIMS.Domain.ExternalDefinitions;
using Megarobo.KunPengLIMS.Infrastructure.Utility;
using Megarobo.KunPengLIMS.Domain.Externals;
using System.Net;
using Newtonsoft.Json;

namespace Megarobo.KunPengLIMS.Infrastructure.ExternalImplementations
{
    public class KeycloakService:IKeycloakService
    {
        private string _keycloakUrl;
        private string _masterClientId;
        private string _masterUsername;
        private string _masterPassword;
        private string _kplimsRealm;

        public KeycloakService(string connectionString)
        {
            if(string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException("ConnectionString for KeyCloak");
            }
            try
            {
                var pairs = connectionString.Split(';', StringSplitOptions.RemoveEmptyEntries);
                var dic = new Dictionary<string, string>();
                foreach (var pair in pairs)
                {
                    var kv = pair.Split("=", StringSplitOptions.RemoveEmptyEntries);
                    dic.Add(kv[0], kv[1]);
                }
                _keycloakUrl = dic["KeycloakUrl"];
                _masterClientId = dic["MasterClientId"];
                _masterUsername = dic["MasterUsername"];
                _masterPassword = dic["MasterPassword"];
                _kplimsRealm = dic["KplimsRealm"];
            }
            catch(Exception ex)
            {
                throw new ArgumentException("The correct Connection String for KeyCloak is like: KeycloakUrl=https://keycloak.dev.aws.megarobo.tech;MasterClientId=admin-cli;MasterUsername=keycloak;MasterPassword=keycloak;KplimsRealm=kplims-dev;");
            }
        }

        public async Task<Guid?> CreateUser(Guid id, string username, string email, bool isActive)
        {
            Guid? result = null;
            var tokenresponse = GetToken();
            var userrep = new KeycloakUserRep()
            {
                id=id.ToString(),
                username = username,
                email = email,
                emailVerified = false,
                enabled = isActive,
                credentials=new List<KeycloakCredentialRep>()
                {
                    new KeycloakCredentialRep()
                    {
                        type="password",
                        value="123456",
                        temporary=false
                    }
                }
            };
            var resource = string.Format("/auth/admin/realms/{0}/users", _kplimsRealm);
            var client = new RestClient(_keycloakUrl);
            var request = new RestRequest(resource, Method.POST);
            request.AddHeader("Authorization", $"Bearer {tokenresponse.access_token}");
            var jb = JsonConvert.SerializeObject(userrep);
            request.AddJsonBody(jb);
            var response = await client.ExecuteAsync(request);
            if (response.StatusCode == HttpStatusCode.Created)
            {
                var location = string.Empty;
                foreach(var para in response.Headers)
                {
                    if(para.Name== "Location")
                    {
                        location = para.Value.ToString();
                    }
                }
                if(!string.IsNullOrEmpty(location))
                {
                    result = new Guid(location.Substring(location.Length - 36));
                }
            }
            return result;
        }

        private TokenResponse GetToken()
        {
            var client = new RestClient(_keycloakUrl);
            var request = new RestRequest("/auth/realms/master/protocol/openid-connect/token", Method.POST);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("application/x-www-form-urlencoded", $"client_id={_masterClientId}&grant_type=password&username={_masterUsername}&password={_masterPassword}", ParameterType.RequestBody);
            var response = client.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                return null;
            }
            var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(response.Content);
            return tokenResponse;
        }

        public async Task<bool> UpdateUser(Guid userid, string username, string email, bool isActive)
        {
            var tokenresponse = GetToken();
            var resource = string.Format("/auth/admin/realms/{0}/users/{1}", _kplimsRealm, userid);
            var client = new RestClient(_keycloakUrl);
            var request = new RestRequest(resource, Method.PUT);
            request.AddHeader("Authorization", $"Bearer {tokenresponse.access_token}");
            var jb = isActive ? "{\"username\":\"" + username + "\",\"email\":\"" + email + "\",\"enabled\": true}" : "{\"username\":\"" + username + "\",\"email\":\"" + email + "\",\"enabled\": false}";
            request.AddJsonBody(jb);
            var response = await client.ExecuteAsync(request);
            return (response.StatusCode == HttpStatusCode.NoContent);
        }

        public async Task<bool> EnableUser(Guid userid, bool isActive)
        {
            var tokenresponse = GetToken();
            var resource = string.Format("/auth/admin/realms/{0}/users/{1}", _kplimsRealm, userid);
            var client = new RestClient(_keycloakUrl);
            var request = new RestRequest(resource, Method.PUT);
            request.AddHeader("Authorization", $"Bearer {tokenresponse.access_token}");
            var jb = isActive ? "{\"enabled\": true}" : "{\"enabled\": false}";
            request.AddJsonBody(jb);
            var response = await client.ExecuteAsync(request);
            return (response.StatusCode == HttpStatusCode.NoContent);
        }

        public async Task<bool> ChangePassword(Guid userid, string password)
        {
            var tokenresponse = GetToken();
            var resource = string.Format("/auth/admin/realms/{0}/users/{1}", _kplimsRealm, userid);
            var client = new RestClient(_keycloakUrl);
            var request = new RestRequest(resource, Method.PUT);
            request.AddHeader("Authorization", $"Bearer {tokenresponse.access_token}");
            var jb = "{\"credentials\":[{\"type\":\"password\",\"value\":\"" + password + "\",\"temporary\":false}]}";
            request.AddJsonBody(jb);
            var response = await client.ExecuteAsync(request);
            return (response.StatusCode == HttpStatusCode.NoContent);
        }

        public UserInfoResponse CheckToken(string token)
        {
            UserInfoResponse userinfo = null;
            var resource = string.Format("/auth/realms/{0}/protocol/openid-connect/userinfo", _kplimsRealm);
            var client = new RestClient(_keycloakUrl);
            var request = new RestRequest(resource, Method.GET);
            request.AddHeader("Authorization", $"Bearer {token}");
            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                userinfo = JsonConvert.DeserializeObject<UserInfoResponse>(response.Content);
            }
            return userinfo;
        }

        public async Task<bool> DeleteUser(Guid userid)
        {
            var tokenresponse = GetToken();
            var resource = string.Format("/auth/admin/realms/{0}/users/{1}", _kplimsRealm, userid);
            var client = new RestClient(_keycloakUrl);
            var request = new RestRequest(resource, Method.DELETE);
            request.AddHeader("Authorization", $"Bearer {tokenresponse.access_token}");
            var response = await client.ExecuteAsync(request);
            return (response.StatusCode == HttpStatusCode.NoContent);
        }
    }
}
