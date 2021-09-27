using JsonCommsTutorial.Constants;
using JsonCommsTutorial.Models;
using JsonCommsTutorial.Services;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace JsonCommsTutorial
{
    class Program
    {
        private static RestService _restService;

        static void Main(string[] args)
        {
#if false
            Console.WriteLine("Hello World!");

            var server = new DummyServer();
            var client = new DummyClient(server);

            var requestModel = new ZombieDataRequestModel("Liverpool", 2);

            ZombieDataResponseModel result = client.MakeRequest(requestModel);

            // TODO: Look at result.

#else
            var httpClient = new HttpClient();
            // TODO: Configure the client.

            // JSON, API v2.
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json; v=2.0");

            _restService = new RestService(httpClient, ApiConstants.BaseApiUrl);

            string platform = "Android";
            string version = "4.5.0";

            StartupCheckResponse result = StartupCheckAsync(platform, version).Result;

            // TODO: look at the result!
            if (result.CanProceed == true)
            {
                Console.WriteLine("The app is allowed to proceed!");
            }
            else
            {
                Console.WriteLine("YOU SHALL NOT PASS!");
            }
#endif
        }

        /// <summary>
        /// This method
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public static async Task<StartupCheckResponse> StartupCheckAsync(string platform, string version)
        {
            var response = await _restService.GetAsync<StartupCheckResponse>($"api/AppSettings/AppVersionStartupCheck?Platform={platform}&CurrentVersion={version}");
            return response;
        }
    }
}
