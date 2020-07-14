﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuoteMan_b0._1.Data;

namespace QuoteMan_b0._1.Data.Migrations
{
    [DbContext(typeof(QuoteManContext))]
    [Migration("20200714045702_seed_db")]
    partial class seed_db
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuoteMan_b0._1.Core.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<int>("Title")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Email = "bobsmithh@gmail.com",
                            FirstName = "Bob",
                            LastName = "Smith",
                            PhoneNumber = "07833373407",
                            Title = 1
                        },
                        new
                        {
                            CustomerId = 2,
                            Email = "droctagon@fastmail.net",
                            FirstName = "Fred",
                            LastName = "Octagon",
                            PhoneNumber = "07833373408",
                            Title = 3
                        });
                });

            modelBuilder.Entity("QuoteMan_b0._1.Core.Models.Quote", b =>
                {
                    b.Property<int>("QuoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateGiven")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("VehicleMake")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("VehicleModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("QuoteId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Quotes");

                    b.HasData(
                        new
                        {
                            QuoteId = 1,
                            CustomerId = 1,
                            DateGiven = new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Vehicle done got a bit of damage",
                            Price = 350.0m,
                            Status = 0,
                            VehicleMake = "Honda",
                            VehicleModel = "Civic"
                        },
                        new
                        {
                            QuoteId = 2,
                            CustomerId = 1,
                            DateGiven = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Vehicle done got a bit of damage",
                            Price = 550.0m,
                            Status = 1,
                            VehicleMake = "Honda",
                            VehicleModel = "Civic Type-R"
                        },
                        new
                        {
                            QuoteId = 3,
                            CustomerId = 2,
                            DateGiven = new DateTime(2019, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bleheheheheheh",
                            Price = 950.0m,
                            Status = 1,
                            VehicleMake = "Toyota",
                            VehicleModel = "Landcruiser"
                        },
                        new
                        {
                            QuoteId = 4,
                            CustomerId = 2,
                            DateGiven = new DateTime(2020, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bleheheheheheh",
                            Price = 550.0m,
                            Status = 0,
                            VehicleMake = "Toyota",
                            VehicleModel = "GT86"
                        });
                });

            modelBuilder.Entity("QuoteMan_b0._1.Core.Models.Quote", b =>
                {
                    b.HasOne("QuoteMan_b0._1.Core.Models.Customer", "Customer")
                        .WithMany("Quotes")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
