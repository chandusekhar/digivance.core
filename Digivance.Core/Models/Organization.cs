using System.Collections.Generic;

namespace Digivance.Core.Models {
    /// <summary>
    /// Organization represents a company, or non profit organization (perhaps even a start up team,
    /// an organization is not necessarily a registered business entity)
    /// </summary>
    public class Organization : BaseModel {
        /// <summary>
        /// ChildOrganizations is the optional collection of Organizations where this Organization
        /// is the parent.
        /// </summary>
        public virtual ICollection<Organization> ChildOrganizations { get; set; }

        /// <summary>
        /// Description of this organization to show in indexes / organization profiles
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Name of this organization, must be unique per ParentOrganizationID
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// OrganizationUserRelations represents the UserAccount to Organization relationship
        /// </summary>
        public virtual ICollection<OrganizationUserRelation> OrganizationUserRelations { get; set; }

        /// <summary>
        /// OrganizationUserRoles represents this organization's custom roles
        /// </summary>
        public virtual ICollection<OrganizationUserRole> OrganizationUserRoles { get; set; }

        /// <summary>
        /// ParentOrganization is a reference to the Organization that contains this Organization
        /// as a ChildOrganizations element
        /// </summary>
        public virtual Organization ParentOrganization { get; set; }

        /// <summary>
        /// ParentOrganizationID is the relational ID to this organization's parent record
        /// </summary>
        public long? ParentOrganizationID { get; set; }

        /// <summary>
        /// Products owned by this organization
        /// </summary>
        public virtual ICollection<Product> Products { get; set; }

        /// <summary>
        /// OwnedProductLicenses is the optional collection of UserProductRelation records
        /// (or product licenses) that this organization owns.
        /// </summary>
        public virtual ICollection<UserProductRelation> OwnedProductLicenses { get; set; }

        /// <summary>
        /// WebUrl is the https web address to this organization's external home page
        /// </summary>
        public string WebUrl { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Organization() : base() { }
    }
}
