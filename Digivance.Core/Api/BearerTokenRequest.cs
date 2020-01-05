namespace Digivance.Core.Api {
    public class BearerTokenRequest {
        public string AccessCode { get; set; }

        public string ClientSecretKey { get; set; }

        public BearerTokenRequest() { }
    }
}
