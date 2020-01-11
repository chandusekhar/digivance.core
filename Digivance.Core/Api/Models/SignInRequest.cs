using System;
using System.Collections.Generic;
using System.Text;

namespace Digivance.Core.Api.Models {
    public class SignInRequest {
        public string SessionID { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public SignInRequest() { }
    }
}
