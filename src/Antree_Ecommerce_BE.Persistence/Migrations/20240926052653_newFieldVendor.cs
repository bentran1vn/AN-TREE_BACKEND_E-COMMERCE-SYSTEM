using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Antree_Ecommerce_BE.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class newFieldVendor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("010b1cce-ffb0-4945-a68d-a19d2fcc08c8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0126d70c-2f4f-458e-8995-c661f0720a8c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("01c6fead-a82e-44bd-a098-488885f8657b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0f277a2a-55e9-4493-9719-c5cee7ded213"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1030c2b6-3cf5-4f2f-8aca-eef34a7fc661"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("105d1034-2d7f-4ed3-9c0d-8a01bfcc4028"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("14cddbfc-03be-49f4-8728-d00d0960e351"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("15018153-5e0d-4938-94f0-fc18f6b6d162"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("16b5922d-d5d2-4656-85cb-807fe2e92c3d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("17c2c719-74a0-427e-a589-6f04039a77d1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1b556ad8-5f32-4430-8796-39cbf90ad71b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2cfda511-6778-4ca9-b50e-34c7add5d463"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2d5d15e5-60c4-49cc-9c88-c5aa1a07c38e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("31d815bb-b0ce-461d-acb9-5b2e7b273fb5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("33ab047f-e978-42e7-9f2d-5061779ef21b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3d51c8e3-0df9-4ca8-89a4-6704d1a37efc"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3e767575-2f84-4049-becb-29d40234f60a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("52c57d4e-21d7-4a74-bdfd-77647b4cd2dc"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("54f6b031-df03-48e8-b22d-fc9aee69dc7d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("642012f0-d835-4462-907d-96d0c36b53b4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("68ecc07e-b0d0-4159-a5d1-deeca783ad17"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("71129ab2-456f-47ff-af45-4d751f06f1c3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("75f4e811-77ac-4c5e-b41a-7f3fb2ad8de7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7650732b-3bd4-4e46-98b9-10f282c2c1c8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7b38672f-940f-46d8-9dd0-980b10d71c41"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("84448fee-fd79-4248-80fa-bfaad87092e7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("939f2a6e-671f-4d42-a75b-296afac16602"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("97440e23-efc1-4768-ba4f-fa51754c43b5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9f69371a-277a-4e93-88fe-1ae6c3840c70"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b5ba5b6d-0959-4e96-a6bd-3f9b3fd0af76"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ba421a59-3fad-44a7-b534-d27bbc63d7e2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("bc31e3ab-eec0-4afd-b7de-211a9fa34aaa"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("bcd98393-f1b9-4a27-b656-494fcb7e7507"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("bdb873ed-d11d-454b-9c21-fa466afe3d39"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c87eed72-9870-4c80-9ce2-d44f474ea081"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("cc54d1ab-fb3c-437c-a467-9275b5c1e21a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d028fc93-6c94-414e-b06a-010930ba3d67"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d6fb5d3c-976d-430c-b4da-a9a9ddc657d2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("dd4b6e72-bbb2-4142-8f38-667b5d3f4cb5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f408d5f0-234a-4361-b74a-caf5f20859ee"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("fc9a9a18-154e-4212-bfb0-5993d5def275"));

            migrationBuilder.AddColumn<string>(
                name: "BankAccountNumber",
                table: "Vendor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BankName",
                table: "Vendor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BankOwnerName",
                table: "Vendor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Vendor",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "Vendor",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CoverImage", "CreatedBy", "CreatedOnUtc", "Description", "DiscountPercent", "DiscountSold", "IsDeleted", "ModifiedOnUtc", "Name", "Price", "ProductCategoryId", "Sku", "Sold", "UpdatedBy", "VendorId" },
                values: new object[,]
                {
                    { new Guid("006505a0-85f5-4b13-8254-b5c88b570ca6"), "", new Guid("f1c8bb2a-328f-413d-b4c2-33c55fadea86"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description2", 0m, 2000m, false, null, "Name2", 2000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 2, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("04884dfb-1c54-4cbf-8fe2-bcaa36069e3d"), "", new Guid("66b3449e-6f75-46ed-b358-58e9e7bc3836"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description0", 0m, 0m, false, null, "Name0", 0m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("0497243b-c7dc-41b9-837b-40fd00789846"), "", new Guid("596fb5cf-5691-4b5a-b6e2-a3b9b027881f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description14", 0m, 14000m, false, null, "Name14", 14000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 14, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("071a39b1-ee4b-4903-bfc0-43ba22e070c1"), "", new Guid("ea0a1049-fbfb-4d43-a1cf-8dabca626946"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description15", 0m, 15000m, false, null, "Name15", 15000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 15, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("0dd7153f-5fb9-4dfa-8fea-2c47aac05712"), "", new Guid("335038e1-41e0-4b1b-a9e8-c0c5977b7422"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description20", 0m, 20000m, false, null, "Name20", 20000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 20, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("179795e8-f07f-40c0-ae91-d4a2a31f023d"), "", new Guid("f3d9c127-62bc-40ff-874b-87a6c6e18560"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description22", 0m, 22000m, false, null, "Name22", 22000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 22, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("1fa2edec-3889-481b-9e46-f53c83580af8"), "", new Guid("a60b035e-5ea9-46fa-97c5-69147a21d473"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description23", 0m, 23000m, false, null, "Name23", 23000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 23, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("233fc98c-bfe1-48d0-8222-a878436d2c00"), "", new Guid("bacd3baa-b36e-4cdd-a876-18683d47e64f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description35", 0m, 35000m, false, null, "Name35", 35000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 35, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("26de2a40-3ed7-49d4-a297-d1664d553e51"), "", new Guid("48079097-9c66-4cc2-8d75-cd567a7cc307"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description1", 0m, 1000m, false, null, "Name1", 1000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 1, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("303be412-762f-4299-939f-99d45a138af5"), "", new Guid("907e8308-48ca-4582-929e-0ceb5c914613"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description18", 0m, 18000m, false, null, "Name18", 18000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 18, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("3238ab6c-4494-4063-b2fd-7ee26d4ca81a"), "", new Guid("1a4e7423-0a63-4aa7-8970-cbe6f0397c8d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description17", 0m, 17000m, false, null, "Name17", 17000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 17, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("3cf32902-86df-43b1-8c80-863bb46f644d"), "", new Guid("598a4d40-f982-4a10-95b4-e0b6ec82054e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description16", 0m, 16000m, false, null, "Name16", 16000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 16, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("44e0aa0d-09b7-4cb1-8f1a-076cca193478"), "", new Guid("bb4f171f-eb7f-46f0-b468-7c25d6ed72ad"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description5", 0m, 5000m, false, null, "Name5", 5000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 5, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("45eb053f-0a1f-4cf0-96c6-5da8ecd7fbf1"), "", new Guid("3bc54737-3302-4602-a476-0446b043975b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description24", 0m, 24000m, false, null, "Name24", 24000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 24, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("4e9c9320-8466-4dbd-a0cf-17a0c10866a4"), "", new Guid("31bd1bdb-7b4f-477e-98c8-9fdafec3de3b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description9", 0m, 9000m, false, null, "Name9", 9000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 9, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("6243c522-f7d7-40a3-8c7f-6c3b16ff5ce9"), "", new Guid("6a0541d9-09e2-4c75-9d54-7082072b5bca"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description30", 0m, 30000m, false, null, "Name30", 30000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 30, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("641b4882-b921-4d6a-a73f-0d0e4668051c"), "", new Guid("9055613a-e5b6-4888-987a-afbf6df98c0c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description11", 0m, 11000m, false, null, "Name11", 11000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 11, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("667a5be6-ddde-4ca8-8cbf-3c2fdf082339"), "", new Guid("768f1dc6-b05c-4d7b-8e0b-41cbd67fd2fa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description8", 0m, 8000m, false, null, "Name8", 8000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 8, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("67acc97e-2ced-44d3-82ef-5f35d7923405"), "", new Guid("ec93577c-b10a-48bc-8632-6933243aef2a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description12", 0m, 12000m, false, null, "Name12", 12000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 12, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("7f4b550c-88b1-4e90-9477-f646e0d6fb4e"), "", new Guid("7358cc4b-31e1-419f-b917-07c54fb9185e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description27", 0m, 27000m, false, null, "Name27", 27000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 27, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("7fcb4e36-4fb2-4e39-b0f4-79a7a87f82d3"), "", new Guid("3209edb4-48b0-40c6-aeaa-8038891bbf3d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description7", 0m, 7000m, false, null, "Name7", 7000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 7, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("811fc66a-61e4-4832-89ae-dd4505251512"), "", new Guid("c18a3827-75ad-4a63-999e-b0b4f692f5c8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description28", 0m, 28000m, false, null, "Name28", 28000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 28, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("8606115b-ada2-4f60-b01f-2712c285b62e"), "", new Guid("859367ba-f87a-48fe-bde5-afd2096a6193"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description37", 0m, 37000m, false, null, "Name37", 37000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 37, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("8ea3f87b-da62-46d2-af67-9ea7c1f1500c"), "", new Guid("3c06fdd3-b220-4ffd-bcee-15ce018bec29"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description39", 0m, 39000m, false, null, "Name39", 39000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 39, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("8f46348b-1c7f-4c57-8792-cabcef349e48"), "", new Guid("802f2703-65ce-4497-8b8e-912a7b9fdc83"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description32", 0m, 32000m, false, null, "Name32", 32000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 32, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("9c88a7a8-8c03-4ac9-81bd-3dd509ca080c"), "", new Guid("bd966667-c6c1-4881-9e46-4541166efe04"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description29", 0m, 29000m, false, null, "Name29", 29000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 29, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("a13ed845-c2d2-4d05-a3de-a9f62f32386e"), "", new Guid("96de2b1e-fcce-48d0-a228-7b942879a4a9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description13", 0m, 13000m, false, null, "Name13", 13000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 13, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("b56b8c64-076c-484d-8e2b-ac790ee21efb"), "", new Guid("a560d946-8365-4187-b38c-9c12858720c5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description36", 0m, 36000m, false, null, "Name36", 36000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 36, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("b6ff9a89-1ed8-4a07-ab21-c0bce26b1f70"), "", new Guid("e33758a6-3ec7-403a-ba75-660ffa263c1e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description40", 0m, 40000m, false, null, "Name40", 40000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 40, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("bc38a2fa-a9b9-4432-98af-a97c6462e180"), "", new Guid("ab70ef5a-1808-47df-b240-860b48a54fee"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description21", 0m, 21000m, false, null, "Name21", 21000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 21, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("c784ca51-1282-45f6-a5e8-9fd3f3af8e81"), "", new Guid("a503f4fc-fae9-4b85-9a54-de19d745f6cc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description10", 0m, 10000m, false, null, "Name10", 10000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 10, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("ccbd60c7-bd8c-465e-8105-bab70e4662be"), "", new Guid("9ebac136-2a3c-4d75-bc54-7fd4cad3bb82"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description19", 0m, 19000m, false, null, "Name19", 19000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 19, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("cd6391bb-8531-4d09-9113-e07643c8500a"), "", new Guid("837ed544-ea53-4085-99e7-c0fec1a31122"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description25", 0m, 25000m, false, null, "Name25", 25000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 25, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("dc90d1e6-84f8-4fa5-9c64-83a3a62999bd"), "", new Guid("9e87d62e-deca-4f0f-8fb1-a2efab635d18"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description34", 0m, 34000m, false, null, "Name34", 34000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 34, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("e2a341c3-21e5-4b9d-a9b4-08741b5a5548"), "", new Guid("16af46b7-a134-4724-8d43-e9bdf16a8897"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description31", 0m, 31000m, false, null, "Name31", 31000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 31, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("eb73aa1e-40d3-45be-bf96-56b2a21425cb"), "", new Guid("03492601-88d2-4d79-a81f-eab61a2e4832"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description38", 0m, 38000m, false, null, "Name38", 38000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 38, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("ec56aaaa-8741-4dfc-a9d8-b1b0ccc9d2c6"), "", new Guid("616c9c8b-74c6-481a-8a55-bba241dfeaa0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description4", 0m, 4000m, false, null, "Name4", 4000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 4, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("f7bd643f-ddc9-457f-a4e2-a5f577ff7c34"), "", new Guid("fea3ea2a-be74-4895-8548-3ee43dec3303"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description3", 0m, 3000m, false, null, "Name3", 3000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 3, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("f7f370e6-f940-4765-afa5-7fedb4eee2e9"), "", new Guid("08c3d8d0-c34b-477d-a81f-216c2ccdc4b5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description33", 0m, 33000m, false, null, "Name33", 33000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 33, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("f8e5b9bd-063f-4dc4-9d35-1604b4751b84"), "", new Guid("77bdc617-22d0-4344-81f0-d208731e34d5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description26", 0m, 26000m, false, null, "Name26", 26000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 26, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("fc53dc2b-de6a-4100-9957-2cd42a9953f7"), "", new Guid("a219e1e1-a08e-4ed3-9818-af5e1f857d68"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description6", 0m, 6000m, false, null, "Name6", 6000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 6, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") }
                });

            migrationBuilder.UpdateData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2"),
                columns: new[] { "BankAccountNumber", "BankName", "BankOwnerName", "CreatedBy", "UpdatedBy" },
                values: new object[] { "123", "123", "123", new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.UpdateData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("f5565937-575b-462a-903c-404727ba3765"),
                columns: new[] { "BankAccountNumber", "BankName", "BankOwnerName", "CreatedBy", "UpdatedBy" },
                values: new object[] { "123", "123", "123", new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.UpdateData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1"),
                columns: new[] { "BankAccountNumber", "BankName", "BankOwnerName", "CreatedBy", "UpdatedBy" },
                values: new object[] { "123", "123", "123", new Guid("00000000-0000-0000-0000-000000000000"), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("006505a0-85f5-4b13-8254-b5c88b570ca6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("04884dfb-1c54-4cbf-8fe2-bcaa36069e3d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0497243b-c7dc-41b9-837b-40fd00789846"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("071a39b1-ee4b-4903-bfc0-43ba22e070c1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0dd7153f-5fb9-4dfa-8fea-2c47aac05712"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("179795e8-f07f-40c0-ae91-d4a2a31f023d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1fa2edec-3889-481b-9e46-f53c83580af8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("233fc98c-bfe1-48d0-8222-a878436d2c00"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("26de2a40-3ed7-49d4-a297-d1664d553e51"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("303be412-762f-4299-939f-99d45a138af5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3238ab6c-4494-4063-b2fd-7ee26d4ca81a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3cf32902-86df-43b1-8c80-863bb46f644d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("44e0aa0d-09b7-4cb1-8f1a-076cca193478"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("45eb053f-0a1f-4cf0-96c6-5da8ecd7fbf1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4e9c9320-8466-4dbd-a0cf-17a0c10866a4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6243c522-f7d7-40a3-8c7f-6c3b16ff5ce9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("641b4882-b921-4d6a-a73f-0d0e4668051c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("667a5be6-ddde-4ca8-8cbf-3c2fdf082339"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("67acc97e-2ced-44d3-82ef-5f35d7923405"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7f4b550c-88b1-4e90-9477-f646e0d6fb4e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7fcb4e36-4fb2-4e39-b0f4-79a7a87f82d3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("811fc66a-61e4-4832-89ae-dd4505251512"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8606115b-ada2-4f60-b01f-2712c285b62e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8ea3f87b-da62-46d2-af67-9ea7c1f1500c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8f46348b-1c7f-4c57-8792-cabcef349e48"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9c88a7a8-8c03-4ac9-81bd-3dd509ca080c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a13ed845-c2d2-4d05-a3de-a9f62f32386e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b56b8c64-076c-484d-8e2b-ac790ee21efb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b6ff9a89-1ed8-4a07-ab21-c0bce26b1f70"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("bc38a2fa-a9b9-4432-98af-a97c6462e180"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c784ca51-1282-45f6-a5e8-9fd3f3af8e81"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ccbd60c7-bd8c-465e-8105-bab70e4662be"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("cd6391bb-8531-4d09-9113-e07643c8500a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("dc90d1e6-84f8-4fa5-9c64-83a3a62999bd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e2a341c3-21e5-4b9d-a9b4-08741b5a5548"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("eb73aa1e-40d3-45be-bf96-56b2a21425cb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ec56aaaa-8741-4dfc-a9d8-b1b0ccc9d2c6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f7bd643f-ddc9-457f-a4e2-a5f577ff7c34"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f7f370e6-f940-4765-afa5-7fedb4eee2e9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f8e5b9bd-063f-4dc4-9d35-1604b4751b84"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("fc53dc2b-de6a-4100-9957-2cd42a9953f7"));

            migrationBuilder.DropColumn(
                name: "BankAccountNumber",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "BankName",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "BankOwnerName",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Vendor");

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CoverImage", "CreatedBy", "CreatedOnUtc", "Description", "DiscountPercent", "DiscountSold", "IsDeleted", "ModifiedOnUtc", "Name", "Price", "ProductCategoryId", "Sku", "Sold", "UpdatedBy", "VendorId" },
                values: new object[,]
                {
                    { new Guid("010b1cce-ffb0-4945-a68d-a19d2fcc08c8"), "", new Guid("3c20d52d-9199-46b3-b3df-bf7f0d02a930"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description28", 0m, 28000m, false, null, "Name28", 28000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 28, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("0126d70c-2f4f-458e-8995-c661f0720a8c"), "", new Guid("a9fe607d-dbd6-4bf4-baef-f8f3c8340e63"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description11", 0m, 11000m, false, null, "Name11", 11000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 11, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("01c6fead-a82e-44bd-a098-488885f8657b"), "", new Guid("9f7a3c76-01da-4e23-8b08-1abc2009287a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description34", 0m, 34000m, false, null, "Name34", 34000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 34, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("0f277a2a-55e9-4493-9719-c5cee7ded213"), "", new Guid("1748d601-8613-44d8-97a6-3d54cb965c27"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description12", 0m, 12000m, false, null, "Name12", 12000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 12, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("1030c2b6-3cf5-4f2f-8aca-eef34a7fc661"), "", new Guid("6d92a7d6-1b1d-4194-b3d7-810da6ddb964"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description21", 0m, 21000m, false, null, "Name21", 21000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 21, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("105d1034-2d7f-4ed3-9c0d-8a01bfcc4028"), "", new Guid("c3f54dc8-546b-433f-866f-f8a3d0c1e016"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description30", 0m, 30000m, false, null, "Name30", 30000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 30, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("14cddbfc-03be-49f4-8728-d00d0960e351"), "", new Guid("3d753863-de76-44b1-a04c-50a967d89683"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description7", 0m, 7000m, false, null, "Name7", 7000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 7, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("15018153-5e0d-4938-94f0-fc18f6b6d162"), "", new Guid("c4218af0-cda3-4760-8db4-f33783e2d94f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description32", 0m, 32000m, false, null, "Name32", 32000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 32, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("16b5922d-d5d2-4656-85cb-807fe2e92c3d"), "", new Guid("f9e91a96-96e8-4c2b-b492-2e1ee426f2b3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description6", 0m, 6000m, false, null, "Name6", 6000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 6, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("17c2c719-74a0-427e-a589-6f04039a77d1"), "", new Guid("e8336faa-f174-4b4b-9511-e0d09d89fbd4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description19", 0m, 19000m, false, null, "Name19", 19000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 19, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("1b556ad8-5f32-4430-8796-39cbf90ad71b"), "", new Guid("7872920c-6744-46ef-9926-b2532518ff7d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description25", 0m, 25000m, false, null, "Name25", 25000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 25, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("2cfda511-6778-4ca9-b50e-34c7add5d463"), "", new Guid("24f1a1b3-d27a-48ad-901d-795c9f51299f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description35", 0m, 35000m, false, null, "Name35", 35000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 35, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("2d5d15e5-60c4-49cc-9c88-c5aa1a07c38e"), "", new Guid("92771083-230d-496a-aff4-6c7ced7237f6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description38", 0m, 38000m, false, null, "Name38", 38000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 38, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("31d815bb-b0ce-461d-acb9-5b2e7b273fb5"), "", new Guid("dd32a56d-28db-4244-9b9c-464d631a43c9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description16", 0m, 16000m, false, null, "Name16", 16000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 16, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("33ab047f-e978-42e7-9f2d-5061779ef21b"), "", new Guid("f374cc00-440d-4530-9731-f5b12c108aa9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description3", 0m, 3000m, false, null, "Name3", 3000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 3, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("3d51c8e3-0df9-4ca8-89a4-6704d1a37efc"), "", new Guid("cb1c600c-f4ba-4696-91e4-37b1ff64c726"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description17", 0m, 17000m, false, null, "Name17", 17000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 17, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("3e767575-2f84-4049-becb-29d40234f60a"), "", new Guid("a231b2ae-f7ee-4fa4-b3e4-c30dc99a2247"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description33", 0m, 33000m, false, null, "Name33", 33000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 33, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("52c57d4e-21d7-4a74-bdfd-77647b4cd2dc"), "", new Guid("3a7f6b05-f463-4a01-986d-919692b4e152"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description8", 0m, 8000m, false, null, "Name8", 8000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 8, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("54f6b031-df03-48e8-b22d-fc9aee69dc7d"), "", new Guid("19e65e98-99a5-4422-8c09-cd0a85ecf20c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description13", 0m, 13000m, false, null, "Name13", 13000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 13, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("642012f0-d835-4462-907d-96d0c36b53b4"), "", new Guid("8b3cd537-76b4-4793-8492-32df4db40a42"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description20", 0m, 20000m, false, null, "Name20", 20000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 20, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("68ecc07e-b0d0-4159-a5d1-deeca783ad17"), "", new Guid("859d09a3-a79e-4856-bec9-bdc2170f0487"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description39", 0m, 39000m, false, null, "Name39", 39000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 39, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("71129ab2-456f-47ff-af45-4d751f06f1c3"), "", new Guid("d47962fc-e218-4789-a81b-c66c82f8123a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description40", 0m, 40000m, false, null, "Name40", 40000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 40, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("75f4e811-77ac-4c5e-b41a-7f3fb2ad8de7"), "", new Guid("adcebe3e-918e-4ae5-b379-b2098f506a59"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description2", 0m, 2000m, false, null, "Name2", 2000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 2, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("7650732b-3bd4-4e46-98b9-10f282c2c1c8"), "", new Guid("dd2afb5b-9829-4dba-b352-37e3dc337fb4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description37", 0m, 37000m, false, null, "Name37", 37000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 37, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("7b38672f-940f-46d8-9dd0-980b10d71c41"), "", new Guid("c1543d4e-6ce0-4c58-bd50-62baafdce132"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description18", 0m, 18000m, false, null, "Name18", 18000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 18, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("84448fee-fd79-4248-80fa-bfaad87092e7"), "", new Guid("2e4c39f5-95d5-4a62-9be2-154cf999e3f5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description1", 0m, 1000m, false, null, "Name1", 1000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 1, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("939f2a6e-671f-4d42-a75b-296afac16602"), "", new Guid("35dea305-d69a-4c2f-b47d-37cac9c3b65f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description15", 0m, 15000m, false, null, "Name15", 15000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 15, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("97440e23-efc1-4768-ba4f-fa51754c43b5"), "", new Guid("4544c1a3-e63c-4572-bdf5-e022db99f55a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description14", 0m, 14000m, false, null, "Name14", 14000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 14, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("9f69371a-277a-4e93-88fe-1ae6c3840c70"), "", new Guid("b2a846c6-8a45-4830-9eb7-d7b3d9a7ecf8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description9", 0m, 9000m, false, null, "Name9", 9000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 9, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("b5ba5b6d-0959-4e96-a6bd-3f9b3fd0af76"), "", new Guid("34ac2e9d-cdcf-42db-b63f-33e3beac9315"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description5", 0m, 5000m, false, null, "Name5", 5000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 5, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("ba421a59-3fad-44a7-b534-d27bbc63d7e2"), "", new Guid("a623c774-b551-4ce7-889f-f3a1d6e600a5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description0", 0m, 0m, false, null, "Name0", 0m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("bc31e3ab-eec0-4afd-b7de-211a9fa34aaa"), "", new Guid("96eb9d93-d84c-4752-a39d-91c72ce85300"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description24", 0m, 24000m, false, null, "Name24", 24000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 24, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("bcd98393-f1b9-4a27-b656-494fcb7e7507"), "", new Guid("e253b3f3-a72c-4709-991d-8881ad3352be"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description31", 0m, 31000m, false, null, "Name31", 31000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 31, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("bdb873ed-d11d-454b-9c21-fa466afe3d39"), "", new Guid("5e99b617-1964-46f1-97b4-d2eb1d7ad698"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description22", 0m, 22000m, false, null, "Name22", 22000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 22, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("c87eed72-9870-4c80-9ce2-d44f474ea081"), "", new Guid("33e847f6-e6f8-4142-a83c-4bd08d71769b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description27", 0m, 27000m, false, null, "Name27", 27000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 27, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("cc54d1ab-fb3c-437c-a467-9275b5c1e21a"), "", new Guid("8fdd0b5b-5cfe-4c9e-b8bb-c088f6a45be2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description26", 0m, 26000m, false, null, "Name26", 26000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 26, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("d028fc93-6c94-414e-b06a-010930ba3d67"), "", new Guid("9ec71f21-d73d-46d0-9b77-342d2a6061fc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description4", 0m, 4000m, false, null, "Name4", 4000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 4, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("d6fb5d3c-976d-430c-b4da-a9a9ddc657d2"), "", new Guid("479f1319-afd0-40a5-b271-1de73934a57c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description23", 0m, 23000m, false, null, "Name23", 23000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 23, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("dd4b6e72-bbb2-4142-8f38-667b5d3f4cb5"), "", new Guid("11e3c4dd-d453-4c8f-95da-2cf27e582645"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description10", 0m, 10000m, false, null, "Name10", 10000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 10, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("f408d5f0-234a-4361-b74a-caf5f20859ee"), "", new Guid("c74f45f7-4f73-4a7c-a563-e34849bad1eb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description29", 0m, 29000m, false, null, "Name29", 29000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 29, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("fc9a9a18-154e-4212-bfb0-5993d5def275"), "", new Guid("3be88443-6664-407c-988f-7d3dc9b07350"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description36", 0m, 36000m, false, null, "Name36", 36000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 36, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") }
                });
        }
    }
}
