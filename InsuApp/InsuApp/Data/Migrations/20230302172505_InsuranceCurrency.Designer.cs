﻿// <auto-generated />
using System;
using InsuApp1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InsuApp1.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230302172505_InsuranceCurrency")]
    partial class InsuranceCurrency
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InsuApp1.Models.MainInsurance", b =>
                {
                    b.Property<int>("MainInsuranceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MainInsuranceId"));

                    b.Property<string>("MainInsuranceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MainInsuranceId");

                    b.ToTable("MainInsurance");
                });

            modelBuilder.Entity("InsuApp1.Models.MainInsuredEvent", b =>
                {
                    b.Property<int>("MainInsuredEventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MainInsuredEventId"));

                    b.Property<string>("MainInsuredEventName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MainInsuredEventId");

                    b.ToTable("MainInsuredEvent");
                });

            modelBuilder.Entity("InsuApp1.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserCategory")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("InsuApp1.Models.UserDetailViewModel", b =>
                {
                    b.Property<int>("UserDetailViewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserDetailViewId"));

                    b.Property<int?>("InsuranceCurrency")
                        .HasColumnType("int");

                    b.Property<string>("InsuranceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("InsuranceValidFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("InsuranceValidTo")
                        .HasColumnType("datetime2");

                    b.Property<int?>("InsuranceValue")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("MainInsuranceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObjectOfInsurane")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserCategory")
                        .HasColumnType("int");

                    b.Property<int>("UserDetailViewUserId")
                        .HasColumnType("int");

                    b.Property<int?>("UserInsuredEventId")
                        .HasColumnType("int");

                    b.HasKey("UserDetailViewId");

                    b.HasIndex("UserDetailViewUserId");

                    b.HasIndex("UserInsuredEventId");

                    b.ToTable("UserDetailViewModel");
                });

            modelBuilder.Entity("InsuApp1.Models.UserDetailViewModelEvent", b =>
                {
                    b.Property<int>("UserDetailEventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserDetailEventId"));

                    b.Property<int?>("InsuranceCurrency")
                        .HasColumnType("int");

                    b.Property<DateTime?>("InsuredEventDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("InsuredEventValue")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("MainInsuredEventName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObjectOfInsuredEvent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserCategory")
                        .HasColumnType("int");

                    b.Property<int?>("UserDetailEventViewUserId")
                        .HasColumnType("int");

                    b.HasKey("UserDetailEventId");

                    b.HasIndex("UserDetailEventViewUserId");

                    b.ToTable("UserDetailViewModelEvent");
                });

            modelBuilder.Entity("InsuApp1.Models.UserInsurance", b =>
                {
                    b.Property<int>("UserInsuranceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserInsuranceId"));

                    b.Property<int>("InsuranceCurrency")
                        .HasColumnType("int");

                    b.Property<string>("InsuranceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("InsuranceValidFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("InsuranceValidTo")
                        .HasColumnType("datetime2");

                    b.Property<int?>("InsuranceValue")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("ObjectOfInsurance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserDetailViewModelUserDetailViewId")
                        .HasColumnType("int");

                    b.Property<string>("UserUserInsuranceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserUserInsuranceUserId")
                        .HasColumnType("int");

                    b.HasKey("UserInsuranceId");

                    b.HasIndex("UserDetailViewModelUserDetailViewId");

                    b.HasIndex("UserUserInsuranceUserId");

                    b.ToTable("UserInsurance");
                });

            modelBuilder.Entity("InsuApp1.Models.UserInsuredEvent", b =>
                {
                    b.Property<int>("UserInsuredEventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserInsuredEventId"));

                    b.Property<DateTime?>("InsuredEventDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InsuredEventName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InsuredEventValue")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("ObjectOfInsuredEvent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserDetailViewModelEventUserDetailEventId")
                        .HasColumnType("int");

                    b.Property<int?>("UserDetailViewModelUserDetailViewId")
                        .HasColumnType("int");

                    b.Property<int?>("UserUserInsuredEventUserId")
                        .HasColumnType("int");

                    b.HasKey("UserInsuredEventId");

                    b.HasIndex("UserDetailViewModelEventUserDetailEventId");

                    b.HasIndex("UserDetailViewModelUserDetailViewId");

                    b.HasIndex("UserUserInsuredEventUserId");

                    b.ToTable("UserInsuredEvent");
                });

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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

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

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("InsuApp1.Models.UserDetailViewModel", b =>
                {
                    b.HasOne("InsuApp1.Models.User", "UserDetailView")
                        .WithMany()
                        .HasForeignKey("UserDetailViewUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuApp1.Models.UserInsuredEvent", "UserInsuredEvent")
                        .WithMany()
                        .HasForeignKey("UserInsuredEventId");

                    b.Navigation("UserDetailView");

                    b.Navigation("UserInsuredEvent");
                });

            modelBuilder.Entity("InsuApp1.Models.UserDetailViewModelEvent", b =>
                {
                    b.HasOne("InsuApp1.Models.User", "UserDetailEventView")
                        .WithMany()
                        .HasForeignKey("UserDetailEventViewUserId");

                    b.Navigation("UserDetailEventView");
                });

            modelBuilder.Entity("InsuApp1.Models.UserInsurance", b =>
                {
                    b.HasOne("InsuApp1.Models.UserDetailViewModel", null)
                        .WithMany("UserInsurances")
                        .HasForeignKey("UserDetailViewModelUserDetailViewId");

                    b.HasOne("InsuApp1.Models.User", "UserUserInsurance")
                        .WithMany()
                        .HasForeignKey("UserUserInsuranceUserId");

                    b.Navigation("UserUserInsurance");
                });

            modelBuilder.Entity("InsuApp1.Models.UserInsuredEvent", b =>
                {
                    b.HasOne("InsuApp1.Models.UserDetailViewModelEvent", null)
                        .WithMany("UserInsuredEvents")
                        .HasForeignKey("UserDetailViewModelEventUserDetailEventId");

                    b.HasOne("InsuApp1.Models.UserDetailViewModel", null)
                        .WithMany("UserInsuredEvents")
                        .HasForeignKey("UserDetailViewModelUserDetailViewId");

                    b.HasOne("InsuApp1.Models.User", "UserUserInsuredEvent")
                        .WithMany()
                        .HasForeignKey("UserUserInsuredEventUserId");

                    b.Navigation("UserUserInsuredEvent");
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

            modelBuilder.Entity("InsuApp1.Models.UserDetailViewModel", b =>
                {
                    b.Navigation("UserInsurances");

                    b.Navigation("UserInsuredEvents");
                });

            modelBuilder.Entity("InsuApp1.Models.UserDetailViewModelEvent", b =>
                {
                    b.Navigation("UserInsuredEvents");
                });
#pragma warning restore 612, 618
        }
    }
}
