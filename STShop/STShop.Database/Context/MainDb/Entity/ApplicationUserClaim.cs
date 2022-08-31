namespace STShop.Database.Context.MainDb.Entity
{
    public class ApplicationUserClaim : BaseEntity
    {
        public ApplicationUserClaim(Guid userId, Guid claimId)
        {
            UserId = userId;
            ClaimId = claimId;
        }
        public Guid UserId { get; set; }
        public Guid ClaimId { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual ApplicationClaim Claim { get; set; }
    }
}
