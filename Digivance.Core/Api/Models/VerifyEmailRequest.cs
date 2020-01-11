namespace Digivance.Core.Api.Models {
    /// <summary>
    /// VerifyEmailRequest is used during auth sign in to provide the email verification
    /// code and a session id to verify the user's email address
    /// </summary>
    public class VerifyEmailRequest {
        /// <summary>
        /// Code should be the 6 digit code sent in email
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// SessionID should be the login session ID that we are verifying for
        /// </summary>
        public string SessionID { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public VerifyEmailRequest() { }
    }
}
