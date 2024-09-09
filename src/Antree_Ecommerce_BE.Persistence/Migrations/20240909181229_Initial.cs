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
                name: "OrderDetailFeedback",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetailFeedback", x => x.Id);
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
                    OrderDetailFeedbackId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductQuantity = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_OrderDetailFeedback_OrderDetailFeedbackId",
                        column: x => x.OrderDetailFeedbackId,
                        principalTable: "OrderDetailFeedback",
                        principalColumn: "Id");
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

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "CreatedBy", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), new Guid("2cd8a571-f443-4623-97dd-c8d4a41a80bf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Des1", false, null, "Cate1", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8d81bd6c-b108-4611-acee-ef78286eec24"), new Guid("2cd8a571-f443-4623-97dd-c8d4a41a80bf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Des3", false, null, "Cate3", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), new Guid("2cd8a571-f443-4623-97dd-c8d4a41a80bf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Des2", false, null, "Cate2", new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreatedBy", "CreatedOnUtc", "Description", "IsDeleted", "ModifiedOnUtc", "Name", "Price", "ProductCategoryId", "Sku", "Sold", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("032c30ad-e370-4d66-8ae1-6e3867fbfe78"), new Guid("6fd0f093-7a77-4419-93ad-434a6de1a925"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description36", false, null, "Name36", 36m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 36, 36, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("035db23f-50a0-42c2-9a8c-4010c284e131"), new Guid("156eba97-5c8d-4bc4-963b-1595a2e0b3ee"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description20", false, null, "Name20", 20m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 20, 20, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("081cd2a3-317b-47e8-86ae-410a0bd8155c"), new Guid("a4eaa2eb-8cbc-44d1-ba80-1d503bf6b6a2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description2", false, null, "Name2", 2m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 2, 2, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0a5a5fab-ec30-48dc-aec6-4600ce5f0d45"), new Guid("8b879138-f5a7-4c9f-97a4-a00501bc758b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description10", false, null, "Name10", 10m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 10, 10, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0ea5a45c-5171-4c03-b6ce-1cb32a68e5b2"), new Guid("0dc53de2-e6c0-424e-afeb-6045f4600646"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description30", false, null, "Name30", 30m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 30, 30, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("10dc944c-f136-4093-851d-92b890ad024d"), new Guid("449ca53b-c168-4bea-9777-17f7ab768f0a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description24", false, null, "Name24", 24m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 24, 24, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("131952c0-4b19-41ba-bb77-096fdd70e5a5"), new Guid("c7097ab3-8d17-4d6d-ad26-704216ddb32a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description34", false, null, "Name34", 34m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 34, 34, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("16e96709-19ee-447e-af59-d6ffc8923c49"), new Guid("770410f5-a3a7-4a74-b583-95f914a00c0d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description38", false, null, "Name38", 38m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 38, 38, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("18551822-d178-410d-b316-e3b7a48f2327"), new Guid("27e45c7b-c128-48ca-99a4-ded505998596"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description7", false, null, "Name7", 7m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 7, 7, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("247df0a4-3cf6-410d-bb95-e220214e0cc5"), new Guid("b2dca98c-8a3b-441c-9632-8e0f378de98c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description8", false, null, "Name8", 8m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 8, 8, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("33e267dc-cab6-44a0-ae9a-f2788325fbe5"), new Guid("c98cecb1-6aed-4a83-aac8-3f3afeeb2577"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description27", false, null, "Name27", 27m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 27, 27, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("399d508e-a90a-46b5-b86f-c3629b0e08f8"), new Guid("ccc97a08-ec49-4497-8e66-61b2a9a54cc8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description33", false, null, "Name33", 33m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 33, 33, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3bdd3813-9151-493e-a925-26aefe58e09f"), new Guid("676ac3af-df7d-4aec-a1f7-78fe9f26a1cd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description1", false, null, "Name1", 1m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 1, 1, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3ed74aa3-3446-4e8f-ad03-afa45af50585"), new Guid("9b2f3c91-9281-4138-9173-759f685a164d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description13", false, null, "Name13", 13m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 13, 13, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3fe4066b-8ff3-4ab9-96e7-5192dc9a3ee6"), new Guid("49eab349-d064-42b2-ab8b-fc75dc8e3bca"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description0", false, null, "Name0", 0m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 0, 0, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4472b9ea-d125-4d16-a43a-2db499858b88"), new Guid("4c2615e3-6bd8-4130-beac-4a49fc1d3466"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description37", false, null, "Name37", 37m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 37, 37, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5e78d482-6d85-47da-8b3e-5a9714a9fbaf"), new Guid("a3a4037e-7043-4e64-bfb3-39ac007e8a90"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description22", false, null, "Name22", 22m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 22, 22, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6230dc70-0501-4424-849b-bc01b403db77"), new Guid("2ca0f38f-bd39-493b-9e1f-250443372c6b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description29", false, null, "Name29", 29m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 29, 29, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("694ebc77-a160-420c-a13c-c4965136de6a"), new Guid("e6bf1a93-3b39-4045-a456-613b34400c15"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description32", false, null, "Name32", 32m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 32, 32, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7e49ce25-9abe-48d3-81f3-b9612d873c17"), new Guid("2daf51fa-b13b-4832-8a07-d5eb45b24897"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description35", false, null, "Name35", 35m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 35, 35, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7f3268fe-8b09-4f06-ad78-18891aeb19de"), new Guid("99054710-cfda-4204-94f8-12ecbe6dd72f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description4", false, null, "Name4", 4m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 4, 4, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("905e2a23-2d1e-490f-90f1-336e35cbd02c"), new Guid("96dd32e0-7ae2-4b8e-a159-34a073b4fdcc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description39", false, null, "Name39", 39m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 39, 39, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("923680b9-5d59-4b79-82cb-31758a8ed49b"), new Guid("a79972ad-0bdd-404f-91c1-292e3aff397f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description17", false, null, "Name17", 17m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 17, 17, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("991b70df-c956-4eb2-9cb8-24bd2627166c"), new Guid("5a6f6608-9b9a-4aae-8f81-e4e6409f4d87"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description28", false, null, "Name28", 28m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 28, 28, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9920f997-a9e0-4b55-b047-a62cb5530a9a"), new Guid("65cd6ceb-cd33-4653-a1b4-7b2c6c13fa83"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description23", false, null, "Name23", 23m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 23, 23, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a3aba024-b0f1-4f6b-96e9-44cce1aaa677"), new Guid("1fca9704-74ea-4928-8cca-25a4f1a13001"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description16", false, null, "Name16", 16m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 16, 16, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a50e82cd-c7f7-4afc-ae3b-78bdf5a97596"), new Guid("a4aa889a-2a8f-4800-8ae8-850a409ec149"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description21", false, null, "Name21", 21m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 21, 21, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a9473748-afc8-48a8-ab01-c9b3f7093b32"), new Guid("1b088875-9624-4355-a494-26ff8c3a6128"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description40", false, null, "Name40", 40m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 40, 40, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("afac6909-4e99-48fc-b191-34b2100be8bd"), new Guid("9fcc41b6-20c6-49cc-8962-9bb5f36adb39"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description26", false, null, "Name26", 26m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 26, 26, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("bd1fe782-4254-4ca9-9155-84a951f56e41"), new Guid("fdc463b1-86a7-4e35-af7d-62adbe226fa8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description3", false, null, "Name3", 3m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 3, 3, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("bde358c3-0848-49fe-a11b-decaf8529674"), new Guid("b20657c5-ffcb-4ca4-8707-907bfa4ac086"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description5", false, null, "Name5", 5m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 5, 5, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("cc62bc1a-0ba8-4ad8-a9c8-b45efc95362c"), new Guid("faafc77c-80c2-4ecb-9cf7-f562aee3ac01"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description14", false, null, "Name14", 14m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 14, 14, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d22bc410-8c42-4ad8-9042-f18476e6b20f"), new Guid("e609eb4c-0d92-41ef-899a-0b80bc45edd6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description9", false, null, "Name9", 9m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 9, 9, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("dc8171e6-30b6-429f-a0c3-2620320d1cd0"), new Guid("cbbd6f60-df43-48a8-a5da-dde02c90831b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description11", false, null, "Name11", 11m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 11, 11, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("de611e5d-dc15-4449-ae36-9b9fe9815464"), new Guid("0193206d-5591-4e57-9407-3e6f486308b2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description19", false, null, "Name19", 19m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 19, 19, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e0547aff-d5b2-4692-ba7d-255676c464eb"), new Guid("0a2b8964-897d-44ba-974b-06e05a45da98"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description31", false, null, "Name31", 31m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 31, 31, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e4256ddf-4fa6-4196-8bf3-52b49d0f39bd"), new Guid("e215df14-2fdb-43d1-8dc3-7b4d614ec238"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description18", false, null, "Name18", 18m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 18, 18, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("eb6f88b9-3b1c-4ca1-9bfd-cfd8c8c2ceb1"), new Guid("d1320b2b-2c4a-4c9d-aa48-99e4ee1e2352"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description12", false, null, "Name12", 12m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 12, 12, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ec537ead-ee34-4c93-a8b1-cd900f45a585"), new Guid("f9f18f22-48bb-4496-be24-343f4d720926"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description15", false, null, "Name15", 15m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 15, 15, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f7ff267b-8dd5-4c25-9d72-693c072e33fd"), new Guid("7cfb18c9-1f71-41d4-92fc-4c10f4e1b393"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description25", false, null, "Name25", 25m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 25, 25, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fe2092ac-8b61-40cb-944b-399a839fea2e"), new Guid("4c97716a-09f7-419d-b578-f91d382dc22b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description6", false, null, "Name6", 6m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 6, 6, new Guid("00000000-0000-0000-0000-000000000000") }
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
                name: "IX_OrderDetail_OrderDetailFeedbackId",
                table: "OrderDetail",
                column: "OrderDetailFeedbackId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail",
                column: "ProductId");

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
                name: "OrderDetail");

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
                name: "OrderDetailFeedback");

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
