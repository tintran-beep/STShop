using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using STShop.Database.Context.MainDb.Entity;

namespace STShop.Database.Context.MainDb.Mapping
{
    public class MappingApplicationUser : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Email).IsUnique();

            builder.Property(x => x.Email).HasMaxLength(256).IsRequired();
            builder.Property(x => x.FullName).HasMaxLength(256).IsRequired();
            builder.Property(x => x.PasswordHash).HasMaxLength(5000).IsRequired();
            builder.Property(x => x.ConcurrencyToken).HasMaxLength(50).IsConcurrencyToken();

            builder.HasMany<ApplicationUserRole>().WithOne().HasForeignKey(x => x.UserId);
            builder.HasMany<ApplicationUserClaim>().WithOne().HasForeignKey(x => x.UserId);
            builder.HasMany<ApplicationUserLogin>().WithOne().HasForeignKey(x => x.UserId);
            builder.HasMany<ApplicationUserToken>().WithOne().HasForeignKey(x => x.UserId);
            builder.ToTable(nameof(ApplicationUser));
        }
    }
}
