using IconomiApi.Api;
using IconomiApi.Client;
using IconomiApi.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IconomiApi.Test
{
    [TestClass]
    public class UnitTest1
    {

        string API_KEY = "b333333333333333333333333333333333333333333333333333333333333";
        string API_SECRET = "b333333333333333333333333333333333333333333333333333333333333";
        bool API_DEBUG = true;
        string TICKER = "TICKER";

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

        [TestMethod]
        public async Task TestStrategy()
        {

            var api = new StrategiesApi();
            api.Configuration.ApiClient.SetAuthentication(API_KEY, API_SECRET, API_DEBUG);
            api.Configuration.ApiClient.RestClient.Timeout = TimeSpan.FromSeconds(5);

            try
            {
                var result = api.Structure(TICKER);
                var j = JsonConvert.SerializeObject(result);
                Console.WriteLine(j);
            }
            catch (ApiException e)
            {
                Assert.Fail(e.ToString());
            }
        }



        [TestMethod]
        public async Task TestListStrategies()
        {

            var strategies = new StrategiesApi();
            strategies.Configuration.ApiClient.RestClient.Timeout = TimeSpan.FromSeconds(5);

            var result = strategies.StrategyList();
            foreach (var strategy in result)
            {
                var j = JsonConvert.SerializeObject(strategy);
                Console.WriteLine("Name : {0}", strategy.Name);
                Console.WriteLine(j);
            }
        }


        [TestMethod]
        public async Task TestStrategy_SubmitStructure()
        {

            var api = new StrategiesApi();
            api.Configuration.ApiClient.SetAuthentication(API_KEY, API_SECRET, API_DEBUG);
            api.Configuration.ApiClient.RestClient.Timeout = TimeSpan.FromSeconds(5);

            string ticker = TICKER;
            try
            {
                var body = new StructureSubmit
                {
                    SpeedType = StructureSubmit.SpeedTypeEnum.SLOW,
                    Ticker = ticker,
                    Values = new List<SubmitStructureElement>
                    {
                        new()
                        {
                            AssetTicker = "ETH",
                            RebalancedWeight = 0.45M,

                        },
                        new()
                        {
                            AssetTicker = "BTC",
                            RebalancedWeight = 0.55M,

                        },
                    }
                };
                var result = api.SubmitStructure(ticker, body);
                var j = JsonConvert.SerializeObject(result);
                Console.WriteLine(j);
            }
            catch (ApiException e)
            {
                Assert.Fail(e.ToString());
            }
        }




        [TestMethod]
        public async Task TestStrategy_Structure()
        {

            var api = new StrategiesApi();
            api.Configuration.ApiClient.SetAuthentication(API_KEY, API_SECRET, API_DEBUG);
            api.Configuration.ApiClient.RestClient.Timeout = TimeSpan.FromSeconds(5);

            string ticker = TICKER;
            try
            { 
                var result = api.Structure(ticker);
                var j = JsonConvert.SerializeObject(result);
                Console.WriteLine(j);
            }
            catch (ApiException e)
            {
                Assert.Fail(e.ToString());
            }
        }



    }
}
