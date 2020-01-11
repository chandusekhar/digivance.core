using System;
using System.Collections.Generic;
using System.Text;

namespace Digivance.Core.Api.Models {
    public enum AuthStep {
        Credentials         = 0,
        EmailVerification   = 1,
        Mfa                 = 2,
        Permissions         = 3,
        Redirect            = 4
    }

    public class AuthResponse {
        public string AppName { get; set; }

        public string AppPermissionRequest { get; set; }

        public string RedirectUrl { get; set; }

        public string SessionID { get; set; }

        public AuthStep Step { get; set; }

        public AuthResponse() { }
    }
}
