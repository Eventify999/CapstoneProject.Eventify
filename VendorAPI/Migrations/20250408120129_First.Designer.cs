﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VendorAPI.Data;

#nullable disable

namespace VendorAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250408120129_First")]
    partial class First
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VendorAPI.Models.AvailabilitySlot", b =>
                {
                    b.Property<int>("SlotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SlotId"));

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.HasKey("SlotId");

                    b.ToTable("AvailabilitySlots");
                });

            modelBuilder.Entity("VendorAPI.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("PackageId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("VendorAPI.Models.Quotation", b =>
                {
                    b.Property<int>("QuoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuoteId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("Discount")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.HasKey("QuoteId");

                    b.ToTable("Quotations");
                });

            modelBuilder.Entity("VendorAPI.Models.ServiceSelection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("PackageId")
                        .HasColumnType("int");

                    b.Property<int>("RequestId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SelectedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ServiceSelections");
                });

            modelBuilder.Entity("VendorAPI.Models.Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BusinessName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vendors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BusinessName = "zzz",
                            Email = "asd@epic.com",
                            PasswordHash = "nothing@epic420"
                        });
                });

            modelBuilder.Entity("VendorAPI.Models.VendorPackage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PackageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VendorId");

                    b.ToTable("VendorPackages");
                });

            modelBuilder.Entity("VendorAPI.Models.VendorPackage", b =>
                {
                    b.HasOne("VendorAPI.Models.Vendor", "Vendor")
                        .WithMany("Packages")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("VendorAPI.Models.Vendor", b =>
                {
                    b.Navigation("Packages");
                });
#pragma warning restore 612, 618
        }
    }
}
