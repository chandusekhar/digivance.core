namespace Digivance.Core.Models {
    /// <summary>
    /// AuthProductPermission represents the access permissions that a Product requests
    /// of the user's Digivance account.
    /// </summary>
    public class AuthProductPermission : BaseModel {
        /// <summary>
        /// AuthPermissionScope is a reference to the scope of permissions this product requests
        /// </summary>
        public virtual AuthPermissionScope AuthPermissionScope { get; set; }

        /// <summary>
        /// AuthPermissionScopeID is the if od the scope of permissions this product requests
        /// </summary>
        public long AuthPermissionScopeID { get; set; }

        /// <summary>
        /// CanWrite signals if this permission requests access to write records to
        /// the provided scope read is always implied if there is an AuthProductPermission
        /// </summary>
        public bool CanWrite { get; set; }

        /// <summary>
        /// Product is a reference to the Product that owns this AuthProductPermission
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// ProductID is the unique ID of the Product that owns this AuthProductPermission
        /// </summary>
        public long ProductID { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public AuthProductPermission() : base() { }
    }
}
