using System;
using System.Collections.Generic;
using System.Text;

namespace Digivance.Core.Api {
    public enum AuthStep {
        Credentials     = 0,
        Mfa             = 1,
        Permissions     = 2
    }

    public class AuthResponse {
        public string AppName { get; set; }

        public string AppPermissionRequest { get; set; }

        public string SessionID { get; set; }

        public AuthStep Step { get; set; }

        public AuthResponse() { }
    }
}
