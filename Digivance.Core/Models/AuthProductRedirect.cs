namespace Digivance.Core.Models {
    /// <summary>
    /// AuthProductRedirect represents a redirect url for a product that uses the
    /// Digivance auth services. These records represent the redirect url's claiming
    /// to be this application can request the auth system send the access code.
    /// </summary>
    public class AuthProductRedirect : BaseModel {
        /// <summary>
        /// Name is an optional user friendly title for this redirect url
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Product is the reference to the Product record that this Auth Redirect
        /// belongs to.
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// ProductID is the id of the product record that this Auth Redirect record
        /// belongs to.
        /// </summary>
        public long ProductID { get; set; }

        /// <summary>
        /// Url is the web url that the client application is allowed to request the access
        /// code be directed to. Note the limit of this field is 255 characters and must be
        /// unique per product
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public AuthProductRedirect() : base() { }
    }
}
