namespace STShop.Database.Context.MainDb.Entity
{
    public class ApplicationRole : BaseEntity
    {
        public ApplicationRole()
        {
            Id = Guid.NewGuid();
            CreatedDate_Utc = DateTime.UtcNow;
            ModifiedDate_Utc = DateTime.UtcNow;

            ConcurrencyToken = Guid.NewGuid().ToString().ToUpper();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ConcurrencyToken { get; set; }
        public DateTimeOffset CreatedDate_Utc { get; set; }
        public DateTimeOffset ModifiedDate_Utc { get; set; }

        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
        public virtual ICollection<ApplicationRoleClaim> RoleClaims { get; set; }
    }
}
