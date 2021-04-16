using RestSharp.Portable;
using RestSharp.Portable.HttpClient;
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
            Configuration.ApiKey.TryGetValue("API_DEBUG", out string debug);

            bool.TryParse(debug, out var bdebug);

            var restClient = new RestClient("https://api.iconomi.com");
            var uri = restClient.BuildUri(request);
            string url = uri.AbsolutePath;
            // string uri = request.Resource;

            Method method = request.Method;
            Parameter body = request.Parameters.FirstOrDefault(p => p.Type == ParameterType.RequestBody);

            string message = $"{timestamp}{method}{url}{body}";

            string sign = Digest(secret, message);

            request.AddHeader("ICN-API-KEY", key);
            request.AddHeader("ICN-SIGN", sign);
            request.AddHeader("ICN-TIMESTAMP", timestamp.ToString());

            if (bdebug)
            {
                request.AddHeader("ICN-MESSAGE", message);
            }

        }

        private String Digest(string secret, string digest)
        {
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
