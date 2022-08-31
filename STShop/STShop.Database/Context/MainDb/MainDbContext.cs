using Microsoft.EntityFrameworkCore;
using STShop.Database.Context.MainDb.Entity;
using STShop.Database.Context.MainDb.Mapping;

namespace STShop.Database.Context.MainDb
{
    public class MainDbContext : BaseDbContext
    {
        public MainDbContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<ApplicationUser> Users { get; set; }
        public virtual DbSet<ApplicationRole> Roles { get; set; }
        public virtual DbSet<ApplicationClaim> Claims { get; set; }

        public virtual DbSet<ApplicationUserRole> UserRoles { get; set; }
        public virtual DbSet<ApplicationUserClaim> UserClaims { get; set; }
        public virtual DbSet<ApplicationUserLogin> UserLogins { get; set; }
        public virtual DbSet<ApplicationUserToken> UserTokens { get; set; }
        public virtual DbSet<ApplicationRoleClaim> RoleClaims { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            base.OnConfiguring(options);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            new MappingApplicationUser().Configure(builder.Entity<ApplicationUser>());
            new MappingApplicationRole().Configure(builder.Entity<ApplicationRole>());
            new MappingApplicationClaim().Configure(builder.Entity<ApplicationClaim>());

            new MappingApplicationUserRole().Configure(builder.Entity<ApplicationUserRole>());
            new MappingApplicationUserClaim().Configure(builder.Entity<ApplicationUserClaim>());
            new MappingApplicationUserLogin().Configure(builder.Entity<ApplicationUserLogin>());
            new MappingApplicationUserToken().Configure(builder.Entity<ApplicationUserToken>());
            new MappingApplicationRoleClaim().Configure(builder.Entity<ApplicationRoleClaim>());

            base.OnModelCreating(builder);
        }

    }
}
