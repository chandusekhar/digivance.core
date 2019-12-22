namespace Digivance.Core.Models {
    /// <summary>
    /// UserProductPermission represents the access permission that has been granted by
    /// this UserAccount for this Product
    /// </summary>
    public class UserProductPermission : BaseModel {
        /// <summary>
        /// AuthPermissionScope is a reference to the scope of permissions this product has access
        /// to as this user
        /// </summary>
        public virtual AuthPermissionScope AuthPermissionScope { get; set; }

        /// <summary>
        /// AuthPermissionScopeID is the if od the scope of permissions this product has access
        /// to as this user
        /// </summary>
        public long AuthPermissionScopeID { get; set; }

        /// <summary>
        /// CanWrite signals if this permission requests access to write records to
        /// the provided scope read is always implied if there is an AuthProductPermission
        /// </summary>
        public bool CanWrite { get; set; }

        /// <summary>
        /// Product is a reference to the Product that this permission applies to
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// ProductID is the ID of the Product that this permission applies to
        /// </summary>
        public long ProductID { get; set; }

        /// <summary>
        /// UserAccount is a reference to the UserAccount that granted this permission
        /// </summary>
        public virtual UserAccount UserAccount { get; set; }

        /// <summary>
        /// UserAccountID is the id to the UserAccount that granted this permission
        /// </summary>
        public long UserAccountID { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public UserProductPermission() : base() { }
    }
}
