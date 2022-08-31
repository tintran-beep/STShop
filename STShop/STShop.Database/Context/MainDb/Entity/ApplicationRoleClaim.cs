using System;
using System.Collections.Generic;
using System.Linq;
namespace STShop.Database.Context.MainDb.Entity
{
    public class ApplicationRoleClaim : BaseEntity
    {
        public ApplicationRoleClaim(Guid roleId, Guid claimId)
        {
            RoleId = roleId;
            ClaimId = claimId;
        }
        public Guid RoleId { get; set; }
        public Guid ClaimId { get; set; }

        public virtual ApplicationRole Role { get; set; }
        public virtual ApplicationClaim Claim { get; set; }
    }
}
