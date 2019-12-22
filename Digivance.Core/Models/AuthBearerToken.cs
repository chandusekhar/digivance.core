using System;

namespace Digivance.Core.Models {
    /// <summary>
    /// AuthBearerToken represents a user session, or a cient applications session
    /// as a user.
    /// </summary>
    public class AuthBearerToken : BaseModel {
        /// <summary>
        /// Code is the unique code that our caller can provide to perform actions
        /// on behalf of a user
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// ExpirationDate is the UTC DateTime when we should no longer allow this
        /// BearerToken to access content or services
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Product is a reference to the product that the user signed in and granted
        /// permissions to (e.g. the client application)
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// ProductID is the id of the product that the user signed in and granted
        /// permissions to
        /// </summary>
        public long? ProductID { get; set; }

        /// <summary>
        /// UserAccount is a reference to the UserAccount that signed in to the Product
        /// </summary>
        public virtual UserAccount UserAccount { get; set; }

        /// <summary>
        /// UserAccountID is the id of the UserAccount that signed in to the Product
        /// </summary>
        public long UserAccountID { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public AuthBearerToken() : base() {
            ExpirationDate = DateTime.UtcNow.AddDays(1);
        }
    }
}
