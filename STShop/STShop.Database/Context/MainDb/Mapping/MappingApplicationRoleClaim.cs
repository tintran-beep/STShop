using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using STShop.Database.Context.MainDb.Entity;

namespace STShop.Database.Context.MainDb.Mapping
{
    public class MappingApplicationRoleClaim : IEntityTypeConfiguration<ApplicationRoleClaim>
    {
        public void Configure(EntityTypeBuilder<ApplicationRoleClaim> builder)
        {
            builder.HasKey(x => new { x.RoleId, x.ClaimId });
            builder.HasOne(x => x.Role).WithMany(x => x.RoleClaims).HasForeignKey(x => x.RoleId);
            builder.HasOne(x => x.Claim).WithMany(x => x.RoleClaims).HasForeignKey(x => x.ClaimId);
            builder.ToTable(nameof(ApplicationRoleClaim));
        }
    }
}
