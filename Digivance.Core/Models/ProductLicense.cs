using System.Collections.Generic;

namespace Digivance.Core.Models {
    /// <summary>
    /// ProductLicense is a relational lexicon label that represents a general level of
    /// access to a specific product.
    /// </summary>
    public class ProductLicense : BaseModel {
        /// <summary>
        /// Description is the human friendly description of this license
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Name of this license (must be unique to Product)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Product that this license applies to
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// ProductID is the id o the related Product record
        /// </summary>
        public long ProductID { get; set; }

        /// <summary>
        /// UserProductRelations are all of the user owned product licenses
        /// </summary>
        public virtual ICollection<UserProductRelation> UserProductRelations { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductLicense() : base() { }
    }

}
