using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JsonCommsTutorial.Services
{
    class RestService : IRestService
    {
        private readonly HttpClient _httpClient;
        private readonly string _host;

        public RestService(HttpClient httpClient, string baseUrl)
        {
            _httpClient = httpClient;
            _host = baseUrl;
        }

        public async Task<TResponse> GetAsync<TResponse>(string path)
        {
            string uri = Path.Combine(_host, path);

            HttpResponseMessage response = await _httpClient.GetAsync(uri);

            if (response.IsSuccessStatusCode == true)
            {
                string rawData = await response.Content.ReadAsStringAsync();

                // Turn our JSON string into a csharp object (or object-graph)
                var result = JsonConvert.DeserializeObject<TResponse>(rawData);

                // Return a response of type TResult.
                return result;
            }
            else
            {
                // TODO: Returning null to signify failure is lazy. We'll show how to return a Tuple with any useful failure-reason in a later tutorial.
                return default;      // This is a safe way to specify null when using unconstrained generic parameters.
            }
        }

        public async Task<TResponse> PostAsync<TRequest, TResponse>(TRequest request, string path)
        {
            string uri = Path.Combine(_host, path);

            string json = JsonConvert.SerializeObject(request);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            // JSON, API v2.
            data.Headers.Add("Accept", "application/json; v=2.0");

            HttpResponseMessage response = await _httpClient.PostAsync(uri, data);

            if (response.IsSuccessStatusCode == true)
            {
                string rawData = await response.Content.ReadAsStringAsync();

                // Turn our JSON string into a csharp object (or object-graph)
                TResponse result = JsonConvert.DeserializeObject<TResponse>(rawData);

                // Return a response of type TResult.
                return result;
            }
            else
            {
                // TODO: Returning null to signify failure is lazy. We'll show how to return a Tuple with any useful failure-reason in a later tutorial.
                return default;      // This is a safe way to specify null when using unconstrained generic parameters.
            }
        }
    }
}