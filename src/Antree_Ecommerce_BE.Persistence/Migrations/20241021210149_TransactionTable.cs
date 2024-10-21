using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Antree_Ecommerce_BE.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class TransactionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("059b7ef8-d70f-4102-a42b-2c51a89baa7d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("05a7abb8-20dc-442e-b142-e2774a1b3849"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0c2633ed-ad73-42b3-b955-78b5376bad01"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0eb6901b-e426-4127-b404-ddc87457ee64"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1073a688-c0d1-4ba7-9fe2-aa24b60d14fb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("15fb32b6-4ba7-4b25-b489-d94f778827cf"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1de91c95-6332-420e-961f-fa12c0f5e161"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("22a47049-d139-41bb-ba39-1719d5a82c88"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("26d7ec30-7479-4677-b8d6-8a00b3d731dd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2b4c2e8a-6266-46ce-8d8a-28adbef856f1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3c1611e8-2782-4a28-80d9-52dc97d6214c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("452334b9-b1e3-49e0-b2a6-32006cdf1da8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("456851a1-1ac0-4021-ab6d-8f4f0f1cf121"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("47567503-e129-4e04-80b8-3383fd754fad"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("48dba51a-1c8c-49ac-9638-74d57c4aefb6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5a082098-80bb-4040-b4bf-d7af85c9a463"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5cc1f3d2-826e-4bf2-b1c2-45cd6d994199"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("620df071-72ff-43cc-a956-54552448d81a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6660b4f2-2627-4c99-93b3-b886e49ffcd4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6a2d1ab9-0fb1-4d25-8ea9-d64b2ddbcb02"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6c2c7302-2ab5-454f-992e-1fb5644c3bbc"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("71920841-5c57-4ab9-9577-946e8076de6e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("757c886a-b61a-4a9e-802a-8d855e41dbb7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7781d433-1954-42af-b15a-ed002df556d4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7e15374e-46f7-4281-a592-4b9ca2b3bc93"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8942b6a2-7aed-4d75-92ad-94cfa22657c3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8c761dd7-7cac-4fee-a88f-06b73f3615f4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8d2c07ab-f7e8-43ec-957f-9e080f386cb5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("94270a02-4c08-4dae-9555-98737ed851f1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9ca88eb6-80db-428a-bd92-416d3bd2e3ea"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9e917dd4-74c4-49b1-8043-a01e24c6ce49"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9fa06791-7e61-4ee7-a55c-31650cca06da"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9fef12e0-cdae-4a30-a057-595baf28b2a6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a8cee3d1-fc85-4008-b902-b734ea85c2e9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("af689836-13e0-4a2e-8a49-a14c324800ce"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("afdec7b0-1065-48d8-bc54-f1f44b75e3d9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b2a5a535-5f15-4b99-a697-5e4cd8234e48"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d0f6cbb8-6421-44b5-8a46-bb9038555d73"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("daf14424-161b-4733-8f83-38b662653932"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f8889260-07ce-43e7-ac3f-6146f2308d48"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f8944915-e1bc-4386-abf3-db60285b5578"));

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transaction_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CoverImage", "CreatedBy", "CreatedOnUtc", "Description", "DiscountPercent", "DiscountSold", "IsDeleted", "ModifiedOnUtc", "Name", "Price", "ProductCategoryId", "Sku", "Sold", "UpdatedBy", "VendorId" },
                values: new object[,]
                {
                    { new Guid("076b0d49-ee98-45aa-a900-a263e9233fbe"), "", new Guid("f1d9e2b6-8ba2-485a-813d-6ad82c707346"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description24", 0m, 24000m, false, null, "Name24", 24000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 24, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("083961c4-3265-4f32-970f-e3f4323da29f"), "", new Guid("d7495c60-e848-4bc8-8d6e-19aa57f18eda"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description19", 0m, 19000m, false, null, "Name19", 19000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 19, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("13bf9dd3-d8f8-401f-8c08-601e9fa34ae0"), "", new Guid("86d4d200-1b0f-4b42-a0e4-20c0a568c156"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description18", 0m, 18000m, false, null, "Name18", 18000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 18, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("1d09fe4e-7646-4df5-96ba-8cca4200f81c"), "", new Guid("76e1c270-23ae-497a-8137-23eca63c841f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description9", 0m, 9000m, false, null, "Name9", 9000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 9, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("1d9c7bf9-6e33-4951-8d9f-8ca1e83bb34a"), "", new Guid("a15688a6-3a53-45ae-b397-b8fb1f08e17d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description25", 0m, 25000m, false, null, "Name25", 25000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 25, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("2cfaa0c6-0028-4969-a5fc-8cd9e4b662cd"), "", new Guid("7caccd9f-e63b-4ffd-b265-bd20f0217b61"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description32", 0m, 32000m, false, null, "Name32", 32000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 32, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("300a3d1d-fab9-4e3b-87c1-e320e2ad5430"), "", new Guid("3f94a0d2-ebed-4b6b-bc89-65d428a53577"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description7", 0m, 7000m, false, null, "Name7", 7000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 7, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("33c730dd-b204-4db3-ba06-0e08ec4b8307"), "", new Guid("44dcd4f7-e7b4-4486-9231-b78a00329c16"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description13", 0m, 13000m, false, null, "Name13", 13000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 13, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("34b8dd1d-2f8b-4a7e-9fcb-5fead1e57928"), "", new Guid("a932c5a4-fc43-4eba-a294-ed8eb7e9c232"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description11", 0m, 11000m, false, null, "Name11", 11000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 11, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("39ac6509-d0f1-41ce-bbdf-0a04cc95d129"), "", new Guid("2949a011-8500-4082-8b4d-9c5ec5081f52"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description20", 0m, 20000m, false, null, "Name20", 20000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 20, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("3a785ee1-63fe-447b-9a3e-0bf7a37d0709"), "", new Guid("594b3f50-a019-41f7-aaf6-89f0889bae5f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description27", 0m, 27000m, false, null, "Name27", 27000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 27, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("3f8f5804-9fc5-40a6-9962-1a451f8ad892"), "", new Guid("55aa42b5-bf06-4903-bba5-e18215ee2de4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description36", 0m, 36000m, false, null, "Name36", 36000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 36, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("4b9f3540-0621-489a-8654-422b3bcfcd07"), "", new Guid("54aa4272-0def-4d11-a4bc-f404850e71ea"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description31", 0m, 31000m, false, null, "Name31", 31000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 31, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("4fbdb1ef-22f7-4bce-950b-f09f1196efdd"), "", new Guid("e700382a-e25e-4e02-a522-610628a32c15"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description29", 0m, 29000m, false, null, "Name29", 29000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 29, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("50da51d7-c286-4fb4-97ce-b243cb2a53a8"), "", new Guid("3726eb6e-960f-4fab-9dab-786f3850f841"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description15", 0m, 15000m, false, null, "Name15", 15000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 15, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("54e7c36e-7ea3-4c53-9c73-529fee6da613"), "", new Guid("353834ee-2952-40d0-af3e-88ff8bd75cca"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description4", 0m, 4000m, false, null, "Name4", 4000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 4, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("5c932d34-35f9-400b-95ee-3f921bffff7b"), "", new Guid("ac4cb5e0-7c00-4211-a2d7-4a9d3ac03cb5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description34", 0m, 34000m, false, null, "Name34", 34000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 34, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("645f005f-63de-44cb-8efc-a522373631a4"), "", new Guid("13d96a06-c6c6-45a3-a4d6-c12e85fb3e44"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description17", 0m, 17000m, false, null, "Name17", 17000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 17, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("76ac8631-69fa-4b2a-adc1-83d5cddbeaa6"), "", new Guid("517ca369-a87a-444d-8e4f-ccd69f835985"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description21", 0m, 21000m, false, null, "Name21", 21000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 21, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("76ed6d1d-d2d0-498d-9bdb-c301827a7859"), "", new Guid("aa463bb3-9695-4ac6-81d7-ee7321451610"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description5", 0m, 5000m, false, null, "Name5", 5000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 5, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("8af86a05-1a76-4c56-9689-0db2ca05e9cc"), "", new Guid("e4201efa-760e-4ddb-8a53-6ef9a862b1d1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description30", 0m, 30000m, false, null, "Name30", 30000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 30, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("9199304e-937f-458f-83aa-de494089a872"), "", new Guid("7258fabf-026f-4f48-aebe-53a5160fa432"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description6", 0m, 6000m, false, null, "Name6", 6000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 6, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("9b4ebade-04ac-4845-bbbb-9f797b4fe252"), "", new Guid("555e5442-0d26-4eee-9587-bf2a80d57ca7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description26", 0m, 26000m, false, null, "Name26", 26000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 26, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("a0d79dbf-4d1b-4535-961e-101eb5b64639"), "", new Guid("ac35eeb2-89a5-4d12-9dd7-beb90ca99b0c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description22", 0m, 22000m, false, null, "Name22", 22000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 22, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("aaff4e13-ca51-4ee0-87f6-7b641c40fb18"), "", new Guid("ff85a7bf-11c7-4ae5-8be0-9a261fe1d4da"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description28", 0m, 28000m, false, null, "Name28", 28000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 28, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("b099b093-0e43-487c-a032-e1ef457550cd"), "", new Guid("b3756c5d-0a80-447e-b0ff-62f2006e0eef"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description1", 0m, 1000m, false, null, "Name1", 1000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 1, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("ba9982b2-2769-4060-980a-84ac7c8c76de"), "", new Guid("e45dd332-523e-4119-9feb-565a037e522c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description37", 0m, 37000m, false, null, "Name37", 37000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 37, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("bc5f7f9b-4b4e-4dd7-abf2-e01fac225102"), "", new Guid("f1d693a6-0673-46af-9a42-bea5fa0ba367"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description38", 0m, 38000m, false, null, "Name38", 38000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 38, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("bd6597bb-6b86-4a2e-8db8-e97738faa85a"), "", new Guid("2cb78d52-2748-4c87-b662-ce56de1eeafa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description2", 0m, 2000m, false, null, "Name2", 2000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 2, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("bd9ed5ed-419d-4b31-8baf-af81512d1f34"), "", new Guid("1f5d5810-e2f8-4f8e-b812-f85575734a05"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description8", 0m, 8000m, false, null, "Name8", 8000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 8, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("c2d6bc2d-e1dd-487a-9d14-69741274878b"), "", new Guid("aa4a3805-1b45-4505-ab23-ecdcb0bfad04"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description33", 0m, 33000m, false, null, "Name33", 33000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 33, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("cfbf943c-1873-4a40-ba53-6260a3dfe6cc"), "", new Guid("f7654475-ee31-4574-ac96-84c08ef21c81"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description0", 0m, 0m, false, null, "Name0", 0m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("e5af5517-1cf4-4da7-b9d5-3d513ab8b9c6"), "", new Guid("e16f2cd9-1c48-4348-a07a-063a6a30f712"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description40", 0m, 40000m, false, null, "Name40", 40000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 40, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("e8e2afc9-d2f1-4c1a-beda-e84184dc08f3"), "", new Guid("f7e2308d-99a4-4120-bd54-2b26ebe538c3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description12", 0m, 12000m, false, null, "Name12", 12000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 12, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("edfa3409-88a7-46fa-9641-27020ae2efcb"), "", new Guid("868f3b4c-9540-44dc-b6eb-f6c6630baf04"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description10", 0m, 10000m, false, null, "Name10", 10000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 10, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("f1d75a56-7457-4280-8062-d7dd54166f14"), "", new Guid("ad6796db-f041-4d1c-a2a5-49ef98550f32"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description14", 0m, 14000m, false, null, "Name14", 14000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 14, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("f8db2be6-9811-4ab3-9a6d-5c110f75f34f"), "", new Guid("9f8d35c5-adb6-49e5-87b1-a40f5bd4a145"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description39", 0m, 39000m, false, null, "Name39", 39000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 39, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("f8e06597-00ab-456d-925f-232b4ffdb7d6"), "", new Guid("641b7d4d-aaeb-4a48-b1b4-0b25013d50cf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description23", 0m, 23000m, false, null, "Name23", 23000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 23, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("f9fdc4c7-e788-4fc9-9040-7abdfe90af02"), "", new Guid("12b42d69-2e8f-4e00-b889-9c4c83cb0e22"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description3", 0m, 3000m, false, null, "Name3", 3000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 3, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("fd9f36bf-36bb-477c-a579-abaed583caed"), "", new Guid("1ef4a3d6-5d87-4bfd-89b1-6f987423e392"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description35", 0m, 35000m, false, null, "Name35", 35000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 35, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("ffe7b87a-7ea5-468d-b5f9-dcb970a90434"), "", new Guid("93ef4861-00e7-4df6-89d4-ae678a655bf4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description16", 0m, 16000m, false, null, "Name16", 16000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 16, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_UserId",
                table: "Transaction",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("076b0d49-ee98-45aa-a900-a263e9233fbe"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("083961c4-3265-4f32-970f-e3f4323da29f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("13bf9dd3-d8f8-401f-8c08-601e9fa34ae0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1d09fe4e-7646-4df5-96ba-8cca4200f81c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1d9c7bf9-6e33-4951-8d9f-8ca1e83bb34a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2cfaa0c6-0028-4969-a5fc-8cd9e4b662cd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("300a3d1d-fab9-4e3b-87c1-e320e2ad5430"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("33c730dd-b204-4db3-ba06-0e08ec4b8307"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("34b8dd1d-2f8b-4a7e-9fcb-5fead1e57928"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("39ac6509-d0f1-41ce-bbdf-0a04cc95d129"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3a785ee1-63fe-447b-9a3e-0bf7a37d0709"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3f8f5804-9fc5-40a6-9962-1a451f8ad892"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4b9f3540-0621-489a-8654-422b3bcfcd07"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4fbdb1ef-22f7-4bce-950b-f09f1196efdd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("50da51d7-c286-4fb4-97ce-b243cb2a53a8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("54e7c36e-7ea3-4c53-9c73-529fee6da613"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5c932d34-35f9-400b-95ee-3f921bffff7b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("645f005f-63de-44cb-8efc-a522373631a4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("76ac8631-69fa-4b2a-adc1-83d5cddbeaa6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("76ed6d1d-d2d0-498d-9bdb-c301827a7859"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8af86a05-1a76-4c56-9689-0db2ca05e9cc"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9199304e-937f-458f-83aa-de494089a872"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9b4ebade-04ac-4845-bbbb-9f797b4fe252"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a0d79dbf-4d1b-4535-961e-101eb5b64639"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("aaff4e13-ca51-4ee0-87f6-7b641c40fb18"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b099b093-0e43-487c-a032-e1ef457550cd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ba9982b2-2769-4060-980a-84ac7c8c76de"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("bc5f7f9b-4b4e-4dd7-abf2-e01fac225102"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("bd6597bb-6b86-4a2e-8db8-e97738faa85a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("bd9ed5ed-419d-4b31-8baf-af81512d1f34"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c2d6bc2d-e1dd-487a-9d14-69741274878b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("cfbf943c-1873-4a40-ba53-6260a3dfe6cc"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e5af5517-1cf4-4da7-b9d5-3d513ab8b9c6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e8e2afc9-d2f1-4c1a-beda-e84184dc08f3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("edfa3409-88a7-46fa-9641-27020ae2efcb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f1d75a56-7457-4280-8062-d7dd54166f14"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f8db2be6-9811-4ab3-9a6d-5c110f75f34f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f8e06597-00ab-456d-925f-232b4ffdb7d6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f9fdc4c7-e788-4fc9-9040-7abdfe90af02"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("fd9f36bf-36bb-477c-a579-abaed583caed"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ffe7b87a-7ea5-468d-b5f9-dcb970a90434"));

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CoverImage", "CreatedBy", "CreatedOnUtc", "Description", "DiscountPercent", "DiscountSold", "IsDeleted", "ModifiedOnUtc", "Name", "Price", "ProductCategoryId", "Sku", "Sold", "UpdatedBy", "VendorId" },
                values: new object[,]
                {
                    { new Guid("059b7ef8-d70f-4102-a42b-2c51a89baa7d"), "", new Guid("267676c2-e3a3-4f24-94dd-d2d69d5535e1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description18", 0m, 18000m, false, null, "Name18", 18000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 18, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("05a7abb8-20dc-442e-b142-e2774a1b3849"), "", new Guid("5bce0957-029c-4c28-9126-f9a529a371c0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description1", 0m, 1000m, false, null, "Name1", 1000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 1, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("0c2633ed-ad73-42b3-b955-78b5376bad01"), "", new Guid("6e2b94f5-7193-4bab-be3e-d1ae09dce55b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description38", 0m, 38000m, false, null, "Name38", 38000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 38, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("0eb6901b-e426-4127-b404-ddc87457ee64"), "", new Guid("a8fdb26f-4ebc-41a4-a5ae-e3540b74ed5b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description10", 0m, 10000m, false, null, "Name10", 10000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 10, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("1073a688-c0d1-4ba7-9fe2-aa24b60d14fb"), "", new Guid("bbf829de-dcfc-45e8-9f9b-e75772216a6d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description25", 0m, 25000m, false, null, "Name25", 25000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 25, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("15fb32b6-4ba7-4b25-b489-d94f778827cf"), "", new Guid("966b5c5f-fdb4-46b9-af80-17108bc7a33e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description22", 0m, 22000m, false, null, "Name22", 22000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 22, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("1de91c95-6332-420e-961f-fa12c0f5e161"), "", new Guid("3942dee4-df76-4b26-a040-e58158631869"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description30", 0m, 30000m, false, null, "Name30", 30000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 30, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("22a47049-d139-41bb-ba39-1719d5a82c88"), "", new Guid("744a23fb-39ff-4715-b519-c58870b1798f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description13", 0m, 13000m, false, null, "Name13", 13000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 13, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("26d7ec30-7479-4677-b8d6-8a00b3d731dd"), "", new Guid("12c840ad-c479-45cd-88ea-0df25065f2b6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description29", 0m, 29000m, false, null, "Name29", 29000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 29, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("2b4c2e8a-6266-46ce-8d8a-28adbef856f1"), "", new Guid("96c188ae-1c16-4dbb-81ed-44309a8bd1ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description6", 0m, 6000m, false, null, "Name6", 6000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 6, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("3c1611e8-2782-4a28-80d9-52dc97d6214c"), "", new Guid("5af65fcf-bc77-42a8-942b-b764b1f7a471"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description37", 0m, 37000m, false, null, "Name37", 37000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 37, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("452334b9-b1e3-49e0-b2a6-32006cdf1da8"), "", new Guid("4683425d-a531-477d-af51-b51c71c9876d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description17", 0m, 17000m, false, null, "Name17", 17000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 17, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("456851a1-1ac0-4021-ab6d-8f4f0f1cf121"), "", new Guid("5b1d2d8e-d31b-4e53-a374-1802a8c792e5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description32", 0m, 32000m, false, null, "Name32", 32000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 32, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("47567503-e129-4e04-80b8-3383fd754fad"), "", new Guid("3ac0e837-44b6-4d76-9b38-6861f191f0fc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description39", 0m, 39000m, false, null, "Name39", 39000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 39, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("48dba51a-1c8c-49ac-9638-74d57c4aefb6"), "", new Guid("15f79e6a-49ec-49f5-bf22-e76faf3b8ed0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description2", 0m, 2000m, false, null, "Name2", 2000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 2, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("5a082098-80bb-4040-b4bf-d7af85c9a463"), "", new Guid("37861b98-20c6-4bc0-9a2e-096843c5a9f8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description3", 0m, 3000m, false, null, "Name3", 3000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 3, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("5cc1f3d2-826e-4bf2-b1c2-45cd6d994199"), "", new Guid("351cf476-5a86-4b43-9243-5a31c99f5a26"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description27", 0m, 27000m, false, null, "Name27", 27000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 27, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("620df071-72ff-43cc-a956-54552448d81a"), "", new Guid("4afa8e33-40b8-4182-8fdb-a1118bd0689b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description26", 0m, 26000m, false, null, "Name26", 26000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 26, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("6660b4f2-2627-4c99-93b3-b886e49ffcd4"), "", new Guid("75de2af9-9b4c-42f0-9f15-bd19304f4ecc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description11", 0m, 11000m, false, null, "Name11", 11000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 11, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("6a2d1ab9-0fb1-4d25-8ea9-d64b2ddbcb02"), "", new Guid("db4620ed-4a5d-4e15-a352-2dae64a5759f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description14", 0m, 14000m, false, null, "Name14", 14000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 14, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("6c2c7302-2ab5-454f-992e-1fb5644c3bbc"), "", new Guid("3fe616b6-919c-45cd-a916-d711e2838226"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description40", 0m, 40000m, false, null, "Name40", 40000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 40, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("71920841-5c57-4ab9-9577-946e8076de6e"), "", new Guid("69602954-7d32-40ce-8016-a354dec8f148"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description4", 0m, 4000m, false, null, "Name4", 4000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 4, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("757c886a-b61a-4a9e-802a-8d855e41dbb7"), "", new Guid("e5e97010-96a5-4272-a043-4169aee7175a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description23", 0m, 23000m, false, null, "Name23", 23000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 23, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("7781d433-1954-42af-b15a-ed002df556d4"), "", new Guid("018ed0a5-70f9-4012-879d-a09f63fd6fb7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description15", 0m, 15000m, false, null, "Name15", 15000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 15, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("7e15374e-46f7-4281-a592-4b9ca2b3bc93"), "", new Guid("08fd74b1-5cc0-4523-b9f6-c7088172edc1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description12", 0m, 12000m, false, null, "Name12", 12000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 12, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("8942b6a2-7aed-4d75-92ad-94cfa22657c3"), "", new Guid("3ac25786-8e9e-45f2-8c32-4bfeb442ccea"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description24", 0m, 24000m, false, null, "Name24", 24000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 24, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("8c761dd7-7cac-4fee-a88f-06b73f3615f4"), "", new Guid("5ef9a426-52a8-4c4e-a74d-68d6d1e9fee7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description33", 0m, 33000m, false, null, "Name33", 33000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 33, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("8d2c07ab-f7e8-43ec-957f-9e080f386cb5"), "", new Guid("66612cfd-9f3e-4b78-9aa4-f2f3fd94d140"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description21", 0m, 21000m, false, null, "Name21", 21000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 21, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("94270a02-4c08-4dae-9555-98737ed851f1"), "", new Guid("af22cb60-e38f-4b02-bad3-3cf73080d086"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description36", 0m, 36000m, false, null, "Name36", 36000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 36, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("9ca88eb6-80db-428a-bd92-416d3bd2e3ea"), "", new Guid("0e0bc4a6-16dd-4b27-a8c8-e59824d0354e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description8", 0m, 8000m, false, null, "Name8", 8000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 8, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("9e917dd4-74c4-49b1-8043-a01e24c6ce49"), "", new Guid("aee78ef7-0def-46e0-872c-cea1680add43"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description16", 0m, 16000m, false, null, "Name16", 16000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 16, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("9fa06791-7e61-4ee7-a55c-31650cca06da"), "", new Guid("2cc8b19c-b4f4-4fcc-bbf3-4da48248b874"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description7", 0m, 7000m, false, null, "Name7", 7000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 7, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("9fef12e0-cdae-4a30-a057-595baf28b2a6"), "", new Guid("f585f9c0-a53c-49a6-8b07-d3bfdf1b31a6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description28", 0m, 28000m, false, null, "Name28", 28000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 28, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("a8cee3d1-fc85-4008-b902-b734ea85c2e9"), "", new Guid("5724965a-b888-4400-b5d6-ae15b6276f25"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description20", 0m, 20000m, false, null, "Name20", 20000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 20, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("af689836-13e0-4a2e-8a49-a14c324800ce"), "", new Guid("13f9a379-fa2f-459c-917c-8e53c4190184"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description5", 0m, 5000m, false, null, "Name5", 5000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 5, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("afdec7b0-1065-48d8-bc54-f1f44b75e3d9"), "", new Guid("ef6edf4e-8fb1-47de-aa69-be94912a5610"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description35", 0m, 35000m, false, null, "Name35", 35000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 35, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("b2a5a535-5f15-4b99-a697-5e4cd8234e48"), "", new Guid("1f55c6ba-f57b-4b08-9e08-c54f388a677b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description34", 0m, 34000m, false, null, "Name34", 34000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 34, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("d0f6cbb8-6421-44b5-8a46-bb9038555d73"), "", new Guid("b0fcf67e-0d47-4bca-8b11-1e658f4817a3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description0", 0m, 0m, false, null, "Name0", 0m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("daf14424-161b-4733-8f83-38b662653932"), "", new Guid("228bca8e-cd1b-4ff7-87df-eac56d775986"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description19", 0m, 19000m, false, null, "Name19", 19000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 19, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("f8889260-07ce-43e7-ac3f-6146f2308d48"), "", new Guid("e0f869d4-42d2-430d-b2cf-c87289b68233"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description31", 0m, 31000m, false, null, "Name31", 31000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 31, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("f8944915-e1bc-4386-abf3-db60285b5578"), "", new Guid("153ffad0-3dbd-4010-9ed2-09da5230d5b8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description9", 0m, 9000m, false, null, "Name9", 9000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 9, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") }
                });
        }
    }
}
