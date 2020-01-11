namespace Digivance.Core.Api.Models {
    /// <summary>
    /// RegisterAccountRequest is used to submit email address and password to
    /// create a new User Account with
    /// </summary>
    public class RegisterAccountRequest {
        /// <summary>
        /// EmailAddress to register
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Password to use
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// ClientApplicationID of the Product that we are registering from (if applicable)
        /// </summary>
        public string ClientApplicationID { get; set; }

        /// <summary>
        /// ConfirmPassword you know, of password
        /// </summary>
        public string ConfirmPassword { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public RegisterAccountRequest() { }
    }
}
