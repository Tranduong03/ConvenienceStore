using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroceryStore.Migrations
{
    /// <inheritdoc />
    public partial class NewModelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATEGORY",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORY", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "CUSTOMER",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1001, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    FCoin = table.Column<float>(type: "real", nullable: false, defaultValue:0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUSTOMER", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "SUPPLIER",
                columns: table => new
                {
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Contact = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUPPLIER", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "USERS",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "101, 1"),
                    UserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true, defaultValue: "Tên người dùng"),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    ImgLink = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValue: "default.png"),
                    Role = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USERS", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1001, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false, defaultValue: "Tên sản phẩm"),
                    SellPrice = table.Column<decimal>(type: "decimal(10,0)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true, defaultValue: "Sản phẩm này không có mô tả"),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    ImageLink = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true, defaultValue: "none.png"),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    SupplierID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCT", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_PRODUCT_CATEGORY_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "CATEGORY",
                        principalColumn: "CategoryID");
                    table.ForeignKey(
                        name: "FK_PRODUCT_SUPPLIER_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "SUPPLIER",
                        principalColumn: "SupplierID");
                });

            migrationBuilder.CreateTable(
                name: "BILL",
                columns: table => new
                {
                    BillID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1001, 1"),
                    BillDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BILL", x => x.BillID);
                    table.ForeignKey(
                        name: "FK_BILL_CUSTOMER_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "CUSTOMER",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK_BILL_USERS_UserID",
                        column: x => x.UserID,
                        principalTable: "USERS",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "IMPORT",
                columns: table => new
                {
                    ImportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "101, 1"),
                    ImportDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    TotalCost = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageLink = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMPORT", x => x.ImportID);
                    table.ForeignKey(
                        name: "FK_IMPORT_USERS_UserID",
                        column: x => x.UserID,
                        principalTable: "USERS",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "BILLDETAIL",
                columns: table => new
                {
                    BillDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10001, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BillID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BILLDETAIL", x => x.BillDetailID);
                    table.ForeignKey(
                        name: "FK_BILLDETAIL_BILL_BillID",
                        column: x => x.BillID,
                        principalTable: "BILL",
                        principalColumn: "BillID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BILLDETAIL_PRODUCT_ProductID",
                        column: x => x.ProductID,
                        principalTable: "PRODUCT",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IMPORTDETAIL",
                columns: table => new
                {
                    DetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1001, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(10,0)", nullable: false),
                    ImportID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMPORTDETAIL", x => x.DetailID);
                    table.ForeignKey(
                        name: "FK_IMPORTDETAIL_IMPORT_ImportID",
                        column: x => x.ImportID,
                        principalTable: "IMPORT",
                        principalColumn: "ImportID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IMPORTDETAIL_PRODUCT_ProductID",
                        column: x => x.ProductID,
                        principalTable: "PRODUCT",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IMPORTDETAIL_SUPPLIER_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "SUPPLIER",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BILL_CustomerID",
                table: "BILL",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_BILL_UserID",
                table: "BILL",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_BILLDETAIL_BillID",
                table: "BILLDETAIL",
                column: "BillID");

            migrationBuilder.CreateIndex(
                name: "IX_BILLDETAIL_ProductID",
                table: "BILLDETAIL",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_IMPORT_UserID",
                table: "IMPORT",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_IMPORTDETAIL_ImportID",
                table: "IMPORTDETAIL",
                column: "ImportID");

            migrationBuilder.CreateIndex(
                name: "IX_IMPORTDETAIL_ProductID",
                table: "IMPORTDETAIL",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_IMPORTDETAIL_SupplierID",
                table: "IMPORTDETAIL",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_CategoryID",
                table: "PRODUCT",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_SupplierID",
                table: "PRODUCT",
                column: "SupplierID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BILLDETAIL");

            migrationBuilder.DropTable(
                name: "IMPORTDETAIL");

            migrationBuilder.DropTable(
                name: "BILL");

            migrationBuilder.DropTable(
                name: "IMPORT");

            migrationBuilder.DropTable(
                name: "PRODUCT");

            migrationBuilder.DropTable(
                name: "CUSTOMER");

            migrationBuilder.DropTable(
                name: "USERS");

            migrationBuilder.DropTable(
                name: "CATEGORY");

            migrationBuilder.DropTable(
                name: "SUPPLIER");
        }
    }
}
