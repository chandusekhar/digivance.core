namespace Digivance.Core.Models {
    /// <summary>
    /// OrganizationUserRelation represents a UserAccount's relation to an Organization as a specific
    /// role. A user account may have multiple relations to the same Organization with different roles
    /// but not multiple records of the same Organization, UserAccount and OrganizationUserRole.
    /// </summary>
    public class OrganizationUserRelation : BaseModel {
        /// <summary>
        /// Organization that this relation applies to
        /// </summary>
        public virtual Organization Organization { get; set; }

        /// <summary>
        /// OrganizationID is the id of the Organization record this relation applies to
        /// </summary>
        public long OrganizationID { get; set; }

        /// <summary>
        /// OrganizationUserRole that this relation specifies
        /// </summary>
        public virtual OrganizationUserRole OrganizationUserRole { get; set; }

        /// <summary>
        /// OrganizationUserRoleID is the id of the OrganizationUserRole record this relation specifies
        /// </summary>
        public long OrganizationUserRoleID { get; set; }

        /// <summary>
        /// UserAccount that this relation applies to
        /// </summary>
        public virtual UserAccount UserAccount { get; set; }

        /// <summary>
        /// UserAccountID is the id of the UserAccount record that this relation applies to
        /// </summary>
        public long UserAccountID { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public OrganizationUserRelation() : base() { }
    }
}
