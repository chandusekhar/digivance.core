using System;

namespace Digivance.Core.Models {
    public class UserAccountLockout : BaseModel {
        public DateTime? ExpirationDate { get; set; }

        public string Reason { get; set; }

        public virtual UserAccount UserAccount { get; set; }

        public long UserAccountID { get; set; }

        public UserAccountLockout() : base() { }
    }
}
