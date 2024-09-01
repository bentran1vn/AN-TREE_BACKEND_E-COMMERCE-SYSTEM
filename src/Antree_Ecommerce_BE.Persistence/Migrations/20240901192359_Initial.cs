using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Antree_Ecommerce_BE.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Discount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    Used = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    EndTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phonenumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ProductCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Sku = table.Column<int>(type: "int", nullable: false),
                    Sold = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiscountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Discount_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discount",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Order_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAddress",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Province = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsOrder = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAddress_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPayment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Provider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cvc = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsOrder = table.Column<bool>(type: "bit", nullable: false),
                    Expire = table.Column<DateTimeOffset>(type: "datetimeoffset", maxLength: 20, nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPayment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDiscount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    EndTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDiscount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDiscount_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeedback",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeedback", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFeedback_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductQuantity = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderPayment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cvc = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Expire = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderPayment_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetailFeedback",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetailFeedback", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetailFeedback_OrderDetail_OrderDetailId",
                        column: x => x.OrderDetailId,
                        principalTable: "OrderDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "CreatedBy", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), new Guid("2cd8a571-f443-4623-97dd-c8d4a41a80bf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Des1", false, null, "Cate1", null },
                    { new Guid("8d81bd6c-b108-4611-acee-ef78286eec24"), new Guid("2cd8a571-f443-4623-97dd-c8d4a41a80bf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Des3", false, null, "Cate3", null },
                    { new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), new Guid("2cd8a571-f443-4623-97dd-c8d4a41a80bf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Des2", false, null, "Cate2", null }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreatedBy", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Name", "Price", "ProductCategoryId", "Sku", "Sold", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0577f1e6-dbde-4b10-9ddb-db503eb8b831"), new Guid("e3a837c9-6242-4b0d-8ef0-b8365563c031"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description6", false, null, "Name6", 6m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 6, 6, null },
                    { new Guid("19346825-737b-4a5a-875e-cd70d8f6d1d1"), new Guid("1d371de7-8297-4514-b44c-6031e100a8f4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description39", false, null, "Name39", 39m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 39, 39, null },
                    { new Guid("212af509-b01d-4d88-919e-df8395e3fee1"), new Guid("1397ea10-64f9-4889-ae89-dadb291fe173"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description27", false, null, "Name27", 27m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 27, 27, null },
                    { new Guid("2330fc9e-b75d-4583-9b54-9ee8c3347cc5"), new Guid("768bfc2a-d256-4f5c-8971-bb3af5711121"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description0", false, null, "Name0", 0m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 0, 0, null },
                    { new Guid("252190c1-03a0-4a86-899d-3fdb28acff31"), new Guid("6a8b5b8f-b357-40ed-844b-07409179352c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description29", false, null, "Name29", 29m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 29, 29, null },
                    { new Guid("2f1f5f01-bcb3-4636-b61f-1d6bc82a5159"), new Guid("0aca36c7-b29e-49f1-a663-b5d4d3c6433a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description26", false, null, "Name26", 26m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 26, 26, null },
                    { new Guid("3799fcff-8b87-4d52-a68c-56587193c401"), new Guid("670cdf39-9cd1-4f61-b95e-21f1884b51f4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description22", false, null, "Name22", 22m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 22, 22, null },
                    { new Guid("4354c4dc-c929-4987-986c-8925999d7905"), new Guid("097e3297-292e-4165-b591-f6910a07d660"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description24", false, null, "Name24", 24m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 24, 24, null },
                    { new Guid("51d11706-2096-409b-9827-cf8cbf0b3b88"), new Guid("0c8401f7-1589-4c8c-8759-6a4461d93aef"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description16", false, null, "Name16", 16m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 16, 16, null },
                    { new Guid("52de40d8-6475-45a5-a040-d2679e18aaca"), new Guid("603eca47-5129-4386-bcd7-58b0a13bda76"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description13", false, null, "Name13", 13m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 13, 13, null },
                    { new Guid("5c3da026-5cc2-4391-96b3-fb41ab6d8c44"), new Guid("50a9f110-3767-4f27-a665-60a3decd0742"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description32", false, null, "Name32", 32m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 32, 32, null },
                    { new Guid("5d3b25cb-e2cf-4ef4-970b-8c930aad95ee"), new Guid("357895af-2f73-4009-95f6-7223dacfb2eb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description37", false, null, "Name37", 37m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 37, 37, null },
                    { new Guid("5fbc8723-e6e4-4694-af49-1a09650fe38a"), new Guid("54936421-52b2-401c-8b0b-52ffcdebb67b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description38", false, null, "Name38", 38m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 38, 38, null },
                    { new Guid("64e49550-2ba5-4896-8946-5c3605b42882"), new Guid("062291e4-2153-4e96-981b-9d0a8b747345"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description34", false, null, "Name34", 34m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 34, 34, null },
                    { new Guid("659c806b-110b-4cf5-a035-4f083802abb5"), new Guid("efb198d9-c19d-4c38-9edc-f0232bb5e7b9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description21", false, null, "Name21", 21m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 21, 21, null },
                    { new Guid("68b56f6c-8015-44d7-9c34-058d10988add"), new Guid("667fd852-3de0-46c8-9a3e-03bd10d9705c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description7", false, null, "Name7", 7m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 7, 7, null },
                    { new Guid("69e4887b-07f8-44ba-b7dd-3578265eca34"), new Guid("630f9cdc-8581-46ca-9be7-4a7a41393b1d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description14", false, null, "Name14", 14m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 14, 14, null },
                    { new Guid("72c850a9-a287-4874-9db7-5d8d82a3bbe0"), new Guid("505ae4cf-28d8-4406-8a10-f3ba20490590"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description8", false, null, "Name8", 8m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 8, 8, null },
                    { new Guid("72e346f5-e52e-4c8a-894d-e6033f8badb0"), new Guid("253c853e-08a9-4c03-babb-e157d09a87e6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description20", false, null, "Name20", 20m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 20, 20, null },
                    { new Guid("7b6b0621-a0b7-4ad3-b01d-2e890cd4bb67"), new Guid("e028fb1a-4dd2-4bdf-b8ee-9bd9d4db9241"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description25", false, null, "Name25", 25m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 25, 25, null },
                    { new Guid("7cdc395b-21cc-43e7-a308-695a759fdbb0"), new Guid("3390a695-e365-49d8-9089-afa66e56f1c1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description1", false, null, "Name1", 1m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 1, 1, null },
                    { new Guid("89067620-1c15-4acb-8228-a3875238d78d"), new Guid("93392d1c-072f-48d9-99d1-ea9e2abb0089"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description36", false, null, "Name36", 36m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 36, 36, null },
                    { new Guid("99ddadbb-5ea8-421f-a5a9-7088f665fa0f"), new Guid("ae0342e6-40a3-4e22-8853-2133b2516f27"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description9", false, null, "Name9", 9m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 9, 9, null },
                    { new Guid("9ccfc749-941f-475a-8f49-2d4e7ec81562"), new Guid("5936cd54-d611-45c7-a89d-591ec3d8ccc3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description12", false, null, "Name12", 12m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 12, 12, null },
                    { new Guid("a33db012-332b-40ec-b9da-148f41b18040"), new Guid("dd867d7c-20b2-4ea1-871c-dca77ffd796b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description4", false, null, "Name4", 4m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 4, 4, null },
                    { new Guid("ac109f02-6a32-4ad8-ac54-c2c078f74c2b"), new Guid("be472062-df77-4e27-9efb-17e8b3cf58b2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description23", false, null, "Name23", 23m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 23, 23, null },
                    { new Guid("ad954f72-3b94-4685-aa2f-a5ed4b080eb4"), new Guid("f91ef17a-e65d-4cc5-a9ff-b22900f921ad"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description40", false, null, "Name40", 40m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 40, 40, null },
                    { new Guid("ae2fddf4-2372-449b-86b9-ba571ed5c0b1"), new Guid("bb35387e-212c-4ca5-9aa3-06ab08d6fbcd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description17", false, null, "Name17", 17m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 17, 17, null },
                    { new Guid("b0a5631c-d153-421f-935b-5e939e44eca3"), new Guid("30ff117b-bbc0-4530-ab73-e9e543e69163"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description11", false, null, "Name11", 11m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 11, 11, null },
                    { new Guid("b1cd4d56-362c-4ba3-8397-ffee7b369c12"), new Guid("82d93238-f130-4b0c-8670-23b20ea70875"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description19", false, null, "Name19", 19m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 19, 19, null },
                    { new Guid("b730cac0-6eaf-4af8-b307-cef59da1f2d2"), new Guid("97e681fb-3232-455b-bc35-e1042f8f528b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description33", false, null, "Name33", 33m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 33, 33, null },
                    { new Guid("b9f65c90-eb2b-4231-ba54-b5561b65c97e"), new Guid("5ddbb132-2a60-4434-87e6-9f5116ffa928"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description2", false, null, "Name2", 2m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 2, 2, null },
                    { new Guid("c2846615-3783-4270-b9e1-51c4b7b24d07"), new Guid("4d95d80c-39aa-45f9-904f-55b229813f20"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description31", false, null, "Name31", 31m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 31, 31, null },
                    { new Guid("cd1809a5-f086-4824-bfea-ddf0a2e8b715"), new Guid("02462ac4-2450-47de-bfd6-85d23ce2b753"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description30", false, null, "Name30", 30m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 30, 30, null },
                    { new Guid("cd3ab610-3764-4755-aa15-0970985ea3be"), new Guid("bf28fe51-426a-4595-8f95-c2d7dd64202d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description18", false, null, "Name18", 18m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 18, 18, null },
                    { new Guid("d204eea7-05de-46bf-a08e-c8db32cf6128"), new Guid("a3f31af9-8b5a-4cc1-bc43-5e1e8c8feb4e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description35", false, null, "Name35", 35m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 35, 35, null },
                    { new Guid("dabe49cf-84ac-4bde-8ccc-6d06be4796db"), new Guid("d533050b-68ab-44b5-8a56-3aa245d99475"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description28", false, null, "Name28", 28m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 28, 28, null },
                    { new Guid("df3e6a6f-3b01-4fdd-bab8-ab83241933eb"), new Guid("86aa7ce3-ffcc-4c97-83cd-cb834ad8d3a1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description15", false, null, "Name15", 15m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 15, 15, null },
                    { new Guid("e9118bfb-4af6-4497-85c0-1be203b43f8b"), new Guid("438d3ea2-2e34-4379-bea3-61b610c6c0d4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description10", false, null, "Name10", 10m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 10, 10, null },
                    { new Guid("f57e916f-a21b-4682-ae1d-cb4edf39fd56"), new Guid("904ca93d-759d-46b4-b7ee-bef18c2f60be"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description5", false, null, "Name5", 5m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 5, 5, null },
                    { new Guid("f71d0661-c6ca-43c3-b5fc-2de75896923e"), new Guid("f07f4ee5-3ac5-42a7-986c-89702773e513"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description3", false, null, "Name3", 3m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 3, 3, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_DiscountId",
                table: "Order",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetailFeedback_OrderDetailId",
                table: "OrderDetailFeedback",
                column: "OrderDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPayment_OrderId",
                table: "OrderPayment",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryId",
                table: "Product",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDiscount_ProductId",
                table: "ProductDiscount",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeedback_ProductId",
                table: "ProductFeedback",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddress_UserId",
                table: "UserAddress",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPayment_UserId",
                table: "UserPayment",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetailFeedback");

            migrationBuilder.DropTable(
                name: "OrderPayment");

            migrationBuilder.DropTable(
                name: "ProductDiscount");

            migrationBuilder.DropTable(
                name: "ProductFeedback");

            migrationBuilder.DropTable(
                name: "UserAddress");

            migrationBuilder.DropTable(
                name: "UserPayment");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Discount");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "ProductCategory");
        }
    }
}
