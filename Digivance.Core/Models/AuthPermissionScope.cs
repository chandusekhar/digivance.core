namespace Digivance.Core.Models {
    /// <summary>
    /// AuthPermission scope is used to provide a dictionary where the AuthProductPermission
    /// and UserProductPermission models' Scope field can be defined
    /// </summary>
    public class AuthPermissionScope : BaseModel {
        /// <summary>
        /// DisplayName is the user friendle name for what this scope means
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Name is the unique name id (such as user.profile, user.licenses, etc.)
        /// of this scope
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description is the user friendly description for what this scope provides
        /// access to and why applications may request this scope.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public AuthPermissionScope() : base() { }
    }
}
