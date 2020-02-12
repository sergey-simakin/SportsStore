﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsStore.DAL.Context;

namespace SportsStore.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SportsStore.DAL.Entities.CartLine", b =>
                {
                    b.Property<int>("CartLineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartLineId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartLine");
                });

            modelBuilder.Entity("SportsStore.DAL.Entities.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Base64")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("SportsStore.DAL.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GiftWrap")
                        .HasColumnType("bit");

                    b.Property<string>("Line1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Line2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Line3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Shipped")
                        .HasColumnType("bit");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SportsStore.DAL.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("ProductId");

                    b.HasIndex("ImageId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Category = "Watersports",
                            Description = "A boat for one person",
                            Name = "Kayak",
                            Price = 275m
                        },
                        new
                        {
                            ProductId = 2,
                            Category = "Watersports",
                            Description = "Protective and fashionable",
                            Name = "Lifejacket",
                            Price = 48.95m
                        },
                        new
                        {
                            ProductId = 3,
                            Category = "Soccer",
                            Description = "FIFA-approved size and weight",
                            Name = "Soccer Ball",
                            Price = 19.50m
                        },
                        new
                        {
                            ProductId = 4,
                            Category = "Soccer",
                            Description = "Give your playing field a professional touch",
                            Name = "Corner Flags",
                            Price = 39.95m
                        },
                        new
                        {
                            ProductId = 5,
                            Category = "Soccer",
                            Description = "Flat-packed 35,000-seat stadium",
                            Name = "Stadium",
                            Price = 79500m
                        },
                        new
                        {
                            ProductId = 6,
                            Category = "Chess",
                            Description = "Improve brain efficiency by 75%",
                            Name = "Thinking Cap",
                            Price = 16m
                        },
                        new
                        {
                            ProductId = 7,
                            Category = "Chess",
                            Description = "Secretly give your opponent a disadvantage",
                            Name = "Unsteady Chair",
                            Price = 29.95m
                        },
                        new
                        {
                            ProductId = 8,
                            Category = "Chess",
                            Description = "A fun game for family",
                            Name = "Human Chess Board",
                            Price = 75m
                        },
                        new
                        {
                            ProductId = 9,
                            Category = "Chess",
                            Description = "Gold-plated, diamong-studded King",
                            Name = "Bling-Bling King",
                            Price = 1200m
                        });
                });

            modelBuilder.Entity("SportsStore.DAL.Entities.CartLine", b =>
                {
                    b.HasOne("SportsStore.DAL.Entities.Order", null)
                        .WithMany("Lines")
                        .HasForeignKey("OrderId");

                    b.HasOne("SportsStore.DAL.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("SportsStore.DAL.Entities.Product", b =>
                {
                    b.HasOne("SportsStore.DAL.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");
                });
#pragma warning restore 612, 618
        }
    }
}
