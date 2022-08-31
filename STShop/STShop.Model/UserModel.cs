using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace STShop.Model
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string TimeZone { get; set; }
        public string ConcurrencyToken { get; set; }
        public int Status { get; set; }
        public bool? Enabled2FA { get; set; }
        public int AccessFailedCount { get; set; }
        public DateTimeOffset? LockedEndDate_Utc { get; set; }
        public DateTimeOffset CreatedDate_Utc { get; set; }
        public DateTimeOffset ModifiedDate_Utc { get; set; }


        [JsonIgnore]
        public string PasswordHash { get; set; }
    }
}
