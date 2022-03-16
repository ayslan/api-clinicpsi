﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Psi.Infra.Data.Context;

namespace Psi.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Psi.Domain.Entities.Anamnesis", b =>
                {
                    b.Property<int>("AnamnesisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreationDateUtc")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TenantFk")
                        .HasColumnType("int");

                    b.HasKey("AnamnesisId");

                    b.HasIndex("TenantFk");

                    b.ToTable("Anamnesis");
                });

            modelBuilder.Entity("Psi.Domain.Entities.AnamnesisField", b =>
                {
                    b.Property<int>("AnamnesisFieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnamnesisFieldType")
                        .HasColumnType("int");

                    b.Property<int>("AnamnesisTopicFk")
                        .HasColumnType("int");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnamnesisFieldId");

                    b.HasIndex("AnamnesisTopicFk");

                    b.ToTable("AnamnesisFields");
                });

            modelBuilder.Entity("Psi.Domain.Entities.AnamnesisTopic", b =>
                {
                    b.Property<int>("AnamnesisTopicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnamnesisFk")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("AnamnesisTopicId");

                    b.HasIndex("AnamnesisFk");

                    b.ToTable("AnamnesisTopics");
                });

            modelBuilder.Entity("Psi.Domain.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreationDateUtc")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurrentTenantFk")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Psi.Domain.Entities.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Psi.Domain.Entities.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgeGroup")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ChargeType")
                        .HasColumnType("int");

                    b.Property<int?>("CityFk")
                        .HasColumnType("int");

                    b.Property<string>("Complement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountryFk")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDateUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EducationLevel")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmergencyContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmergencyPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ForeignCityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ForeignStateName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<int?>("InsuranceFk")
                        .HasColumnType("int");

                    b.Property<int?>("InsuranceTransferType")
                        .HasColumnType("int");

                    b.Property<float?>("InsuranceTransferValue")
                        .HasColumnType("real");

                    b.Property<int?>("MaritalStatus")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Observation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profession")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QtyPackageServices")
                        .HasColumnType("int");

                    b.Property<string>("RG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Religion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ServiceModality")
                        .HasColumnType("int");

                    b.Property<float?>("ServicePackagePrice")
                        .HasColumnType("real");

                    b.Property<float?>("ServicePrice")
                        .HasColumnType("real");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TenantFk")
                        .HasColumnType("int");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.HasIndex("CityFk");

                    b.HasIndex("CountryFk");

                    b.HasIndex("InsuranceFk");

                    b.HasIndex("TenantFk");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Psi.Domain.Entities.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EnglishName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISOCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhoneCode")
                        .HasColumnType("int");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Psi.Domain.Entities.Insurance", b =>
                {
                    b.Property<int>("InsuranceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TenantFk")
                        .HasColumnType("int");

                    b.HasKey("InsuranceId");

                    b.HasIndex("TenantFk");

                    b.ToTable("Insurance");
                });

            modelBuilder.Entity("Psi.Domain.Entities.Tenant", b =>
                {
                    b.Property<int>("TenantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TenantId");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("Psi.Domain.Entities.TenantUser", b =>
                {
                    b.Property<int>("TenantUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TenantFk")
                        .HasColumnType("int");

                    b.Property<string>("UserFk")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TenantUserId");

                    b.HasIndex("TenantFk");

                    b.HasIndex("UserFk");

                    b.ToTable("TenantUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Psi.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Psi.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Psi.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Psi.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Psi.Domain.Entities.Anamnesis", b =>
                {
                    b.HasOne("Psi.Domain.Entities.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("Psi.Domain.Entities.AnamnesisField", b =>
                {
                    b.HasOne("Psi.Domain.Entities.AnamnesisTopic", "AnamnesisTopic")
                        .WithMany("AnamnesisFields")
                        .HasForeignKey("AnamnesisTopicFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnamnesisTopic");
                });

            modelBuilder.Entity("Psi.Domain.Entities.AnamnesisTopic", b =>
                {
                    b.HasOne("Psi.Domain.Entities.Anamnesis", "Anamnesis")
                        .WithMany("AnamnesisTopics")
                        .HasForeignKey("AnamnesisFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Anamnesis");
                });

            modelBuilder.Entity("Psi.Domain.Entities.Client", b =>
                {
                    b.HasOne("Psi.Domain.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityFk");

                    b.HasOne("Psi.Domain.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryFk");

                    b.HasOne("Psi.Domain.Entities.Insurance", "Insurance")
                        .WithMany()
                        .HasForeignKey("InsuranceFk");

                    b.HasOne("Psi.Domain.Entities.Tenant", "Tenant")
                        .WithMany("Clients")
                        .HasForeignKey("TenantFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Country");

                    b.Navigation("Insurance");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("Psi.Domain.Entities.Insurance", b =>
                {
                    b.HasOne("Psi.Domain.Entities.Tenant", "Tenant")
                        .WithMany("Insurance")
                        .HasForeignKey("TenantFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("Psi.Domain.Entities.TenantUser", b =>
                {
                    b.HasOne("Psi.Domain.Entities.Tenant", "Tenant")
                        .WithMany("TenantUsers")
                        .HasForeignKey("TenantFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Psi.Domain.Entities.ApplicationUser", "User")
                        .WithMany("TenantUsers")
                        .HasForeignKey("UserFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tenant");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Psi.Domain.Entities.Anamnesis", b =>
                {
                    b.Navigation("AnamnesisTopics");
                });

            modelBuilder.Entity("Psi.Domain.Entities.AnamnesisTopic", b =>
                {
                    b.Navigation("AnamnesisFields");
                });

            modelBuilder.Entity("Psi.Domain.Entities.ApplicationUser", b =>
                {
                    b.Navigation("TenantUsers");
                });

            modelBuilder.Entity("Psi.Domain.Entities.Tenant", b =>
                {
                    b.Navigation("Clients");

                    b.Navigation("Insurance");

                    b.Navigation("TenantUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
