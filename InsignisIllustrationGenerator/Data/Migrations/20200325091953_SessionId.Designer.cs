﻿// <auto-generated />
using System;
using InsignisIllustrationGenerator.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InsignisIllustrationGenerator.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200325091953_SessionId")]
    partial class SessionId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InsignisIllustrationGenerator.Data.Bank", b =>
                {
                    b.Property<int>("BankID")
                        .HasColumnType("int");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FitchRating")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BankID");

                    b.ToTable("Bank");
                });

            modelBuilder.Entity("InsignisIllustrationGenerator.Data.ExcludedInstitute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientReference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InstituteId")
                        .HasColumnType("int");

                    b.Property<string>("PartnerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartnerOrganisation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SessionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UniqueReferenceId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ExcludedInstitutes");
                });

            modelBuilder.Entity("InsignisIllustrationGenerator.Data.IllustrationDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AnnualGrossInterestEarned")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("AnnualNetInterestEarned")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ClientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientType")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("EasyAccess")
                        .HasColumnType("float");

                    b.Property<DateTime>("GenerateDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("GrossAverageYield")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("IllustrationUniqueReference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("NetAverageYield")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double>("NineMonths")
                        .HasColumnType("float");

                    b.Property<double>("OneMonth")
                        .HasColumnType("float");

                    b.Property<double>("OneYear")
                        .HasColumnType("float");

                    b.Property<string>("PartnerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartnerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartnerOrganisation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferredBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SixMonths")
                        .HasColumnType("float");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ThreeMonths")
                        .HasColumnType("float");

                    b.Property<double>("ThreeYearsPlus")
                        .HasColumnType("float");

                    b.Property<double>("TotalDeposit")
                        .HasColumnType("float");

                    b.Property<double>("TwoYears")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("IllustrationDetails");
                });

            modelBuilder.Entity("InsignisIllustrationGenerator.Data.InvestmentTermMapper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("InvestmentTerm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvestmentText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("InvestmentTermMapper");
                });

            modelBuilder.Entity("InsignisIllustrationGenerator.Data.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int?>("BankID")
                        .HasColumnType("int");

                    b.Property<string>("InterestPaid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailableToCourtOfProtectionHubAccounts")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailableToIncorporatedCharityHubAccounts")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailableToJointHubAccounts")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailableToLargeCorporateHubAccounts")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailableToLocalAuthorityHubAccounts")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailableToPersonalHubAccounts")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailableToPersonalTrustHubAccounts")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailableToPowerOfAttorneyHubAccounts")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailableToSIPPHubAccounts")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailableToSMEHubAccounts")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailableToSSASHubAccounts")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailableToTrustHubAccounts")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailableToUnincorporatedCharityHubAccounts")
                        .HasColumnType("bit");

                    b.Property<string>("LiquidityType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaximumDeposit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MinimumDeposit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoticeDays")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoticeText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RateFor100KDeposit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RateFor250KDeposit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RateFor50KDeposit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TermDays")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TermText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductID");

                    b.HasIndex("BankID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("InsignisIllustrationGenerator.Data.ProposedPortfolio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AnnualInterest")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DepositSize")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("IllustrationDetailId")
                        .HasColumnType("int");

                    b.Property<int>("IllustrationID")
                        .HasColumnType("int");

                    b.Property<int?>("InstitutionID")
                        .HasColumnType("int");

                    b.Property<string>("InstitutionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstitutionShortName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvestmentTerm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IllustrationDetailId");

                    b.ToTable("ProposedPortfolio");
                });

            modelBuilder.Entity("InsignisIllustrationGenerator.Data.TempInstitution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("AnnualInterest")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BankId")
                        .HasColumnType("int");

                    b.Property<string>("ClientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstitutionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvestmentTerm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartnerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartnerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartnerOrganisation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("SessionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("TempInstitution");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
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

            modelBuilder.Entity("InsignisIllustrationGenerator.Data.Product", b =>
                {
                    b.HasOne("InsignisIllustrationGenerator.Data.Bank", "Bank")
                        .WithMany("Products")
                        .HasForeignKey("BankID");
                });

            modelBuilder.Entity("InsignisIllustrationGenerator.Data.ProposedPortfolio", b =>
                {
                    b.HasOne("InsignisIllustrationGenerator.Data.IllustrationDetail", "IllustrationDetail")
                        .WithMany("IllustrationProposedPortfolio")
                        .HasForeignKey("IllustrationDetailId");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
