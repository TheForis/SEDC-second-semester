﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Qinshift.EShop.DataAccess;

#nullable disable

namespace Qinshift.EShop.DataAccess.Migrations
{
    [DbContext(typeof(EShopDbContext))]
    [Migration("20240825094951_NullableTypesInBaseEntity")]
    partial class NullableTypesInBaseEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Qinshift.EShop.DomainModels.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2800),
                            Description = "All sort of smart phones and tablets",
                            ModifiedBy = 1,
                            ModifiedOn = new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2834),
                            Name = "Smartphones and Tablets"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2840),
                            Description = "Different brands of PCs and all type of hardware components.",
                            ModifiedBy = 1,
                            ModifiedOn = new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2842),
                            Name = "PC and hardware"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2844),
                            Description = "Different brands of laptops",
                            ModifiedBy = 1,
                            ModifiedOn = new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2846),
                            Name = "Laptops"
                        });
                });

            modelBuilder.Entity("Qinshift.EShop.DomainModels.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2868),
                            Description = "256GB | 5.8' | 8GB RAM",
                            ImageUrl = "iphone15.jpg",
                            ModifiedBy = 1,
                            ModifiedOn = new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2870),
                            Name = "Iphone 15 Pro 256GB",
                            Price = 1000m,
                            StockQuantity = 50
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2877),
                            Description = "500GB SSD | 17' | 16GB RAM",
                            ImageUrl = "lenovoY700.jpg",
                            ModifiedBy = 1,
                            ModifiedOn = new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2879),
                            Name = "Lenovo Y700 Gaming laptop",
                            Price = 2000m,
                            StockQuantity = 20
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2882),
                            Description = "16GB VRAM",
                            ImageUrl = "graficka.jpg",
                            ModifiedBy = 1,
                            ModifiedOn = new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2883),
                            Name = "NVIDIA GeForce 4090",
                            Price = 2200m,
                            StockQuantity = 10
                        });
                });

            modelBuilder.Entity("Qinshift.EShop.DomainModels.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ReviewerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "Very nice product",
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2904),
                            ImageUrl = "images/phone.jpg",
                            ModifiedBy = 1,
                            ModifiedOn = new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2906),
                            ProductId = 1,
                            Rating = 5,
                            ReviewerName = "Martin"
                        },
                        new
                        {
                            Id = 2,
                            Comment = "Bad product. It is very slow. The ram is too much used",
                            CreatedBy = 1,
                            CreatedOn = new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2911),
                            ImageUrl = "images/phone.jpg",
                            ModifiedBy = 1,
                            ModifiedOn = new DateTime(2024, 8, 25, 11, 49, 50, 600, DateTimeKind.Local).AddTicks(2912),
                            ProductId = 1,
                            Rating = 2,
                            ReviewerName = "Slave"
                        });
                });

            modelBuilder.Entity("Qinshift.EShop.DomainModels.Product", b =>
                {
                    b.HasOne("Qinshift.EShop.DomainModels.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Qinshift.EShop.DomainModels.Review", b =>
                {
                    b.HasOne("Qinshift.EShop.DomainModels.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Qinshift.EShop.DomainModels.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Qinshift.EShop.DomainModels.Product", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}