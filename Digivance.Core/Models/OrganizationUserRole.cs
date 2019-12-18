using System.Collections.Generic;

namespace Digivance.Core.Models {
    /// <summary>
    /// OrganizationUserRole is a relational lexicon label representing what Role based
    /// access should be granted to an OrganizationUserRelation record.
    /// </summary>
    public class OrganizationUserRole : BaseModel {
        /// <summary>
        /// Description is the human friendly description of what this role entails
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Name of this role (must be unique per Organization)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Organization is the reference to the organization that this role applies to. 
        /// (Can be Public meaning any organization can use this role)
        /// </summary>
        public virtual Organization Organization { get; set; }

        /// <summary>
        /// OrganizationID is the relational ID of the Organization that this role applies to
        /// </summary>
        public long OrganizationID { get; set; }

        /// <summary>
        /// OrganizationUserRelations is the optional collection of OrganizationUserRelations that
        /// use this role
        /// </summary>
        public virtual ICollection<OrganizationUserRelation> OrganizationUserRelations { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public OrganizationUserRole() : base() { }
    }
}
