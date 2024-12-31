﻿// <auto-generated />
using System;
using GroceryStore.OtherProcess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GroceryStore.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20241223155609_User-changge")]
    partial class Userchangge
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GroceryStore.Model.Bill", b =>
                {
                    b.Property<int>("BillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillID"));

                    b.Property<DateTime>("BillDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.Property<decimal?>("TotalCost")
                        .HasColumnType("decimal(18,0)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("BillID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("UserID");

                    b.ToTable("BILL");
                });

            modelBuilder.Entity("GroceryStore.Model.BillDetail", b =>
                {
                    b.Property<int>("BillDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillDetailID"));

                    b.Property<int>("BillID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BillDetailID");

                    b.HasIndex("BillID");

                    b.HasIndex("ProductID");

                    b.ToTable("BILLDETAIL");
                });

            modelBuilder.Entity("GroceryStore.Model.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("CName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("CategoryID");

                    b.ToTable("CATEGORY");
                });

            modelBuilder.Entity("GroceryStore.Model.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<float>("FCoin")
                        .HasColumnType("real");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("CustomerID");

                    b.ToTable("CUSTOMER");
                });

            modelBuilder.Entity("GroceryStore.Model.Import", b =>
                {
                    b.Property<int>("ImportID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImportID"));

                    b.Property<string>("ImageLink")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("ImportDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("TotalCost")
                        .HasColumnType("decimal(18,0)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ImportID");

                    b.HasIndex("UserID");

                    b.ToTable("IMPORT");
                });

            modelBuilder.Entity("GroceryStore.Model.ImportDetail", b =>
                {
                    b.Property<int>("DetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetailID"));

                    b.Property<int>("ImportID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SupplierID")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(10,0)");

                    b.HasKey("DetailID");

                    b.HasIndex("ImportID");

                    b.HasIndex("ProductID");

                    b.HasIndex("SupplierID");

                    b.ToTable("IMPORTDETAIL");
                });

            modelBuilder.Entity("GroceryStore.Model.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ImageLink")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<decimal>("SellPrice")
                        .HasColumnType("decimal(10,0)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int?>("SupplierID")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("SupplierID");

                    b.ToTable("PRODUCT");
                });

            modelBuilder.Entity("GroceryStore.Model.Supplier", b =>
                {
                    b.Property<int>("SupplierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierID"));

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Contact")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Email")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("SupplierID");

                    b.ToTable("SUPPLIER");
                });

            modelBuilder.Entity("GroceryStore.Model.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("FullName")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<bool?>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("ImgLink")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("Role")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("UserID");

                    b.ToTable("USERS");
                });

            modelBuilder.Entity("GroceryStore.Model.Bill", b =>
                {
                    b.HasOne("GroceryStore.Model.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID");

                    b.HasOne("GroceryStore.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");

                    b.Navigation("Customer");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GroceryStore.Model.BillDetail", b =>
                {
                    b.HasOne("GroceryStore.Model.Bill", "Bill")
                        .WithMany()
                        .HasForeignKey("BillID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GroceryStore.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("GroceryStore.Model.Import", b =>
                {
                    b.HasOne("GroceryStore.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GroceryStore.Model.ImportDetail", b =>
                {
                    b.HasOne("GroceryStore.Model.Import", "Import")
                        .WithMany()
                        .HasForeignKey("ImportID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GroceryStore.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GroceryStore.Model.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Import");

                    b.Navigation("Product");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("GroceryStore.Model.Product", b =>
                {
                    b.HasOne("GroceryStore.Model.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID");

                    b.HasOne("GroceryStore.Model.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierID");

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });
#pragma warning restore 612, 618
        }
    }
}
