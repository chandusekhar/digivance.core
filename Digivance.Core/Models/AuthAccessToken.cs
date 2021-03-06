﻿using System;

namespace Digivance.Core.Models {
    /// <summary>
    /// AuthAccessToken represents the code given to the calling application via the
    /// redirect url, the calling application should exchange this token for a bearer
    /// token, the bearer token will allow the caller to perform actions on behalf of
    /// the user who signed in.
    /// </summary>
    public class AuthAccessToken : BaseModel {
        /// <summary>
        /// AccessCode was a random hashed string generated when the user signed
        /// in and granted permissions to this client application
        /// </summary>
        public string AccessCode { get; set; }

        /// <summary>
        /// ExpirationDate is when we should no longer allow the calling application
        /// to exchange this token for a bearer token (because the delay between user
        /// signing in and application trying to finish the transaction was too long)
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Product is a reference to the optional product that is authorized to exchange 
        /// this access token for a bearer token. (Null meaning it only applies to the
        /// Digivance Platform itself)
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// ProductID is the id of the product that may exchange this token
        /// </summary>
        public long? ProductID { get; set; }

        /// <summary>
        /// UserAccount is the reference to the user account that signed in and granted 
        /// permissions to the Product
        /// </summary>
        public virtual UserAccount UserAccount { get; set; }

        /// <summary>
        /// UserAccountID is the id of the UserAccount that this access code applies to
        /// </summary>
        public long UserAccountID { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public AuthAccessToken() : base() {
            ExpirationDate = DateTime.UtcNow.AddMinutes(30);
        }
    }
}
