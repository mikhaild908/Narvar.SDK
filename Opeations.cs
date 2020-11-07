using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using Narvar.SDK.Models;

namespace Narvar.SDK
{
    public class Operations
    {
        private readonly string _apiBaseUrl;
        private readonly byte[] _usernamePasswordByteArray;

        public Operations(string apiBaseUrl, string username, string password)
        {
            _apiBaseUrl = apiBaseUrl;
            _usernamePasswordByteArray = Encoding.ASCII.GetBytes($"{username}:{password}");
        }

        public async Task<NarvarResponse> GetOrderAsync(string orderNumber)
        {
            using var client = GetHttpClient();

            var getOrderTask = client.GetStreamAsync($"{_apiBaseUrl}/orders/{orderNumber}");

            return await JsonSerializer.DeserializeAsync<NarvarResponse>(await getOrderTask);
        }

        public async Task<HttpStatusCode> PostOrderAsync(Root root)
        {
            var jsonContent = JsonSerializer.Serialize(root);

            using var client = GetHttpClient();
            using var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            using var response = await client.PostAsync($"{_apiBaseUrl}/orders", httpContent);

            var message = response.EnsureSuccessStatusCode();

            return message.StatusCode;
        }

        private HttpClient GetHttpClient()
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(_usernamePasswordByteArray));

            return client;
        }
    }
}