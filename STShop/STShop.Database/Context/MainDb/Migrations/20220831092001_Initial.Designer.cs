// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using STShop.Database.Context.MainDb;

#nullable disable

namespace STShop.Database.Context.MainDb.Migrations
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20220831092001_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("STShop.Database.Context.MainDb.Entity.ApplicationClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClaimType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ClaimValue")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTimeOffset>("CreatedDate_Utc")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("ModifiedDate_Utc")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("ApplicationClaim", (string)null);
                });

            modelBuilder.Entity("STShop.Database.Context.MainDb.Entity.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyToken")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTimeOffset>("CreatedDate_Utc")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("ModifiedDate_Utc")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("ApplicationRole", (string)null);
                });

            modelBuilder.Entity("STShop.Database.Context.MainDb.Entity.ApplicationRoleClaim", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClaimId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoleId", "ClaimId");

                    b.HasIndex("ClaimId");

                    b.ToTable("ApplicationRoleClaim", (string)null);
                });

            modelBuilder.Entity("STShop.Database.Context.MainDb.Entity.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyToken")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTimeOffset>("CreatedDate_Utc")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool?>("Enabled2FA")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTimeOffset?>("LockedEndDate_Utc")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("ModifiedDate_Utc")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TimeZone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("ApplicationUser", (string)null);
                });

            modelBuilder.Entity("STShop.Database.Context.MainDb.Entity.ApplicationUserClaim", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClaimId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "ClaimId");

                    b.HasIndex("ClaimId");

                    b.ToTable("ApplicationUserClaim", (string)null);
                });

            modelBuilder.Entity("STShop.Database.Context.MainDb.Entity.ApplicationUserLogin", b =>
                {
                    b.Property<string>("Provider")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("ProviderDisplayName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Provider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("ApplicationUserLogin", (string)null);
                });

            modelBuilder.Entity("STShop.Database.Context.MainDb.Entity.ApplicationUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("ApplicationUserRole", (string)null);
                });

            modelBuilder.Entity("STShop.Database.Context.MainDb.Entity.ApplicationUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Provider")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("TokenName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("TokenValue")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "Provider", "TokenName");

                    b.ToTable("ApplicationUserToken", (string)null);
                });

            modelBuilder.Entity("STShop.Database.Context.MainDb.Entity.ApplicationRoleClaim", b =>
                {
                    b.HasOne("STShop.Database.Context.MainDb.Entity.ApplicationClaim", "Claim")
                        .WithMany("RoleClaims")
                        .HasForeignKey("ClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("STShop.Database.Context.MainDb.Entity.ApplicationRole", "Role")
                        .WithMany("RoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Claim");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("STShop.Database.Context.MainDb.Entity.ApplicationUserClaim", b =>
                {
                    b.HasOne("STShop.Database.Context.MainDb.Entity.ApplicationClaim", "Claim")
                        .WithMany("UserClaims")
                        .HasForeignKey("ClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("STShop.Database.Context.MainDb.Entity.ApplicationUser", "User")
                        .WithMany("UserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Claim");

                    b.Navigation("User");
                });

            modelBuilder.Entity("STShop.Database.Context.MainDb.Entity.ApplicationUserLogin", b =>
                {
                    b.HasOne("STShop.Database.Context.MainDb.Entity.ApplicationUser", "User")
                        .WithMany("UserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("STShop.Database.Context.MainDb.Entity.ApplicationUserRole", b =>
                {
                    b.HasOne("STShop.Database.Context.MainDb.Entity.ApplicationRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("STShop.Database.Context.MainDb.Entity.ApplicationUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("STShop.Database.Context.MainDb.Entity.ApplicationUserToken", b =>
                {
                    b.HasOne("STShop.Database.Context.MainDb.Entity.ApplicationUser", "User")
                        .WithMany("UserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("STShop.Database.Context.MainDb.Entity.ApplicationClaim", b =>
                {
                    b.Navigation("RoleClaims");

                    b.Navigation("UserClaims");
                });

            modelBuilder.Entity("STShop.Database.Context.MainDb.Entity.ApplicationRole", b =>
                {
                    b.Navigation("RoleClaims");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("STShop.Database.Context.MainDb.Entity.ApplicationUser", b =>
                {
                    b.Navigation("UserClaims");

                    b.Navigation("UserLogins");

                    b.Navigation("UserRoles");

                    b.Navigation("UserTokens");
                });
#pragma warning restore 612, 618
        }
    }
}
