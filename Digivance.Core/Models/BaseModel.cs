using System;

namespace Digivance.Core.Models {
    /// <summary>
    /// BaseModel represents the shared functionality of all data models in the
    /// Digivance.Core shared library.
    /// </summary>
    public class BaseModel {
        /// <summary>
        /// CreatedByID is the optional UserAccount ID that created this record, if known.
        /// </summary>
        public long? CreatedByID { get; set; }

        /// <summary>
        /// CreatedDate is the UTC DateTime when this record was first created
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// ID of this record
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// ModifiedByID is the optional UserAccount ID that last modified this record, if known.
        /// </summary>
        public long? ModifiedByID { get; set; }

        /// <summary>
        /// ModifiedDate is the UTC DateTime when this record was last modified.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseModel() {
            CreatedDate = DateTime.UtcNow;
            ModifiedDate = DateTime.UtcNow;
        }
    }
}
