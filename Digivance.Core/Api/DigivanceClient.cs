using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Digivance.Core.Api {
    public class DigivanceClient : HttpClient {
        public CookieContainer Cookies { get; set; }

        public DigivanceClient(HttpClientHandler handler) : base(handler) { }

        public static DigivanceClient Create() {
            var clientHandler = new HttpClientHandler();
            var cookies = new CookieContainer();

            clientHandler.CookieContainer = cookies;

            DigivanceClient client = new DigivanceClient(clientHandler) {
                BaseAddress = new Uri("https://admin.digivance.com/api/beta"),
                Cookies = cookies
            };

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }

        public string GetCookie(string name) {
            var uri = new Uri($"https://{BaseAddress.Host}");

            return Cookies.GetCookies(uri)?[name]?.Value;
        }
    }
}
