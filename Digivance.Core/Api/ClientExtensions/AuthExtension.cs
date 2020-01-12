using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using Digivance.Core.Api.Models;
using Digivance.Core.Models;

using Newtonsoft.Json;

namespace Digivance.Core.Api {
    /// <summary>
    /// AuthExtensions extend Digivance Auth api methods
    /// </summary>
    public static class AuthExtension {
        /// <summary>
        /// GetCurrentUser will return the currently signed in user. Expects that BearerToken
        /// is set (which creates the cookie that will make this work)
        /// </summary>
        /// <param name="client">DigivanceClient</param>
        /// <returns>UserAccount</returns>
        public async static Task<UserAccount> GetCurrentUser(this DigivanceClient client) {
            HttpResponseMessage response = await client.GetAsync($"{client.BaseAddress}/auth/currentuser");
            if (response.StatusCode != HttpStatusCode.OK) {
                return null;
            }

            string payload = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<UserAccount>(payload);
        }

        /// <summary>
        /// GetBearerToken will swap the provided accessCode and clientSecretKey for a bearer token.
        /// The bearer token is essentially the session id for the caller on behalf of the user who 
        /// produced this access code.
        /// </summary>
        /// <param name="client">DigivanceClient</param>
        /// <param name="accessCode">The access_code returned from Digivance auth process</param>
        /// <param name="clientSecretKey">Your product's clientSecretKey</param>
        /// <returns>The bearer token that can be used to call functions on behalf of this user</returns>
        public async static Task<string> GetBearerToken(this DigivanceClient client, string accessCode, string clientSecretKey) {
            BearerTokenRequest bearerTokenRequest = new BearerTokenRequest {
                AccessCode = accessCode,
                ClientSecretKey = clientSecretKey
            };

            HttpResponseMessage response = await client.PostAsJsonAsync($"{client.BaseAddress}/auth/bearertoken", bearerTokenRequest);
            if (response.StatusCode != HttpStatusCode.OK) {
                string payload = await response.Content.ReadAsStringAsync();
                ErrorResponse res = JsonConvert.DeserializeObject<ErrorResponse>(payload);

                throw new Exception(res.Message);
            }

            client.BearerToken = client.GetCookie("BearerToken");
            return client.BearerToken;
        }
    }
}
