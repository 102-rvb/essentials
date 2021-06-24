using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Linq;

namespace _102_Essentials
{
    class API
    {
        private static string Host = "http://server.102.diltz.link:3000/";
        static readonly HttpClient client = new HttpClient();

        // constructors

        public class ExecuteJob
        {
            public string jobid { get; set; }
            public string code { get; set; }
        }

        public class BodyAuth_Creditnals
        {
            public string username { get; set; }
            public string password { get; set; }
        }

        public class AccountData
        {
            public string authorization { get; set; }
            public string username { get; set; }
            public byte level { get; set; }
        }

        // private funcitons

        private static HttpRequestMessage PreBuild_Request(HttpMethod Method, string Path, string Authorization = "")
        {
            HttpRequestMessage toReturn = new HttpRequestMessage(Method, Host + Path);

            if (Authorization.Length > 0)
            {
                toReturn.Headers.Add("authorization", Authorization);
            }

            return toReturn;
        }

        //// api
        // auth

        public static async void Logout(string Token)
        {
            var Request = PreBuild_Request(HttpMethod.Post, "auth/logout", Token);

            await client.SendAsync(Request);
        }

        public static async Task<AccountData> Login(string Username, string Password)
        {
            BodyAuth_Creditnals creditnals = new BodyAuth_Creditnals { username = Username, password = Password };
            AccountData toReturn = new AccountData { username = "N/A", level = 0, authorization = "" };
            var Request = PreBuild_Request(HttpMethod.Post, "auth/login");
            Request.Content = new StringContent(JsonConvert.SerializeObject(creditnals), Encoding.UTF8, "application/json");

            try
            {
                var Response = await client.SendAsync(Request);
                HttpStatusCode StatusCode = Response.StatusCode;

                if (StatusCode == HttpStatusCode.Forbidden)
                {
                    toReturn.username = "INCORRECT";

                    return toReturn;
                } else if (StatusCode == HttpStatusCode.NotFound)
                {
                    toReturn.username = "N/A";

                    return toReturn;
                }

                dynamic JSON = JObject.Parse(Response.Content.ReadAsStringAsync().Result);
                var authToken = Response.Headers.GetValues("authorization").First();

                toReturn.username = JSON.account_info.username;
                toReturn.level = JSON.account_info.level;
                toReturn.authorization = authToken;

                return toReturn;
            }
            catch (HttpRequestException)
            {
                toReturn.username = "APIDOWN";

                return toReturn;
            }
        }

        public static async Task<AccountData> GetAccountDataAsync(string Token)
        {
            AccountData toReturn = new AccountData { username = "N/A", level = 0, authorization = Token };
            var Request = PreBuild_Request(HttpMethod.Get, "auth/data", Token);

            try
            {
                var Response = await client.SendAsync(Request);
                dynamic JSON = JObject.Parse(Response.Content.ReadAsStringAsync().Result);
                HttpStatusCode StatusCode = Response.StatusCode;

                if (StatusCode == HttpStatusCode.Forbidden)
                {
                    toReturn.username = "BANNED";

                    return toReturn;
                }

                if (StatusCode == HttpStatusCode.NotFound)
                {
                    toReturn.username = "COOKIEFAIL";

                    return toReturn;
                }

                toReturn.username = JSON.data.username;
                toReturn.level = JSON.data.level;

                return toReturn;
            } catch (HttpRequestException)
            {
                toReturn.username = "APIDOWN";

                return toReturn;
            }
        }

        // execution

        public static async Task<bool> SS_ExecuteJob(string Code, string JobId, string Token)
        {
            ExecuteJob Request_Body = new ExecuteJob { jobid = JobId, code = Code };
            var Request = PreBuild_Request(HttpMethod.Post, "exec/setjob", Token);
            Request.Content = new StringContent(JsonConvert.SerializeObject(Request_Body), Encoding.UTF8, "application/json");
            var Response = await client.SendAsync(Request);

            return Response.IsSuccessStatusCode;
        }
    }
}
