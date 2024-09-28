using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Antree_Ecommerce_BE.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddingFieldsOrderDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0272d3c8-e93f-4498-bf3c-0e6b6561d2f4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0d5dbad4-55d6-42d2-8d29-e8e1ac344635"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("15a7f815-936e-4cad-ac83-50197bf056d1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("15fc0aae-fdb2-42a0-95f5-3156ef3d2d59"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1d979cdd-edb3-4f8d-903c-15b9094027af"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("20dc96b9-949d-4337-907a-0434c4b2934c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("376bd88d-421c-42c5-822b-f952e8abdb0d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("47ba9aa8-3b17-4037-b45b-3a4fd17ae1bc"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("48d0c5a7-6490-4cdb-9bca-3011f82017de"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4b863dc1-6589-41aa-b472-f77137adce45"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4d6231ea-0614-486d-9723-ecec57bc8ce7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5639037f-439e-439e-983d-640a9e5b4dcc"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5ee64e93-c484-424a-b58d-ceafc43ec245"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("618a510c-8014-4f74-b62d-61fa5cad2e7a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("64be8247-3fd7-48d0-93ce-edf88e7b83ac"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("68ffcca3-5c92-467a-bdd6-fd3bf0c4a7c8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6bf497c9-644f-4e86-89bc-5ce42f714047"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("71e5800f-4f5c-481e-b2a1-a964306ad9cb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("887a6549-141f-466f-a24e-01f0e89e0aa3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8888a37b-88b6-4612-9536-5ea2beab6231"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8af671bf-5f3a-49f5-9427-6210ba43404b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8ea391df-e16b-43f7-a299-e414cec158dd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("99f8e0bf-a0a9-40cd-a23c-453d104ff7f3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9de5c8f9-7bc8-4335-9c1f-d915ef551e50"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a2220e5f-ac86-4678-a09e-e1f6624ea160"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b1ffddec-1416-4ae5-8723-fe28589edfe8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b48c9695-a720-4746-8548-a64bcdc09101"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b4c67b8c-0ee9-4890-a9f9-d6a22b06b15a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("bbf36cf0-d107-4c4c-85ee-8d070c8ae653"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c88a3071-5bae-47de-8033-9d5d694fdc65"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c9fd2d1c-c035-4df1-b746-daf82848ea08"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d511d569-d9eb-4ee4-ab71-6ac0de2d6223"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d7c15d73-b7a1-4052-8929-bab4a685bbb8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("dc3449c9-6685-474f-bda7-12daafff5e59"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e221663e-7e22-44d1-b39e-11d5ec91588a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e3776c84-62bf-4ea4-8e37-25c0c6ddcac2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e8441b70-4ca3-4a41-bc34-7919a964d6a1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e8b730a0-e015-4955-a523-7a7cb2fdb999"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e9235e28-6ba1-462e-90cd-277ba5b71f8d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ec37efc7-60b1-4bee-af19-9d4f4b89f404"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("fbe4a67b-bea0-4793-b4b7-b1c0ff9da954"));

            migrationBuilder.AddColumn<decimal>(
                name: "ProductPrice",
                table: "OrderDetail",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ProductPriceDiscount",
                table: "OrderDetail",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CoverImage", "CreatedBy", "CreatedOnUtc", "Description", "DiscountPercent", "DiscountSold", "IsDeleted", "ModifiedOnUtc", "Name", "Price", "ProductCategoryId", "Sku", "Sold", "UpdatedBy", "VendorId" },
                values: new object[,]
                {
                    { new Guid("087ae549-ae95-455c-8bc6-6219f548147c"), "", new Guid("31aa990b-86f4-4323-9794-08b20149a3c2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description3", 0m, 3000m, false, null, "Name3", 3000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 3, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("0aebb677-980c-4440-bb5f-6ffedc420d07"), "", new Guid("26827f94-7883-4809-8bea-6ef65d95cb11"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description2", 0m, 2000m, false, null, "Name2", 2000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 2, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("0ca66ad3-3ef5-4a7c-b728-e2022307659d"), "", new Guid("d0e39e1f-ffc1-4d6d-a6a2-d37837294cb7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description20", 0m, 20000m, false, null, "Name20", 20000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 20, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("0d795171-a7b9-4b20-a0aa-dc6f1d8ec0da"), "", new Guid("c28fbd8c-af86-427b-bb4d-4061c5ed7ca9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description10", 0m, 10000m, false, null, "Name10", 10000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 10, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("170f35af-532d-4888-92da-dd493c218db9"), "", new Guid("6e43ab28-3af1-430a-a40c-be931b21456e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description9", 0m, 9000m, false, null, "Name9", 9000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 9, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("18bb371b-c42e-4d55-95de-92031d7225ab"), "", new Guid("c2a121c3-6496-4c10-baa0-e43f3c2929a7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description39", 0m, 39000m, false, null, "Name39", 39000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 39, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("194056f7-c50b-40b5-8c22-de6a63ced7cb"), "", new Guid("bd0ba72b-57ea-406f-a3ec-4ee02b4b73c1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description0", 0m, 0m, false, null, "Name0", 0m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("1af78bbf-b1c5-423c-abd6-71fe56a2a83c"), "", new Guid("cb304700-25a8-4359-8224-0ca247cdd0f1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description7", 0m, 7000m, false, null, "Name7", 7000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 7, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("1d893b3b-449c-414d-81d0-359b4a7cd6df"), "", new Guid("2e00544a-9e72-4c7c-ac88-57b443d66d3f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description17", 0m, 17000m, false, null, "Name17", 17000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 17, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("1f77f470-d38c-4d6b-9d20-070deabd1220"), "", new Guid("010f9d5a-4c69-45fe-8327-b9f0ae84917c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description28", 0m, 28000m, false, null, "Name28", 28000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 28, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("2bb9483f-71b4-4576-a36a-73c680d48359"), "", new Guid("70c04c3e-7da3-4f28-a09a-2725000e7eb7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description40", 0m, 40000m, false, null, "Name40", 40000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 40, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("35c16da4-e26a-4b31-a2b6-bd7d5900069d"), "", new Guid("f753e68f-38ce-4c70-b9d8-6ae63df0a577"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description27", 0m, 27000m, false, null, "Name27", 27000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 27, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("464e9b11-2e5f-4d88-917a-fe4ba1f863e5"), "", new Guid("2f08f212-2dfc-469d-adf8-fca6a91f2a66"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description25", 0m, 25000m, false, null, "Name25", 25000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 25, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("48a2e0ab-06fc-4310-8c90-3d3d94c75327"), "", new Guid("0d35e84f-a0f2-4236-b734-221326b1e460"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description34", 0m, 34000m, false, null, "Name34", 34000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 34, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("4cae7287-1ec7-4a59-99cb-8fb0209191e1"), "", new Guid("46d15e6c-a42e-4f76-be13-0ed8a412e962"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description6", 0m, 6000m, false, null, "Name6", 6000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 6, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("5204358b-a057-4302-9321-f97b7e5d4493"), "", new Guid("e555a861-481d-4667-8f36-9dc7b824fa80"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description1", 0m, 1000m, false, null, "Name1", 1000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 1, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("53985e49-257a-43cc-b068-b75b3922e560"), "", new Guid("2f4bb230-9af4-45f3-ac0c-0ed32a900291"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description11", 0m, 11000m, false, null, "Name11", 11000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 11, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("539fda92-e604-4089-9e07-eebc781ab96f"), "", new Guid("d286c98b-060c-45d1-b015-e55c80e9bc03"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description30", 0m, 30000m, false, null, "Name30", 30000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 30, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("554b0369-fb95-4926-a4c5-1035c6b8b5b1"), "", new Guid("be426f88-46eb-41cb-9eb9-c8b3a995fcfd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description16", 0m, 16000m, false, null, "Name16", 16000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 16, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("5e4c6cc0-45f3-4356-8a7e-95a371801f3a"), "", new Guid("84b384d9-c98c-4609-b046-233cb6629ad2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description18", 0m, 18000m, false, null, "Name18", 18000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 18, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("6866d759-e6a1-4caf-9220-4186e662b6e1"), "", new Guid("0f35dfa7-3be8-4897-8a3b-759b40b2cdf3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description31", 0m, 31000m, false, null, "Name31", 31000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 31, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("735c4787-1642-40f3-b09d-e437fc3a24b6"), "", new Guid("1d9c1e9e-1c9c-4b9a-a1c9-380ba0ca2611"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description24", 0m, 24000m, false, null, "Name24", 24000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 24, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("815f73db-1851-4635-8bfb-e2d85bc61923"), "", new Guid("899c1cbb-dcdb-43c8-bc19-c4b904d09e26"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description14", 0m, 14000m, false, null, "Name14", 14000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 14, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("8a0f569a-6616-4574-acde-b9946cf17b4e"), "", new Guid("088502c0-3489-40f3-b657-2dfaea2a2150"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description15", 0m, 15000m, false, null, "Name15", 15000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 15, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("96a79c4f-dd05-4e62-83bc-f036999fa1b4"), "", new Guid("e3177ccd-01c2-43eb-b94b-c9ce23b14cad"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description35", 0m, 35000m, false, null, "Name35", 35000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 35, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("98a7e49b-f600-4a52-ac94-6322cb270696"), "", new Guid("bd0b0849-d959-42cb-93bd-a1b5cd00526f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description22", 0m, 22000m, false, null, "Name22", 22000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 22, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("a482f427-c208-4159-8fab-f22891de0e6d"), "", new Guid("4ff07ed3-52c5-4cd1-876c-af26cdc1a918"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description26", 0m, 26000m, false, null, "Name26", 26000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 26, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("a89fe55d-6e8c-41e4-a534-945637a08b01"), "", new Guid("491910fe-adb2-49e6-a799-254ddae318b7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description23", 0m, 23000m, false, null, "Name23", 23000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 23, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("b11b6c82-5332-403b-b875-5eda1b92fc4d"), "", new Guid("d4b12d48-bf7f-42d1-9b88-b6cc1ba65ed0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description32", 0m, 32000m, false, null, "Name32", 32000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 32, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("bbda3706-5595-4ec7-9a58-6edfd3205c3e"), "", new Guid("3734a048-cc8c-4c13-965a-d727a7ddf1ee"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description19", 0m, 19000m, false, null, "Name19", 19000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 19, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("cac4b932-a014-43bf-bf2e-74cc6a8827e9"), "", new Guid("d280d8e9-29df-4d39-9624-d198c680fb02"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description4", 0m, 4000m, false, null, "Name4", 4000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 4, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("cc8c10ac-66de-4327-9b4c-aaee10650fa9"), "", new Guid("80871940-6c20-48e3-9733-305cf66efa84"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description38", 0m, 38000m, false, null, "Name38", 38000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 38, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("d7bf0748-a1a5-4e54-acdc-e188b07a45e7"), "", new Guid("359e1b55-baa2-4f8a-a88b-41f552934efd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description8", 0m, 8000m, false, null, "Name8", 8000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 8, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("d7c586dd-7978-44a5-b0ca-c2149467b059"), "", new Guid("7a856e36-bd2b-4eef-b773-5135a649e34e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description5", 0m, 5000m, false, null, "Name5", 5000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 5, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("dc7f8798-4c46-4db8-96be-b10209b378de"), "", new Guid("be596a6a-3d4f-4da0-b553-d00d5ceed172"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description36", 0m, 36000m, false, null, "Name36", 36000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 36, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("e38834cc-b649-4808-aba2-54eb98103414"), "", new Guid("730e7341-01c2-4ef2-8320-c80aa6e64d70"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description21", 0m, 21000m, false, null, "Name21", 21000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 21, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("ec97bef3-f61d-499e-a211-c2d6e88f873e"), "", new Guid("e425afae-538b-49e6-a757-b42e456ea1d8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description37", 0m, 37000m, false, null, "Name37", 37000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 37, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("eeb623b4-2d40-42a1-8dd6-5523863f8531"), "", new Guid("735e8286-46b2-4ab0-b484-54f3447009eb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description12", 0m, 12000m, false, null, "Name12", 12000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 12, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("fb030f2a-e8b9-41ad-9598-7aa9477e39b2"), "", new Guid("7f569399-c08b-4875-b3d3-b01b305044fd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description33", 0m, 33000m, false, null, "Name33", 33000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 33, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("fc5675c7-9602-4644-a0ed-c43298fe2d99"), "", new Guid("190cb6f1-7aaa-49c4-b89a-202d23aeb74e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description13", 0m, 13000m, false, null, "Name13", 13000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 13, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("fdf7a479-fdd2-40c8-bbf3-9015aac31124"), "", new Guid("cad7be78-c236-4def-a297-13f7b5df919c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description29", 0m, 29000m, false, null, "Name29", 29000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 29, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("087ae549-ae95-455c-8bc6-6219f548147c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0aebb677-980c-4440-bb5f-6ffedc420d07"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0ca66ad3-3ef5-4a7c-b728-e2022307659d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0d795171-a7b9-4b20-a0aa-dc6f1d8ec0da"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("170f35af-532d-4888-92da-dd493c218db9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("18bb371b-c42e-4d55-95de-92031d7225ab"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("194056f7-c50b-40b5-8c22-de6a63ced7cb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1af78bbf-b1c5-423c-abd6-71fe56a2a83c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1d893b3b-449c-414d-81d0-359b4a7cd6df"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1f77f470-d38c-4d6b-9d20-070deabd1220"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2bb9483f-71b4-4576-a36a-73c680d48359"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("35c16da4-e26a-4b31-a2b6-bd7d5900069d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("464e9b11-2e5f-4d88-917a-fe4ba1f863e5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("48a2e0ab-06fc-4310-8c90-3d3d94c75327"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4cae7287-1ec7-4a59-99cb-8fb0209191e1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5204358b-a057-4302-9321-f97b7e5d4493"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("53985e49-257a-43cc-b068-b75b3922e560"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("539fda92-e604-4089-9e07-eebc781ab96f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("554b0369-fb95-4926-a4c5-1035c6b8b5b1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5e4c6cc0-45f3-4356-8a7e-95a371801f3a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6866d759-e6a1-4caf-9220-4186e662b6e1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("735c4787-1642-40f3-b09d-e437fc3a24b6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("815f73db-1851-4635-8bfb-e2d85bc61923"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8a0f569a-6616-4574-acde-b9946cf17b4e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("96a79c4f-dd05-4e62-83bc-f036999fa1b4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("98a7e49b-f600-4a52-ac94-6322cb270696"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a482f427-c208-4159-8fab-f22891de0e6d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a89fe55d-6e8c-41e4-a534-945637a08b01"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b11b6c82-5332-403b-b875-5eda1b92fc4d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("bbda3706-5595-4ec7-9a58-6edfd3205c3e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("cac4b932-a014-43bf-bf2e-74cc6a8827e9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("cc8c10ac-66de-4327-9b4c-aaee10650fa9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d7bf0748-a1a5-4e54-acdc-e188b07a45e7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d7c586dd-7978-44a5-b0ca-c2149467b059"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("dc7f8798-4c46-4db8-96be-b10209b378de"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e38834cc-b649-4808-aba2-54eb98103414"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ec97bef3-f61d-499e-a211-c2d6e88f873e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("eeb623b4-2d40-42a1-8dd6-5523863f8531"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("fb030f2a-e8b9-41ad-9598-7aa9477e39b2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("fc5675c7-9602-4644-a0ed-c43298fe2d99"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("fdf7a479-fdd2-40c8-bbf3-9015aac31124"));

            migrationBuilder.DropColumn(
                name: "ProductPrice",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "ProductPriceDiscount",
                table: "OrderDetail");

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CoverImage", "CreatedBy", "CreatedOnUtc", "Description", "DiscountPercent", "DiscountSold", "IsDeleted", "ModifiedOnUtc", "Name", "Price", "ProductCategoryId", "Sku", "Sold", "UpdatedBy", "VendorId" },
                values: new object[,]
                {
                    { new Guid("0272d3c8-e93f-4498-bf3c-0e6b6561d2f4"), "", new Guid("d11f3b6d-cfb9-4d0f-b425-b3e0310d231b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description10", 0m, 10000m, false, null, "Name10", 10000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 10, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("0d5dbad4-55d6-42d2-8d29-e8e1ac344635"), "", new Guid("6fcfa96f-5523-4da3-a231-b85963ab7b47"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description40", 0m, 40000m, false, null, "Name40", 40000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 40, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("15a7f815-936e-4cad-ac83-50197bf056d1"), "", new Guid("2b92e332-187c-449b-b897-bb3495747161"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description37", 0m, 37000m, false, null, "Name37", 37000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 37, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("15fc0aae-fdb2-42a0-95f5-3156ef3d2d59"), "", new Guid("7499c0be-2251-4206-b927-ca5c81e6c4a7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description3", 0m, 3000m, false, null, "Name3", 3000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 3, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("1d979cdd-edb3-4f8d-903c-15b9094027af"), "", new Guid("a8e36242-3418-4ac8-bc5a-71ec9e73c67b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description29", 0m, 29000m, false, null, "Name29", 29000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 29, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("20dc96b9-949d-4337-907a-0434c4b2934c"), "", new Guid("67d07931-18a7-4be3-91e9-5f85f2838cac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description15", 0m, 15000m, false, null, "Name15", 15000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 15, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("376bd88d-421c-42c5-822b-f952e8abdb0d"), "", new Guid("71064d22-aa9f-4966-ac38-fa7c3dbad1d5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description20", 0m, 20000m, false, null, "Name20", 20000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 20, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("47ba9aa8-3b17-4037-b45b-3a4fd17ae1bc"), "", new Guid("738dda2a-2e6b-45e6-b249-8f9fa8b1f490"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description26", 0m, 26000m, false, null, "Name26", 26000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 26, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("48d0c5a7-6490-4cdb-9bca-3011f82017de"), "", new Guid("5dbcd35e-4a49-4550-b390-e88ebc61ef1c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description30", 0m, 30000m, false, null, "Name30", 30000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 30, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("4b863dc1-6589-41aa-b472-f77137adce45"), "", new Guid("61e471e2-303e-4293-af19-c4c333c9ad81"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description12", 0m, 12000m, false, null, "Name12", 12000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 12, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("4d6231ea-0614-486d-9723-ecec57bc8ce7"), "", new Guid("f5f1e67f-ce45-42b4-8183-5f1048b402d6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description17", 0m, 17000m, false, null, "Name17", 17000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 17, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("5639037f-439e-439e-983d-640a9e5b4dcc"), "", new Guid("80279594-c454-47bd-8bae-2cce6f88f244"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description16", 0m, 16000m, false, null, "Name16", 16000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 16, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("5ee64e93-c484-424a-b58d-ceafc43ec245"), "", new Guid("d221dd55-0f61-4943-a64e-c230de898ee2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description6", 0m, 6000m, false, null, "Name6", 6000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 6, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("618a510c-8014-4f74-b62d-61fa5cad2e7a"), "", new Guid("4d020d8b-6d54-434c-b6e3-beb5295847ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description14", 0m, 14000m, false, null, "Name14", 14000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 14, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("64be8247-3fd7-48d0-93ce-edf88e7b83ac"), "", new Guid("ce1f064e-c1fe-4165-9030-cda5a73a748b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description28", 0m, 28000m, false, null, "Name28", 28000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 28, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("68ffcca3-5c92-467a-bdd6-fd3bf0c4a7c8"), "", new Guid("76ace80d-3c9a-4363-adbe-2946ffa35d01"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description8", 0m, 8000m, false, null, "Name8", 8000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 8, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("6bf497c9-644f-4e86-89bc-5ce42f714047"), "", new Guid("cc18dc57-6127-499a-8cab-b0040e84fbd7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description18", 0m, 18000m, false, null, "Name18", 18000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 18, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("71e5800f-4f5c-481e-b2a1-a964306ad9cb"), "", new Guid("d3bbbf61-d5bd-4cbe-b1a7-4559836af9d5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description5", 0m, 5000m, false, null, "Name5", 5000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 5, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("887a6549-141f-466f-a24e-01f0e89e0aa3"), "", new Guid("e4707499-cc95-46fd-b245-3df9b01eec70"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description39", 0m, 39000m, false, null, "Name39", 39000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 39, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("8888a37b-88b6-4612-9536-5ea2beab6231"), "", new Guid("b36596e6-b058-4f0e-9324-5ae9d79c2832"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description11", 0m, 11000m, false, null, "Name11", 11000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 11, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("8af671bf-5f3a-49f5-9427-6210ba43404b"), "", new Guid("b33e7caf-ef97-4fb3-ae18-34cdd6f7b865"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description38", 0m, 38000m, false, null, "Name38", 38000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 38, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("8ea391df-e16b-43f7-a299-e414cec158dd"), "", new Guid("5856dffc-c346-4cc2-8bb4-c9899c91eeec"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description24", 0m, 24000m, false, null, "Name24", 24000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 24, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("99f8e0bf-a0a9-40cd-a23c-453d104ff7f3"), "", new Guid("cb2e3eba-ea94-4e7e-83d9-2ef33b2f78f8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description27", 0m, 27000m, false, null, "Name27", 27000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 27, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("9de5c8f9-7bc8-4335-9c1f-d915ef551e50"), "", new Guid("990143a7-cddd-4301-8a68-a447d3f992c0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description22", 0m, 22000m, false, null, "Name22", 22000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 22, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("a2220e5f-ac86-4678-a09e-e1f6624ea160"), "", new Guid("1aac792b-5765-4f42-a372-cc24b1836fa4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description19", 0m, 19000m, false, null, "Name19", 19000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 19, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("b1ffddec-1416-4ae5-8723-fe28589edfe8"), "", new Guid("cfb49f74-e5b6-4229-854f-2d5bc9650a28"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description0", 0m, 0m, false, null, "Name0", 0m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("b48c9695-a720-4746-8548-a64bcdc09101"), "", new Guid("787b4787-e099-490d-a3e7-cf82937bcad2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description1", 0m, 1000m, false, null, "Name1", 1000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 1, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("b4c67b8c-0ee9-4890-a9f9-d6a22b06b15a"), "", new Guid("3ef8e5a1-5ad4-4c11-ba24-156e7e07ab83"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description4", 0m, 4000m, false, null, "Name4", 4000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 4, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("bbf36cf0-d107-4c4c-85ee-8d070c8ae653"), "", new Guid("086ad527-1d19-4681-8dd4-e2400b343b67"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description7", 0m, 7000m, false, null, "Name7", 7000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 7, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("c88a3071-5bae-47de-8033-9d5d694fdc65"), "", new Guid("015f8171-85e8-4369-8e63-bf7994e565a2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description2", 0m, 2000m, false, null, "Name2", 2000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 2, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("c9fd2d1c-c035-4df1-b746-daf82848ea08"), "", new Guid("2882894f-6b8f-405d-87d0-a385aa0acffb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description31", 0m, 31000m, false, null, "Name31", 31000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 31, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("d511d569-d9eb-4ee4-ab71-6ac0de2d6223"), "", new Guid("5a8d6358-ad29-4043-8946-befb87c09abe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description23", 0m, 23000m, false, null, "Name23", 23000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 23, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("d7c15d73-b7a1-4052-8929-bab4a685bbb8"), "", new Guid("e88884ad-4c9d-4bc0-b048-c5142776c604"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description25", 0m, 25000m, false, null, "Name25", 25000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 25, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("dc3449c9-6685-474f-bda7-12daafff5e59"), "", new Guid("4e2d968d-f4f2-4aa3-be2d-d3be3cb5bbb0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description9", 0m, 9000m, false, null, "Name9", 9000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 9, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("e221663e-7e22-44d1-b39e-11d5ec91588a"), "", new Guid("8b2563a1-d443-4595-8ecb-e435fe612df1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description35", 0m, 35000m, false, null, "Name35", 35000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 35, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("e3776c84-62bf-4ea4-8e37-25c0c6ddcac2"), "", new Guid("720b92bb-ae8d-4bf5-9d81-601b42c2db1e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description21", 0m, 21000m, false, null, "Name21", 21000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 21, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("e8441b70-4ca3-4a41-bc34-7919a964d6a1"), "", new Guid("e365f213-5bdc-4d9d-8418-bb18be1a81f7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description34", 0m, 34000m, false, null, "Name34", 34000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 34, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("e8b730a0-e015-4955-a523-7a7cb2fdb999"), "", new Guid("46def789-2819-4366-941c-ddcc7e2c2705"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description13", 0m, 13000m, false, null, "Name13", 13000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 13, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("e9235e28-6ba1-462e-90cd-277ba5b71f8d"), "", new Guid("ce7faa5b-fe49-4eec-93ad-8af349992a0e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description33", 0m, 33000m, false, null, "Name33", 33000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 33, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("ec37efc7-60b1-4bee-af19-9d4f4b89f404"), "", new Guid("29969f59-decf-4b69-a21c-5e42038e2ac1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description32", 0m, 32000m, false, null, "Name32", 32000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 32, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("fbe4a67b-bea0-4793-b4b7-b1c0ff9da954"), "", new Guid("2ac3352d-f7cf-4178-bd86-119383baa920"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description36", 0m, 36000m, false, null, "Name36", 36000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 36, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") }
                });
        }
    }
}
