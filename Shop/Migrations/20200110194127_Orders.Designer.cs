﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop.Data;

namespace Shop.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20200110194127_Orders")]
    partial class Orders
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shop.Data.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Available");

                    b.Property<int>("CategoryID");

                    b.Property<string>("Img");

                    b.Property<bool>("IsFavourite");

                    b.Property<string>("LongDesc");

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.Property<string>("ShortDesc");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("Shop.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Shop.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<DateTime>("OrderTime");

                    b.Property<string>("Phone");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Shop.Data.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarID");

                    b.Property<int>("OrderID");

                    b.Property<long>("Price");

                    b.HasKey("Id");

                    b.HasIndex("CarID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("Shop.Data.Models.ShopCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CarId");

                    b.Property<int>("Price");

                    b.Property<string>("ShopCardId");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("shopCartItems");
                });

            modelBuilder.Entity("Shop.Data.Models.Car", b =>
                {
                    b.HasOne("Shop.Data.Models.Category", "Category")
                        .WithMany("Cars")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shop.Data.Models.OrderDetail", b =>
                {
                    b.HasOne("Shop.Data.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Shop.Data.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shop.Data.Models.ShopCartItem", b =>
                {
                    b.HasOne("Shop.Data.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId");
                });
#pragma warning restore 612, 618
        }
    }
}