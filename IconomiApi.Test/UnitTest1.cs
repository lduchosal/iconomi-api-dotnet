using IconomiApi.Api;
using IconomiApi.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Security.Cryptography;
using System.Text;

namespace IconomiApi.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            string key = "b333333333333333333333333333333333333333333333333333333333333";
            string digest = "1618349576837GET/v1/user/balance";
            string expected = "D+whvhTJ+cLNI4ktLPz2STxJZaRf7a4VCrk7TcTrvIjAZAnxSWUuGhTQ3Gcjw+S1VOPj99eSHscDfNvBV0F/Iw==";
            
            var bkey = Encoding.UTF8.GetBytes(key);

            using (HMACSHA512 hmac = new HMACSHA512(bkey))
            {
                var bytes = Encoding.UTF8.GetBytes(digest);
                byte[] hash = hmac.ComputeHash(bytes);
                string b64 = Convert.ToBase64String(hash);
                Assert.AreEqual(expected, b64);
            }
        }

    }
}
