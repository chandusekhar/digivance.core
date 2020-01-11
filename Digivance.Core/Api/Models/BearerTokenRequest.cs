namespace Digivance.Core.Api.Models {
    public class BearerTokenRequest {
        public string AccessCode { get; set; }

        public string ClientSecretKey { get; set; }

        public BearerTokenRequest() { }
    }
}
