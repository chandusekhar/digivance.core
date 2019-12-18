using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Digivance.Core.Models {
    /// <summary>
    /// UserAccount represents a credential set and basic user profile with access to
    /// Digivance products and services
    /// </summary>
    public class UserAccount : BaseModel {
        /// <summary>
        /// AppliedProductLicenses is a reference of the licenses applied to (or assigned to) this 
        /// user account. (E.g. the ones that actually provide access to stuff)
        /// </summary>
        public virtual ICollection<UserProductRelation> AppliedProductLicenses { get; set; }

        /// <summary>
        /// AuthBearerTokens is a reference to the BearerTokens currently applied to this user account
        /// (E.g. all the products they are signed in to)
        /// </summary>
        public virtual ICollection<AuthBearerToken> AuthBearerTokens { get; set; }

        /// <summary>
        /// DisplayName returns friendly version of this User Account's first name and last name
        /// </summary>
        [NotMapped]
        public string DisplayName { get { return ($"{FirstName} {LastName}").Trim(); } }

        /// <summary>
        /// Email is the primary email address that this user account is assigned to
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// FirstName of this user
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// LastName of this user
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// MfaSecret is the unique secret key to use when generating / validating
        /// One Time Passwords (OTP codes such as with Google Authenticator)
        /// </summary>
        public string MfaSecret { get; set; }

        /// <summary>
        /// OrganizationUserRelations is the optional collection of relations this user has
        /// to Organizations
        /// </summary>
        public virtual ICollection<OrganizationUserRelation> OrganizationUserRelations { get; set; }

        /// <summary>
        /// OwnedProductLicenses is the optional collection of UserProductRelations that this user
        /// account owns (e.g. pays for?)
        /// </summary>
        public virtual ICollection<UserProductRelation> OwnedProductLicenses { get; set; }

        /// <summary>
        /// PasswordHash is the encrypted and hashed password for this user account
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public UserAccount() : base() { }
    }
}
