using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using STShop.Database.Context.MainDb.Entity;

namespace STShop.Database.Context.MainDb.Mapping
{    
    public class MappingApplicationClaim : IEntityTypeConfiguration<ApplicationClaim>
    {
        public void Configure(EntityTypeBuilder<ApplicationClaim> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ClaimType).HasMaxLength(100).IsRequired();
            builder.Property(x => x.ClaimValue).HasMaxLength(250).IsRequired();

            builder.HasMany<ApplicationRoleClaim>().WithOne().HasForeignKey(x => x.ClaimId);
            builder.HasMany<ApplicationUserClaim>().WithOne().HasForeignKey(x => x.ClaimId);
            builder.ToTable(nameof(ApplicationClaim));
        }
    }
}
