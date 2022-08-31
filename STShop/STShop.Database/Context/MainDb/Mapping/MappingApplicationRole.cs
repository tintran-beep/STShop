using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using STShop.Database.Context.MainDb.Entity;

namespace STShop.Database.Context.MainDb.Mapping
{
    public class MappingApplicationRole : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Name).IsUnique();

            builder.Property(x => x.Name).HasMaxLength(256).IsRequired();
            builder.Property(x => x.ConcurrencyToken).HasMaxLength(50).IsConcurrencyToken();

            builder.HasMany<ApplicationUserRole>().WithOne().HasForeignKey(x => x.RoleId);
            builder.HasMany<ApplicationRoleClaim>().WithOne().HasForeignKey(x => x.RoleId);
            builder.ToTable(nameof(ApplicationRole));
        }
    }
}
