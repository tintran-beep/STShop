namespace STShop.Database.Context.MainDb.Entity
{
    public class ApplicationUser : BaseEntity
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid();
            CreatedDate_Utc = DateTime.UtcNow;
            ModifiedDate_Utc = DateTime.UtcNow;
            Status = (int)Library.Enums.UserStatus.NEW;

            Enabled2FA = false;
            AccessFailedCount = 0;
            ConcurrencyToken = Guid.NewGuid().ToString().ToUpper();
        }
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string TimeZone { get; set; }
        public string PasswordHash { get; set; }
        public string ConcurrencyToken { get; set; }
        public int Status { get; set; }
        public bool? Enabled2FA { get; set; }
        public int AccessFailedCount { get; set; }
        public DateTimeOffset? LockedEndDate_Utc { get; set; }
        public DateTimeOffset CreatedDate_Utc { get; set; }
        public DateTimeOffset ModifiedDate_Utc { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
        public virtual ICollection<ApplicationUserClaim> UserClaims { get; set; }
        public virtual ICollection<ApplicationUserLogin> UserLogins { get; set; }
        public virtual ICollection<ApplicationUserToken> UserTokens { get; set; }
    }
}
