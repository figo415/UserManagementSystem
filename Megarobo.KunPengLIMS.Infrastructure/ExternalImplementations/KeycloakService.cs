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
        private readonly string _keycloakBaseUrl = "https://keycloak.dev.aws.megarobo.tech";
        private readonly string _clientId = "admin-cli";
        private readonly string _username = "keycloak";
        private readonly string _password = "keycloak";

        public async Task<bool> CreateUser(Guid id, string username, string email, bool isActive)
        {
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
            var client = new RestClient(_keycloakBaseUrl);
            var request = new RestRequest("/auth/admin/realms/kplims-dev/users", Method.POST);
            request.AddHeader("Authorization", $"Bearer {tokenresponse.access_token}");
            var jb = JsonConvert.SerializeObject(userrep);
            request.AddJsonBody(jb);
            var response = await client.ExecuteAsync(request);
            return (response.StatusCode == HttpStatusCode.Created);
        }

        private TokenResponse GetToken()
        {
            var client = new RestClient(_keycloakBaseUrl);
            var request = new RestRequest("/auth/realms/master/protocol/openid-connect/token", Method.POST);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("application/x-www-form-urlencoded", $"client_id={_clientId}&grant_type=password&username={_username}&password={_password}", ParameterType.RequestBody);
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
            var client = new RestClient(_keycloakBaseUrl);
            var request = new RestRequest("/auth/admin/realms/kplims-dev/users/" + userid, Method.PUT);
            request.AddHeader("Authorization", $"Bearer {tokenresponse.access_token}");
            var jb = isActive ? string.Format("{\"username\":\"{0}\",\"email\":\"{1}\",\"enabled\": true}",username,email) : string.Format("{\"username\":\"{0}\",\"email\":\"{1}\",\"enabled\": false}", username, email);
            request.AddJsonBody(jb);
            var response = await client.ExecuteAsync(request);
            return (response.StatusCode == HttpStatusCode.NoContent);
        }

        public async Task<bool> EnableUser(Guid userid, bool isActive)
        {
            var tokenresponse = GetToken();
            var client = new RestClient(_keycloakBaseUrl);
            var request = new RestRequest("/auth/admin/realms/kplims-dev/users/"+userid, Method.PUT);
            request.AddHeader("Authorization", $"Bearer {tokenresponse.access_token}");
            var jb = isActive ? "{\"enabled\": true}" : "{\"enabled\": false}";
            request.AddJsonBody(jb);
            var response = await client.ExecuteAsync(request);
            return (response.StatusCode == HttpStatusCode.NoContent);
        }

        public async Task<bool> ChangePassword(Guid userid, string password)
        {
            var tokenresponse = GetToken();
            var client = new RestClient(_keycloakBaseUrl);
            var request = new RestRequest("/auth/admin/realms/kplims-dev/users/" + userid, Method.PUT);
            request.AddHeader("Authorization", $"Bearer {tokenresponse.access_token}");
            var jb = string.Format("{\"credentials\":[{\"type\":\"password\",\"value\":\"{0}\",\"temporary\":false}]}", password);
            request.AddJsonBody(jb);
            var response = await client.ExecuteAsync(request);
            return (response.StatusCode == HttpStatusCode.NoContent);
        }

        public UserInfoResponse CheckToken(string token)
        {
            UserInfoResponse userinfo = null;
            var client = new RestClient(_keycloakBaseUrl);
            var request = new RestRequest("/auth/realms/kplims-dev/protocol/openid-connect/userinfo", Method.GET);
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
            var client = new RestClient(_keycloakBaseUrl);
            var request = new RestRequest("/auth/admin/realms/kplims-dev/users/" + userid, Method.DELETE);
            request.AddHeader("Authorization", $"Bearer {tokenresponse.access_token}");
            var response = await client.ExecuteAsync(request);
            return (response.StatusCode == HttpStatusCode.NoContent);
        }
    }
}
