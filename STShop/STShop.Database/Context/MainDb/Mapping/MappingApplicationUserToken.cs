using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using STShop.Database.Context.MainDb.Entity;

namespace STShop.Database.Context.MainDb.Mapping
{
    public class MappingApplicationUserToken : IEntityTypeConfiguration<ApplicationUserToken>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserToken> builder)
        {
            builder.HasKey(x => new { x.UserId, x.Provider, x.TokenName });
            builder.HasOne(x => x.User).WithMany(x => x.UserTokens).HasForeignKey(x => x.UserId);

            builder.Property(x => x.Provider).HasMaxLength(256).IsRequired();
            builder.Property(x => x.TokenName).HasMaxLength(256).IsRequired();
            builder.Property(x => x.TokenValue).HasMaxLength(5000).IsRequired();
            builder.ToTable(nameof(ApplicationUserToken));
        }
    }
}
