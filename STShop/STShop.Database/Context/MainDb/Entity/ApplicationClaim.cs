namespace STShop.Database.Context.MainDb.Entity
{
    public class ApplicationClaim : BaseEntity
    {
        public ApplicationClaim()
        {
            Id = Guid.NewGuid();
            CreatedDate_Utc = DateTime.UtcNow;
            ModifiedDate_Utc = DateTime.UtcNow;
        }
        public Guid Id { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public DateTimeOffset CreatedDate_Utc { get; set; }
        public DateTimeOffset ModifiedDate_Utc { get; set; }

        public virtual ICollection<ApplicationRoleClaim> RoleClaims { get; set; }
        public virtual ICollection<ApplicationUserClaim> UserClaims { get; set; }
    }
}
