using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Digivance.Core.Api.Models;
using Digivance.Core.Models;

using Newtonsoft.Json;

namespace Digivance.Core.Api {
    public static class AuthExtension {
        public async static Task<UserAccount> GetCurrentUser(this DigivanceClient client) {
            HttpResponseMessage response = await client.GetAsync($"{client.BaseAddress}/auth/currentuser");
            if (response.StatusCode != HttpStatusCode.OK) {
                return null;
            }

            string payload = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<UserAccount>(payload);
        }

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
