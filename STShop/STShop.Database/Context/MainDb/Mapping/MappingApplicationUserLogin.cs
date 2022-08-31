using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using STShop.Database.Context.MainDb.Entity;


namespace STShop.Database.Context.MainDb.Mapping
{
    public class MappingApplicationUserLogin : IEntityTypeConfiguration<ApplicationUserLogin>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserLogin> builder)
        {
            builder.HasKey(x => new { x.Provider, x.ProviderKey });
            builder.HasOne(x => x.User).WithMany(x => x.UserLogins).HasForeignKey(x => x.UserId);

            builder.Property(x => x.Provider).HasMaxLength(256).IsRequired();
            builder.Property(x => x.ProviderKey).HasMaxLength(256).IsRequired();
            builder.Property(x => x.ProviderDisplayName).HasMaxLength(256).IsRequired();
            builder.ToTable(nameof(ApplicationUserLogin));
        }
    }
}
