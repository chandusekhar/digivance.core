﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Digivance.Core.Api {
    public class ResendNewUserEmailRequest {
        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public ResendNewUserEmailRequest() { }
    }
}
