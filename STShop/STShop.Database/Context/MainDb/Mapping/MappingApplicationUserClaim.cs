using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using STShop.Database.Context.MainDb.Entity;

namespace STShop.Database.Context.MainDb.Mapping
{
    public class MappingApplicationUserClaim : IEntityTypeConfiguration<ApplicationUserClaim>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserClaim> builder)
        {
            builder.HasKey(x => new { x.UserId, x.ClaimId });
            builder.HasOne(x => x.User).WithMany(x => x.UserClaims).HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.Claim).WithMany(x => x.UserClaims).HasForeignKey(x => x.ClaimId);
            builder.ToTable(nameof(ApplicationUserClaim));
        }
    }
}
