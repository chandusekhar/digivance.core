using System.Collections.Generic;

using Newtonsoft.Json;

namespace Digivance.Core.Models {
    /// <summary>
    /// Product represents an application or service offering from Digivance Technologies
    /// </summary>
    public class Product : BaseModel {
        /// <summary>
        /// AuthAccessToken is a reference to the auth access tokens pending final sign in for
        /// this product
        /// </summary>
        [JsonIgnore]
        public virtual ICollection<AuthAccessToken> AuthAccessTokens { get; set; }

        /// <summary>
        /// AuthProductPermissions is a reference to the permission access this product needs
        /// to a user's Digivance account
        /// </summary>
        [JsonIgnore]
        public virtual ICollection<AuthProductPermission> AuthProductPermissions { get; set; }

        /// <summary>
        /// AuthProductRedirects is a reference to the currently white listed AuthProductRedirect
        /// records for this Product
        /// </summary>
        [JsonIgnore]
        public virtual ICollection<AuthProductRedirect> AuthProductRedirects { get; set; }

        /// <summary>
        /// AuthBearerTokens is a reference to the currently assigned bearer tokens, eg users signed in
        /// </summary>
        [JsonIgnore]
        public virtual ICollection<AuthBearerToken> AuthBearerTokens { get; set; }

        /// <summary>
        /// ClientApplicationID is a unique string used as the public client application id
        /// in auth systems
        /// </summary>
        public string ClientApplicationID { get; set; }

        /// <summary>
        /// ClientSecretKey is the unique string used as the private client application
        /// secret in auth systems
        /// </summary>
        public string ClientSecretKey { get; set; }

        /// <summary>
        /// Description is the human friendly description of this service to use in catalogs
        /// and product profiles
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// IconImageFilename is the path to the image file that should be used as the icon
        /// for this product.
        /// </summary>
        public string IconImageFilename { get; set; }

        /// <summary>
        /// IsActive defines if this product is currently active (for sale & supported)
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// IsFeatured defines if this product is featured such as on the home page, or the
        /// products index page.
        /// </summary>
        public bool IsFeatured { get; set; }

        /// <summary>
        /// Name of this product, must be unique
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// OwnerOrganization is a reference to the Organization record that owns this Product
        /// </summary>
        [JsonIgnore]
        public virtual Organization OwnerOrganization { get; set; }

        /// <summary>
        /// OwnerOrganizationID is the id of the Organization record that owns this product
        /// </summary>
        public long OwnerOrganizationID { get; set; }

        /// <summary>
        /// ProductLicenses are the optional license types that are available for this product
        /// </summary>
        [JsonIgnore]
        public virtual ICollection<ProductLicense> ProductLicenses { get; set; }

        /// <summary>
        /// UserProductPermissions are the optional UserProductPermissions granted by users for
        /// this product
        /// </summary>
        [JsonIgnore]
        public virtual ICollection<UserProductPermission> UserProductPermissions { get; set; }

        /// <summary>
        /// WebUrl is the https web address to this products landing page
        /// </summary>
        public string WebUrl { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Product() : base() { }
    }
}
