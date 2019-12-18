using System;

namespace Digivance.Core.Models {
    public class AuthTransaction : BaseModel {
        /// <summary>
        /// ClientApplicationID is the hashed public key representing a Product
        /// </summary>
        public string ClientApplicationID { get; set; }

        /// <summary>
        /// ExpirationDate is the UTC Date Time when we should no longer allow this
        /// auth transaction to sign in (too long of delay between caller directing
        /// to auth system and when user entered credentials)
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// RedirectUrl is the url the caller is asking the access code to be
        /// directed to upon successful sign in & permission granting
        /// </summary>
        public string RedirectUrl { get; set; }

        /// <summary>
        /// SessionID is used by the auth system to validate form submission against a
        /// particular AuthTransaction. (E.g. is the key given to the browser to return
        /// with credentials submitted for this transaction)
        /// </summary>
        public string SessionID { get; set; }

        /// <summary>
        /// State is whatever url encoded data the caller is asking us to pass
        /// back upon successful sign in & permission granting (E.g. caller's state)
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public AuthTransaction() : base() {
            ExpirationDate = DateTime.UtcNow.AddMinutes(30);
        }
    }
}
