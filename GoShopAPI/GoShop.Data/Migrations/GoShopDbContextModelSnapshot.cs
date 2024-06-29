﻿// <auto-generated />
using System;
using GoShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GoShop.Data.Migrations
{
    [DbContext(typeof(GoShopDbContext))]
    partial class GoShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GoShop.Domain.Entities.MobilePhoneEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Condition")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("MobilePhoneHardwareId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MobilePhoneSoftwareId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("MobilePhones", (string)null);
                });

            modelBuilder.Entity("GoShop.Domain.Entities.MobilePhoneHardwareEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Battery")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Camera")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Dimensions")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Display")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("MobilePhoneId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("RAM")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Storage")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Weight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MobilePhoneId")
                        .IsUnique();

                    b.ToTable("MobilePhoneHardware", (string)null);
                });

            modelBuilder.Entity("GoShop.Domain.Entities.MobilePhoneSoftwareEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirmwareVersion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsRootedOrJailbroken")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastSoftwareUpdate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MobilePhoneID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OSVersion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("OperatingSystem")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("MobilePhoneID")
                        .IsUnique();

                    b.ToTable("MobilePhoneSoftware", (string)null);
                });

            modelBuilder.Entity("GoShop.Domain.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("MobilePhoneId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("GoShop.Domain.Entities.MobilePhoneEntity", b =>
                {
                    b.HasOne("GoShop.Domain.Entities.UserEntity", "User")
                        .WithMany("MobilePhones")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("GoShop.Domain.Entities.MobilePhoneHardwareEntity", b =>
                {
                    b.HasOne("GoShop.Domain.Entities.MobilePhoneEntity", "MobilePhone")
                        .WithOne("MobilePhoneHardware")
                        .HasForeignKey("GoShop.Domain.Entities.MobilePhoneHardwareEntity", "MobilePhoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MobilePhone");
                });

            modelBuilder.Entity("GoShop.Domain.Entities.MobilePhoneSoftwareEntity", b =>
                {
                    b.HasOne("GoShop.Domain.Entities.MobilePhoneEntity", "MobilePhone")
                        .WithOne("MobilePhoneSoftware")
                        .HasForeignKey("GoShop.Domain.Entities.MobilePhoneSoftwareEntity", "MobilePhoneID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MobilePhone");
                });

            modelBuilder.Entity("GoShop.Domain.Entities.MobilePhoneEntity", b =>
                {
                    b.Navigation("MobilePhoneHardware")
                        .IsRequired();

                    b.Navigation("MobilePhoneSoftware")
                        .IsRequired();
                });

            modelBuilder.Entity("GoShop.Domain.Entities.UserEntity", b =>
                {
                    b.Navigation("MobilePhones");
                });
#pragma warning restore 612, 618
        }
    }
}