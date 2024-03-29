﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NexaCoreERP.Infrastructure.Persistance;

#nullable disable

namespace NexaCoreERP.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NexaCoreERP.Domain.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments", (string)null);
                });

            modelBuilder.Entity("NexaCoreERP.Domain.Entities.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("QuantityAvailable")
                        .HasColumnType("int");

                    b.Property<int>("SafetyStockLevel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ProductId");

                    b.ToTable("Inventories", (string)null);
                });

            modelBuilder.Entity("NexaCoreERP.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("NexaCoreERP.Domain.Entities.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails", (string)null);
                });

            modelBuilder.Entity("NexaCoreERP.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("NexaCoreERP.Domain.Entities.ProductionOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("ProductionOrders", (string)null);
                });

            modelBuilder.Entity("NexaCoreERP.Domain.Entities.ProductionOrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductionOrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductionOrderId");

                    b.ToTable("ProductionOrderDetails", (string)null);
                });

            modelBuilder.Entity("NexaCoreERP.Domain.Entities.Inventory", b =>
                {
                    b.HasOne("NexaCoreERP.Domain.Entities.Department", "Department")
                        .WithMany("Inventories")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NexaCoreERP.Domain.Entities.Product", "Product")
                        .WithMany("Inventories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("NexaCoreERP.Domain.Entities.Order", b =>
                {
                    b.HasOne("NexaCoreERP.Domain.Entities.Department", "Department")
                        .WithMany("Orders")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("NexaCoreERP.Domain.Entities.OrderDetail", b =>
                {
                    b.HasOne("NexaCoreERP.Domain.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NexaCoreERP.Domain.Entities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("NexaCoreERP.Domain.Entities.ProductionOrder", b =>
                {
                    b.HasOne("NexaCoreERP.Domain.Entities.Department", "Department")
                        .WithMany("ProductionOrders")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NexaCoreERP.Domain.Entities.Order", "Order")
                        .WithOne("ProductionOrder")
                        .HasForeignKey("NexaCoreERP.Domain.Entities.ProductionOrder", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("NexaCoreERP.Domain.Entities.ProductionOrderDetail", b =>
                {
                    b.HasOne("NexaCoreERP.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NexaCoreERP.Domain.Entities.ProductionOrder", "ProductionOrder")
                        .WithMany("ProductionOrderDetails")
                        .HasForeignKey("ProductionOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductionOrder");
                });

            modelBuilder.Entity("NexaCoreERP.Domain.Entities.Department", b =>
                {
                    b.Navigation("Inventories");

                    b.Navigation("Orders");

                    b.Navigation("ProductionOrders");
                });

            modelBuilder.Entity("NexaCoreERP.Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("ProductionOrder");
                });

            modelBuilder.Entity("NexaCoreERP.Domain.Entities.Product", b =>
                {
                    b.Navigation("Inventories");

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("NexaCoreERP.Domain.Entities.ProductionOrder", b =>
                {
                    b.Navigation("ProductionOrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
