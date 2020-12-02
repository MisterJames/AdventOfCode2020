using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    public class InputLoader
    {
        private readonly HttpClient _client;

        public InputLoader(CookieSettings settings)
        {
            var baseAddress = new Uri("https://adventofcode.com");
            var cookieContainer = new CookieContainer();
            var handler = new HttpClientHandler() { CookieContainer = cookieContainer };

            _client = new HttpClient(handler) { BaseAddress = baseAddress };
            cookieContainer.Add(baseAddress, new Cookie("_ga", settings.Ga));
            cookieContainer.Add(baseAddress, new Cookie("_gid", settings.Gid));
            cookieContainer.Add(baseAddress, new Cookie("session", settings.Session));

        }

        public async Task<string> Download(string uri)
        {
            string result = string.Empty;

            try
            {
                result = await _client.GetStringAsync(uri);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Message :{0} ", e.Message);
            }

            return result;
        }
    }
}
