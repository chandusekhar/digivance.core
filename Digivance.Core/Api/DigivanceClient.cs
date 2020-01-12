using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Digivance.Core.Api {
    /// <summary>
    /// DigivanceClient is a custom implementation of the HttpClient that you can use
    /// to easily invoke calls to the Digivance platform API's.
    /// </summary>
    public class DigivanceClient : HttpClient {
        /// <summary>
        /// mBearerToken is used internally, never read or write this directly
        /// </summary>
        protected string mBearerToken { get; set; }

        /// <summary>
        /// This is where you get / set the bearer code for all api calls. Set once 
        /// per instance of DigivanceClient
        /// </summary>
        public string BearerToken {
            get {
                return mBearerToken;
            }

            set {
                Cookies.Add(new Cookie {
                    Domain = "admin.digivance.com",
                    Expires = DateTime.UtcNow.AddDays(1),
                    Name = "BearerToken",
                    Path = "/",
                    Secure = true,
                    Value = value
                });

                mBearerToken = value;
            }
        }

        /// <summary>
        /// Cookies is the CookieContainer that is used both for sending and receiving
        /// cookies.
        /// </summary>
        public CookieContainer Cookies { get; set; }

        /// <summary>
        /// Standard constructor
        /// </summary>
        /// <param name="handler">The handler containing our Cookies container</param>
        public DigivanceClient(HttpClientHandler handler) : base(handler) { }

        /// <summary>
        /// Create will instantiate the necessary Cookies container, handler and underlying
        /// HttpClient. Returns a ready to use DigivanceClient, just set your bearer token
        /// and start calling ClientExtension methods
        /// </summary>
        /// <returns>DigivanceClient</returns>
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

        /// <summary>
        /// GetCookie returns the value of the requested cookie. Note there is no
        /// difference between client side and server side cookies in DigivanceClient
        /// </summary>
        /// <param name="name">The name of the cookie to get value of</param>
        /// <returns>Value of the cookie if found</returns>
        public string GetCookie(string name) {
            var uri = new Uri($"https://{BaseAddress.Host}");

            return Cookies.GetCookies(uri)?[name]?.Value;
        }
    }
}
