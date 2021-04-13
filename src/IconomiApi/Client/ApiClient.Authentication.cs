using RestSharp.Portable;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace IconomiApi.Client
{
    public partial class ApiClient
    {
        partial void InterceptRequest(IRestRequest request)
        {
            long timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            Configuration.ApiKey.TryGetValue("API_KEY", out string key);
            Configuration.ApiKey.TryGetValue("API_SECRET", out string secret);

            var body = request.Parameters.FirstOrDefault(p => p.Type == ParameterType.RequestBody);
            string sign = Digest(secret, request.Method, request.Resource, timestamp, body);

            request.AddHeader("ICN-API-KEY", key);
            request.AddHeader("ICN-SIGN", sign);
            request.AddHeader("ICN-TIMESTAMP", timestamp.ToString());

        }

        private readonly Regex _regex = new Regex(@"^\.");
        private String Digest(string secret, Method method, string uri, long timestamp, Parameter body)
        {
            string url = _regex.Replace(uri, "");
            string digest = $"{timestamp}{method}{url}{body}";
            var bsecret = Encoding.UTF8.GetBytes(secret);

            using (HMACSHA512 hmac = new HMACSHA512(bsecret))
            {
                var bytes = Encoding.UTF8.GetBytes(digest);
                byte[] hash = hmac.ComputeHash(bytes);
                string b64 = Convert.ToBase64String(hash);
                return b64;
            }
        }
    }
}
