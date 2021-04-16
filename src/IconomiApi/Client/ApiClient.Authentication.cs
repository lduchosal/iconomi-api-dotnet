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

        const string API_KEY = "API_KEY";
        const string API_SECRET = "API_SECRET";
        const string API_DEBUG = "API_DEBUG";
        public void SetAuthentication(string key, string secret, bool debug = false)
        {

            Configuration.ApiKey[API_KEY] = key;
            Configuration.ApiKey[API_SECRET] = secret;
            Configuration.ApiKey[API_DEBUG] = debug.ToString();
        }

        partial void InterceptRequest(IRestRequest request)
        {
            long timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            Configuration.ApiKey.TryGetValue(API_KEY, out string key);
            Configuration.ApiKey.TryGetValue(API_SECRET, out string secret);
            Configuration.ApiKey.TryGetValue(API_DEBUG, out string debug);

            bool.TryParse(debug, out var bdebug);

            if (string.IsNullOrEmpty(key)
                || string.IsNullOrEmpty(secret))
            {
                if (bdebug)
                {
                    request.AddHeader("ICN-MESSAGE", "API_KEY or API_SECRET missing");
                }
                return;
            }

            var uri = RestClient.BuildUri(request);
            string url = uri.AbsolutePath;

            Method method = request.Method;
            Parameter body = request.Parameters.FirstOrDefault(p => p.Type == ParameterType.RequestBody);
            string sbody = body == null ? string.Empty : body.Value.ToString();
            string message = $"{timestamp}{method}{url}{sbody}";

            string sign = Digest(secret, message);

            request.AddHeader("ICN-API-KEY", key);
            request.AddHeader("ICN-SIGN", sign);
            request.AddHeader("ICN-TIMESTAMP", timestamp.ToString());

            if (bdebug)
            {
                var bMessage = Encoding.UTF8.GetBytes(message);
                request.AddHeader("ICN-MESSAGE-B64", Convert.ToBase64String(bMessage));
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
