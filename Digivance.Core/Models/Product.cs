﻿using System.Collections.Generic;

namespace Digivance.Core.Models {
    /// <summary>
    /// Product represents an application or service offering from Digivance Technologies
    /// </summary>
    public class Product : BaseModel {
        /// <summary>
        /// AuthProductRedirects is a reference to the currently white listed AuthProductRedirect
        /// records for this Product
        /// </summary>
        public virtual ICollection<AuthProductRedirect> AuthProductRedirects { get; set; }

        /// <summary>
        /// AuthBearerTokens is a reference to the currently assigned bearer tokens, eg users signed in
        /// </summary>
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
        /// Name of this product, must be unique
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// OwnerOrganization is a reference to the Organization record that owns this Product
        /// </summary>
        public virtual Organization OwnerOrganization { get; set; }

        /// <summary>
        /// OwnerOrganizationID is the id of the Organization record that owns this product
        /// </summary>
        public long OwnerOrganizationID { get; set; }

        /// <summary>
        /// ProductLicenses are the optional license types that are available for this product
        /// </summary>
        public virtual ICollection<ProductLicense> ProductLicenses { get; set; }

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