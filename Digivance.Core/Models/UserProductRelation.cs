using System;

namespace Digivance.Core.Models {
    /// <summary>
    /// UserProductRelation defines a user's license to use a product. Each UserProductRelation defines the
    /// UserAccount this product license is applied to and the UserAccount or Organization that owns the
    /// relation (or Product License)
    /// </summary>
    public class UserProductRelation : BaseModel {
        /// <summary>
        /// AppliedTo is the optional UserAccount this license is applied to
        /// </summary>
        public virtual UserAccount AppliedTo { get; set; }

        /// <summary>
        /// AppliedToID is the ID of the UserAccount this license is applied to
        /// </summary>
        public long? AppliedToID { get; set; }

        /// <summary>
        /// ExpirationDate is when this user product relation expires. Default is one month and
        /// one day after UtcNow, billing system will update these further into the future.
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// OwnerOrganization is the optional Organization that owns this product license. Note if
        /// this is null there should be an OwnerUserAccount. If both are null this is an orphaned
        /// product license and should be removed
        /// </summary>
        public virtual Organization OwnerOrganization { get; set; }

        /// <summary>
        /// OwnerOrganizationID is the ID of the Organization that owns this product license
        /// </summary>
        public long? OwnerOrganizationID { get; set; }

        /// <summary>
        /// OwnerUserAccount is the optional UserAccount that owns this product license. Note if
        /// this is null there should be an OwnerOrganization. If both are null this is an orphaned
        /// product license and should be removed
        /// </summary>
        public virtual UserAccount OwnerUserAccount { get; set; }

        /// <summary>
        /// OwnerUserAccountID is the id of the UserAccount that owns this product license
        /// </summary>
        public long? OwnerUserAccountID { get; set; }

        /// <summary>
        /// ProductLicense specifies what product license this relation provides
        /// </summary>
        public virtual ProductLicense ProductLicense { get; set; }

        /// <summary>
        /// ProductLicenseID is the id of the ProductLicense this relation provides
        /// </summary>
        public long ProductLicenseID { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public UserProductRelation() : base() {
            ExpirationDate = DateTime.UtcNow.AddMonths(1).AddDays(1);
        }
    }
}
