namespace STShop.Database.Context.MainDb.Entity
{
    public class ApplicationUserLogin : BaseEntity
    {
        public ApplicationUserLogin()
        {

        }
        public string Provider { get; set; }
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        public Guid UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
