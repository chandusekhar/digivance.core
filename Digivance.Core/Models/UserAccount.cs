﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using Newtonsoft.Json;

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
        [JsonIgnore]
        public virtual ICollection<UserProductRelation> AppliedProductLicenses { get; set; }

        /// <summary>
        /// AuthBearerTokens is a reference to the BearerTokens currently applied to this user account
        /// (E.g. all the products they are signed in to)
        /// </summary>
        [JsonIgnore]
        public virtual ICollection<AuthBearerToken> AuthBearerTokens { get; set; }

        /// <summary>
        /// AuthTransactions is a reference to the AuthTransactions currently in progress for this
        /// user account
        /// </summary>
        [JsonIgnore]
        public virtual ICollection<AuthTransaction> AuthTransactions { get; set; }

        /// <summary>
        /// FailedLoginAttempts gets used by the auth system to lockout an account when a brute force
        /// attack is detected. (E.g. more than 3 failed attempts and the account will lock for x minutes)
        /// </summary>
        [JsonIgnore]
        public int FailedLoginAttempts { get; set; }

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
        /// EmailVerificationCode is set when IsEmailVerified is false (E.g. during account
        /// registration or if we allow users to change their email address). Sign in should
        /// block on this after checking credentials.
        /// </summary>
        [JsonIgnore]
        public string EmailVerificationCode { get; set; }

        /// <summary>
        /// FirstName of this user
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// IsEmailVerified defines if this user has verified their email address yet
        /// </summary>
        public bool IsEmailVerified { get; set; }

        /// <summary>
        /// LastName of this user
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// MfaSecret is the unique secret key to use when generating / validating
        /// One Time Passwords (OTP codes such as with Google Authenticator)
        /// </summary>
        [JsonIgnore]
        public string MfaSecret { get; set; }

        /// <summary>
        /// OrganizationUserRelations is the optional collection of relations this user has
        /// to Organizations
        /// </summary>
        [JsonIgnore]
        public virtual ICollection<OrganizationUserRelation> OrganizationUserRelations { get; set; }

        /// <summary>
        /// OwnedProductLicenses is the optional collection of UserProductRelations that this user
        /// account owns (e.g. pays for?)
        /// </summary>
        [JsonIgnore]
        public virtual ICollection<UserProductRelation> OwnedProductLicenses { get; set; }

        /// <summary>
        /// UserAccountLockouts is the optional collection of UserAccountLockout records for this user
        /// account. Auth system should halt the login process for users with user account lockouts
        /// </summary>
        [JsonIgnore]
        public virtual ICollection<UserAccountLockout> UserAccountLockouts { get; set; }

        /// <summary>
        /// UserProductPermissions is the optional collection of UserProductPermissions that this user
        /// has granted.
        /// </summary>
        [JsonIgnore]
        public virtual ICollection<UserProductPermission> UserProductPermissions { get; set; }

        /// <summary>
        /// PasswordHash is the encrypted and hashed password for this user account
        /// </summary>
        [JsonIgnore]
        public string PasswordHash { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public UserAccount() : base() { }
    }
}
