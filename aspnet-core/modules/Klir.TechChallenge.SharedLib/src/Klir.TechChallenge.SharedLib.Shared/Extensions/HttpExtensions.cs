using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Klir.TechChallenge.SharedLib.Shared.Extensions
{
    public static class HttpExtensions
    {
        public static Task<HttpResponseMessage> PostAsJsonAsync<T>(this HttpClient httpClient, string url, T data)
        {
            var dataAsString = JsonSerializer.Serialize(data);
            return httpClient.PostAsJsonStringAsync(url, dataAsString);
        }

        public static Task<HttpResponseMessage> PostAsJsonStringAsync(this HttpClient httpClient, string url, string data)
        {
            var content = new StringContent(data);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return httpClient.PostAsync(url, content);
        }

        public static Task<HttpResponseMessage> PutAsJsonAsync<T>(this HttpClient httpClient, string url, T data)
        {
            var dataAsString = JsonSerializer.Serialize(data);
            return httpClient.PutAsJsonStringAsync(url, dataAsString);
        }

        public static Task<HttpResponseMessage> PutAsJsonStringAsync(this HttpClient httpClient, string url, string data)
        {
            var content = new StringContent(data);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return httpClient.PutAsync(url, content);
        }

        public static async Task<T> ReadAsJsonAsync<T>(this HttpClient client, string url)
        {
            var dataAsString = await client.ReadAsStringAsync(url);

            return JsonSerializer.Deserialize<T>(dataAsString);
        }

        public static async Task<string> ReadAsStringAsync(this HttpClient client, string url)
        {
            var result = await client.GetAsync(url);
            return await result.Content.ReadAsStringAsync();

        }
    }
}
