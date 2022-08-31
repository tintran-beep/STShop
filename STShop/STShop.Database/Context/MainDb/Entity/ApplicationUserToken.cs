namespace STShop.Database.Context.MainDb.Entity
{
    public class ApplicationUserToken : BaseEntity
    {
        public ApplicationUserToken()
        {

        }
        public Guid UserId { get; set; }
        public string Provider { get; set; }
        public string TokenName { get; set; }
        public string TokenValue { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
