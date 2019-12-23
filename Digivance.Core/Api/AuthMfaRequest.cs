using System;
using System.Collections.Generic;
using System.Text;

namespace Digivance.Core.Api {
    public class AuthMfaRequest {
        public string MfaCode { get; set; }

        public string SessionID { get; set; }

        public AuthMfaRequest() { }
    }
}
