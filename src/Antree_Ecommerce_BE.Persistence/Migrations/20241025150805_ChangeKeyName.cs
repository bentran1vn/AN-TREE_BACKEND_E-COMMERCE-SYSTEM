using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Antree_Ecommerce_BE.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ChangeKeyName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("07c87b27-4993-464a-a0b0-6d6fc597ba7d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0a3b835c-7699-411c-b6d3-8cd6f529865e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0bb778c0-5638-42f9-8684-37a6088d3c29"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1f1e07fb-044e-4975-8c45-99ce56293b53"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("28f17455-4003-470d-866c-25c17c26cd2e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("28f6da46-e622-49b4-9c0c-2b710d842f64"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3a00a993-b4b7-4fcb-8b0f-eed8de59ecd7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3a2b5f7e-bd7b-4c3b-8895-19f89358da3a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3dbd3b25-e721-4153-bfe8-98a1bcd9c9b5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("414dde90-57ac-4d71-8772-25ba0cbf200d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4e63525d-162d-4d36-a305-e0ca37b79285"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("502a9d5d-1a55-4e75-9d58-883b6cf09066"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("52ab0332-4a7c-4d9a-a7fc-63a46ee8ab04"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6025d180-cecd-41cc-b2ab-eb7cd91d48bd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("63164574-f5d1-47a1-9b31-ac583ff6e13e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("696d6a1f-4cd0-4597-b0ec-1797a81ed40f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6f8e118e-d18d-4ab3-9abb-2946ece08327"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("70155627-ff2d-411d-8115-8842677a2fca"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("786cfd24-ac8a-4dd0-87b7-1360a577b677"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("795c30cf-d224-4192-bf5f-bf80a3ad59bc"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8420ba5a-6398-4fd9-8872-efd7d15f98e7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("92ba4058-e645-4819-83c6-47934ed37e01"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a4c88770-4213-4a49-a8b7-600d8e1296e8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a5140a5f-a6f4-42d5-a838-4f4baece2073"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b5b33ce2-d2d3-45c0-8074-f19cecf72c3c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b7d2af14-7235-42a7-9e3a-2efd01dd5aee"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("bc431149-c1d1-49b0-b467-3be31acadd57"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c185291e-e439-4902-8a47-b14f68bf2678"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c39c4698-d630-45bb-b37d-c82492a482fb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("cf8e9fe3-3943-4f54-91da-a0cad92f2a21"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d00fe4e8-485f-484c-aff2-cd44690c529e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d736e995-5d8a-4e5b-8cfc-b5f3d9aec89d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("db1aa07f-a34c-4352-ad20-6ccffafffe26"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e1ab5561-5807-46bc-800c-222a68806f3f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e1d2e020-7bbb-41f4-82fb-57989926e9b7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e4a5e285-2a0e-4353-995a-06af97335943"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e4f6eb34-07e0-4307-b87f-ae838b945670"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e6d47ee6-43ff-416b-aef3-65266500fa79"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e8bdca54-27a5-45a2-a5b0-84345a88f121"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ee47df60-bc29-4bc5-9b3f-afe9e8547322"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ffc676c0-8ff8-4fc1-9c38-f6211af1de2a"));

            migrationBuilder.DropColumn(
                name: "SubcriptionId",
                table: "Transaction");

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CoverImage", "CreatedBy", "CreatedOnUtc", "Description", "DiscountPercent", "DiscountSold", "IsDeleted", "ModifiedOnUtc", "Name", "Price", "ProductCategoryId", "Sku", "Sold", "UpdatedBy", "VendorId" },
                values: new object[,]
                {
                    { new Guid("030210f4-41b8-4c82-8895-eab9474e46fe"), "", new Guid("e9f7fa9b-d314-4206-a4b3-578471ed455b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description8", 0m, 8000m, false, null, "Name8", 8000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 8, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("0a1a4518-97e0-4f12-9651-ef107f2020b6"), "", new Guid("a6eda747-ade8-4876-96c3-a1ea538630f5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description12", 0m, 12000m, false, null, "Name12", 12000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 12, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("0a998f50-41ee-43fe-8ec7-4c37e0fb3062"), "", new Guid("5f18bdf1-99dc-4c52-9413-434af273d8b6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description4", 0m, 4000m, false, null, "Name4", 4000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 4, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("0af8ed40-2207-4ecc-a064-bf8508bcd5d0"), "", new Guid("779ba4f8-a297-4564-ac34-83dcae1e6a04"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description14", 0m, 14000m, false, null, "Name14", 14000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 14, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("14950139-70ef-4718-a1c2-2328245ef8cf"), "", new Guid("a101a66f-c1d4-4703-9d7e-b84563a25ecb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description32", 0m, 32000m, false, null, "Name32", 32000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 32, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("1b92ddf1-371e-45be-925f-24a11324ec90"), "", new Guid("24c635ef-4b1f-482e-98b4-cea18991a1a6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description30", 0m, 30000m, false, null, "Name30", 30000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 30, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("224e49c2-c0a8-4a80-8978-e87db4d2ec75"), "", new Guid("67bed332-c44f-4fdc-a1bc-671705187c52"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description31", 0m, 31000m, false, null, "Name31", 31000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 31, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("28847322-a2c2-4b7f-82c4-3bdbe944b5ca"), "", new Guid("39cc840a-e11d-4636-b0a2-ad817b209a5d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description16", 0m, 16000m, false, null, "Name16", 16000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 16, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("303c1711-a1a7-42fc-b4a4-8d4d76bfd44a"), "", new Guid("2eb63c53-69d2-4a77-89a6-aaae0c1aebd0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description0", 0m, 0m, false, null, "Name0", 0m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("35e0d54f-2d41-4bc5-9772-d14a77777362"), "", new Guid("f1dbae2d-ba74-4c66-88bc-d1782702d97c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description24", 0m, 24000m, false, null, "Name24", 24000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 24, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("3a6e80c2-522f-4341-9b28-018a40a164db"), "", new Guid("f8d7cffb-5194-4182-adcb-158ee3b169a3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description19", 0m, 19000m, false, null, "Name19", 19000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 19, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("559147a7-4d0e-40eb-a318-e99af39df468"), "", new Guid("2ef1b183-2995-45e1-8b4f-f9ac84220594"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description28", 0m, 28000m, false, null, "Name28", 28000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 28, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("5705ba52-a0f4-4b6d-ad8c-901a9b8c5d57"), "", new Guid("453fd614-0ca2-4415-a654-08aa6bf12b38"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description23", 0m, 23000m, false, null, "Name23", 23000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 23, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("5a4e0c89-9808-42e9-8702-da08bb69e55a"), "", new Guid("f059f439-2fe7-4da3-90de-f1d442219183"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description15", 0m, 15000m, false, null, "Name15", 15000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 15, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("5c43f8ad-c1ae-4728-a037-d6ba1938eae6"), "", new Guid("14585a45-7b59-4aa9-99c6-1b8947bb91e6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description6", 0m, 6000m, false, null, "Name6", 6000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 6, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("6245d56b-6363-4405-ae51-95c36052994e"), "", new Guid("3959d21a-f4c5-42e8-964e-9b7925940ee0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description33", 0m, 33000m, false, null, "Name33", 33000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 33, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("7081e058-605a-47b0-be27-ab4d184698f7"), "", new Guid("e00c5dd2-1e59-444c-8738-c031be65ee53"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description40", 0m, 40000m, false, null, "Name40", 40000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 40, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("732f561f-4587-4241-9429-b6d6bbc12538"), "", new Guid("b4ec5f8b-d80b-4231-bbcc-159f118fecb7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description35", 0m, 35000m, false, null, "Name35", 35000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 35, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("787369ca-4a9e-4874-897e-b50c2871bfdf"), "", new Guid("db286ef3-f6d2-4498-a389-6fc91edf1928"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description37", 0m, 37000m, false, null, "Name37", 37000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 37, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("7c53a00e-ac4c-4305-8d0f-af191ecb0e9d"), "", new Guid("7f2baebd-eb65-49fc-809f-6efaa59a78f1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description3", 0m, 3000m, false, null, "Name3", 3000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 3, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("838ac41f-d5ed-454f-b817-0accc67184e7"), "", new Guid("23ebaabf-262e-4917-90e7-050fcab13ee3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description27", 0m, 27000m, false, null, "Name27", 27000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 27, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("883be5e5-88ee-4849-b8fd-59d5c2bb51c3"), "", new Guid("67fa1180-6c87-4b24-a03d-c58986a04e9c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description18", 0m, 18000m, false, null, "Name18", 18000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 18, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("89166b4c-ccc9-4a9a-99bf-070806e45ef0"), "", new Guid("14b13418-b3a1-4494-b5f8-91c7dcd8a2de"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description39", 0m, 39000m, false, null, "Name39", 39000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 39, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("89a3f66f-bd78-4722-9556-02195abccbbe"), "", new Guid("869de74a-4ab7-44a2-abc9-45581ddada4b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description2", 0m, 2000m, false, null, "Name2", 2000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 2, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("9c110684-1c8e-42c6-ab1c-32af4f58d66b"), "", new Guid("e865702c-cc86-442f-b5b2-4a6158249ebd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description21", 0m, 21000m, false, null, "Name21", 21000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 21, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("a3c5a77e-804f-49c8-8476-2ac8fb851ed5"), "", new Guid("cb256683-6fb9-4d3b-9a0b-7e31ade12956"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description20", 0m, 20000m, false, null, "Name20", 20000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 20, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("b033a874-6dd8-4388-89e5-42b5a85f8b03"), "", new Guid("5b841c86-a5a6-4758-9074-534b5d5e87dd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description7", 0m, 7000m, false, null, "Name7", 7000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 7, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("bfb921c5-0cdb-4992-b91f-0e102d5e44b4"), "", new Guid("13291dbf-89d3-44fc-b8e4-69ff39323555"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description5", 0m, 5000m, false, null, "Name5", 5000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 5, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("bffbacec-d193-4f82-86d0-12fd3c68000f"), "", new Guid("57792249-ea5d-45db-bf1e-e96c1915bec4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description10", 0m, 10000m, false, null, "Name10", 10000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 10, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("c3a1b8fa-4c76-40ef-a583-95fe6aa883f6"), "", new Guid("c1278712-88f2-4bf4-9352-51809122605d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description26", 0m, 26000m, false, null, "Name26", 26000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 26, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("d6f9e6c3-f644-4fb4-8f3c-619310876aaa"), "", new Guid("74aabf4e-76fe-4390-b454-592071d5e71e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description9", 0m, 9000m, false, null, "Name9", 9000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 9, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("df8e3b4a-3aac-42e3-94bd-efada7835b45"), "", new Guid("80127793-05cb-41f8-8262-b8c783f3444d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description22", 0m, 22000m, false, null, "Name22", 22000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 22, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("e15f88b4-cbc3-43cb-9168-fe81b691ed2f"), "", new Guid("fce15b7f-f7fc-4b5d-99e4-a812408aa44b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description29", 0m, 29000m, false, null, "Name29", 29000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 29, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("e628992c-46ed-4119-bd07-4fffc516fe4d"), "", new Guid("6ba83ea8-385c-4084-b92e-489323bde62d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description17", 0m, 17000m, false, null, "Name17", 17000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 17, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("e7d69a4e-54ca-4351-9303-457bcd7e638b"), "", new Guid("f72f515c-f92e-4b40-8143-90e662907f34"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description36", 0m, 36000m, false, null, "Name36", 36000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 36, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("ec11a47a-9b2f-43c8-91a7-05d2fb028254"), "", new Guid("170720e4-0133-412a-8b18-40f16fff2701"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description11", 0m, 11000m, false, null, "Name11", 11000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 11, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("ed646fb4-5f2a-4fe1-b45a-e0aed1770503"), "", new Guid("4fce31a6-9e0a-43c3-b87a-551a127c92a4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description25", 0m, 25000m, false, null, "Name25", 25000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 25, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("efdb447c-2aef-448f-a853-01b106fb9316"), "", new Guid("512bb51f-f5cd-44bd-87e4-97416e98b363"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description13", 0m, 13000m, false, null, "Name13", 13000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 13, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("f2b2f9a8-1f82-4971-b6cd-3b61002b9239"), "", new Guid("7223b0bc-562b-49dc-af1b-9be4f39e7c15"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description1", 0m, 1000m, false, null, "Name1", 1000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 1, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("f93bf9fb-c962-49e3-bc9d-f42ba7430025"), "", new Guid("05003702-6948-4ee5-9612-f97685ec2076"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description34", 0m, 34000m, false, null, "Name34", 34000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 34, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("fa00bea1-f810-47ff-ade0-e82ba165cc28"), "", new Guid("9706e106-1489-4168-b097-35fb873f5337"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description38", 0m, 38000m, false, null, "Name38", 38000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 38, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("030210f4-41b8-4c82-8895-eab9474e46fe"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0a1a4518-97e0-4f12-9651-ef107f2020b6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0a998f50-41ee-43fe-8ec7-4c37e0fb3062"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0af8ed40-2207-4ecc-a064-bf8508bcd5d0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("14950139-70ef-4718-a1c2-2328245ef8cf"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1b92ddf1-371e-45be-925f-24a11324ec90"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("224e49c2-c0a8-4a80-8978-e87db4d2ec75"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("28847322-a2c2-4b7f-82c4-3bdbe944b5ca"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("303c1711-a1a7-42fc-b4a4-8d4d76bfd44a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("35e0d54f-2d41-4bc5-9772-d14a77777362"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3a6e80c2-522f-4341-9b28-018a40a164db"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("559147a7-4d0e-40eb-a318-e99af39df468"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5705ba52-a0f4-4b6d-ad8c-901a9b8c5d57"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5a4e0c89-9808-42e9-8702-da08bb69e55a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5c43f8ad-c1ae-4728-a037-d6ba1938eae6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6245d56b-6363-4405-ae51-95c36052994e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7081e058-605a-47b0-be27-ab4d184698f7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("732f561f-4587-4241-9429-b6d6bbc12538"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("787369ca-4a9e-4874-897e-b50c2871bfdf"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7c53a00e-ac4c-4305-8d0f-af191ecb0e9d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("838ac41f-d5ed-454f-b817-0accc67184e7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("883be5e5-88ee-4849-b8fd-59d5c2bb51c3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("89166b4c-ccc9-4a9a-99bf-070806e45ef0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("89a3f66f-bd78-4722-9556-02195abccbbe"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9c110684-1c8e-42c6-ab1c-32af4f58d66b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a3c5a77e-804f-49c8-8476-2ac8fb851ed5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b033a874-6dd8-4388-89e5-42b5a85f8b03"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("bfb921c5-0cdb-4992-b91f-0e102d5e44b4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("bffbacec-d193-4f82-86d0-12fd3c68000f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c3a1b8fa-4c76-40ef-a583-95fe6aa883f6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d6f9e6c3-f644-4fb4-8f3c-619310876aaa"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("df8e3b4a-3aac-42e3-94bd-efada7835b45"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e15f88b4-cbc3-43cb-9168-fe81b691ed2f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e628992c-46ed-4119-bd07-4fffc516fe4d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e7d69a4e-54ca-4351-9303-457bcd7e638b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ec11a47a-9b2f-43c8-91a7-05d2fb028254"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ed646fb4-5f2a-4fe1-b45a-e0aed1770503"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("efdb447c-2aef-448f-a853-01b106fb9316"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f2b2f9a8-1f82-4971-b6cd-3b61002b9239"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f93bf9fb-c962-49e3-bc9d-f42ba7430025"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("fa00bea1-f810-47ff-ade0-e82ba165cc28"));

            migrationBuilder.AddColumn<Guid>(
                name: "SubcriptionId",
                table: "Transaction",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CoverImage", "CreatedBy", "CreatedOnUtc", "Description", "DiscountPercent", "DiscountSold", "IsDeleted", "ModifiedOnUtc", "Name", "Price", "ProductCategoryId", "Sku", "Sold", "UpdatedBy", "VendorId" },
                values: new object[,]
                {
                    { new Guid("07c87b27-4993-464a-a0b0-6d6fc597ba7d"), "", new Guid("1d02489c-fe00-4020-a490-41eec15516ad"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description18", 0m, 18000m, false, null, "Name18", 18000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 18, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("0a3b835c-7699-411c-b6d3-8cd6f529865e"), "", new Guid("030409de-dc30-4d56-9777-1c8618ed9145"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description2", 0m, 2000m, false, null, "Name2", 2000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 2, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("0bb778c0-5638-42f9-8684-37a6088d3c29"), "", new Guid("4e3e16aa-dff3-4d28-be00-4209d18dd5b7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description28", 0m, 28000m, false, null, "Name28", 28000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 28, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("1f1e07fb-044e-4975-8c45-99ce56293b53"), "", new Guid("f2cd3ebd-c6c3-42ee-b745-d7d1c38368af"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description35", 0m, 35000m, false, null, "Name35", 35000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 35, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("28f17455-4003-470d-866c-25c17c26cd2e"), "", new Guid("161df38b-10e2-4cde-aff8-e6860cf5b383"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description7", 0m, 7000m, false, null, "Name7", 7000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 7, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("28f6da46-e622-49b4-9c0c-2b710d842f64"), "", new Guid("73bf81b3-c7ce-4696-b53f-323ceacd1d3f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description10", 0m, 10000m, false, null, "Name10", 10000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 10, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("3a00a993-b4b7-4fcb-8b0f-eed8de59ecd7"), "", new Guid("838802bc-7212-433c-9d93-567e392a2d0d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description33", 0m, 33000m, false, null, "Name33", 33000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 33, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("3a2b5f7e-bd7b-4c3b-8895-19f89358da3a"), "", new Guid("992412d1-cd33-40ff-a594-04d3df75dcfd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description36", 0m, 36000m, false, null, "Name36", 36000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 36, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("3dbd3b25-e721-4153-bfe8-98a1bcd9c9b5"), "", new Guid("3f2abf72-166e-4713-842e-441f08159be0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description37", 0m, 37000m, false, null, "Name37", 37000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 37, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("414dde90-57ac-4d71-8772-25ba0cbf200d"), "", new Guid("c14a4a26-c621-45cf-9511-f7dc89ceca09"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description38", 0m, 38000m, false, null, "Name38", 38000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 38, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("4e63525d-162d-4d36-a305-e0ca37b79285"), "", new Guid("34caece8-aa43-4dfc-93a4-a9082951c7ed"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description31", 0m, 31000m, false, null, "Name31", 31000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 31, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("502a9d5d-1a55-4e75-9d58-883b6cf09066"), "", new Guid("57ac70dc-ceb1-44ca-b3f9-428e837944fe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description13", 0m, 13000m, false, null, "Name13", 13000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 13, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("52ab0332-4a7c-4d9a-a7fc-63a46ee8ab04"), "", new Guid("402d4479-2430-4307-9687-5acc6a7c4d83"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description11", 0m, 11000m, false, null, "Name11", 11000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 11, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("6025d180-cecd-41cc-b2ab-eb7cd91d48bd"), "", new Guid("b187e099-e49d-43e4-a0f0-95036ae4ac86"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description0", 0m, 0m, false, null, "Name0", 0m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("63164574-f5d1-47a1-9b31-ac583ff6e13e"), "", new Guid("2dba4456-7ead-4a1c-9834-8df6bad64cce"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description34", 0m, 34000m, false, null, "Name34", 34000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 34, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("696d6a1f-4cd0-4597-b0ec-1797a81ed40f"), "", new Guid("e1dcdbc7-83f2-4816-88b0-a1fd10d97e52"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description39", 0m, 39000m, false, null, "Name39", 39000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 39, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("6f8e118e-d18d-4ab3-9abb-2946ece08327"), "", new Guid("60e0db92-f9c7-4da7-a11f-0c1c7b199a76"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description32", 0m, 32000m, false, null, "Name32", 32000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 32, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("70155627-ff2d-411d-8115-8842677a2fca"), "", new Guid("9279d37e-0456-4b97-926e-6e5016936000"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description12", 0m, 12000m, false, null, "Name12", 12000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 12, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("786cfd24-ac8a-4dd0-87b7-1360a577b677"), "", new Guid("a57a99aa-3e4f-408d-92ee-ff11f6f192fc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description1", 0m, 1000m, false, null, "Name1", 1000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 1, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("795c30cf-d224-4192-bf5f-bf80a3ad59bc"), "", new Guid("a5c6e14e-8194-4272-899a-8e590bee34a5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description15", 0m, 15000m, false, null, "Name15", 15000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 15, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("8420ba5a-6398-4fd9-8872-efd7d15f98e7"), "", new Guid("a89380ea-cd86-481a-accc-d16c871b9052"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description4", 0m, 4000m, false, null, "Name4", 4000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 4, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("92ba4058-e645-4819-83c6-47934ed37e01"), "", new Guid("047c9ab5-85c5-4e4b-9020-5720d146463b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description26", 0m, 26000m, false, null, "Name26", 26000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 26, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("a4c88770-4213-4a49-a8b7-600d8e1296e8"), "", new Guid("1ced272e-000b-47fa-9dd6-58ac52639350"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description14", 0m, 14000m, false, null, "Name14", 14000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 14, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("a5140a5f-a6f4-42d5-a838-4f4baece2073"), "", new Guid("33c16661-0de8-4a46-bdb9-0af7cec6a164"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description25", 0m, 25000m, false, null, "Name25", 25000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 25, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("b5b33ce2-d2d3-45c0-8074-f19cecf72c3c"), "", new Guid("7f863542-f848-454f-bd5c-ffd3b0846fae"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description3", 0m, 3000m, false, null, "Name3", 3000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 3, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("b7d2af14-7235-42a7-9e3a-2efd01dd5aee"), "", new Guid("896fe1f3-a4c4-42fd-b43e-5324ed60e2f0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description24", 0m, 24000m, false, null, "Name24", 24000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 24, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("bc431149-c1d1-49b0-b467-3be31acadd57"), "", new Guid("4433b72c-d9a2-4d3d-9d25-706ad5124b87"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description8", 0m, 8000m, false, null, "Name8", 8000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 8, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("c185291e-e439-4902-8a47-b14f68bf2678"), "", new Guid("812b7774-b6db-43f7-83f6-321572d7936c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description20", 0m, 20000m, false, null, "Name20", 20000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 20, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("c39c4698-d630-45bb-b37d-c82492a482fb"), "", new Guid("43acc5bc-5aa7-4e56-b56a-c68637fa1db7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description27", 0m, 27000m, false, null, "Name27", 27000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 27, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("cf8e9fe3-3943-4f54-91da-a0cad92f2a21"), "", new Guid("20554d7c-9d11-4680-acf4-6773543db947"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description17", 0m, 17000m, false, null, "Name17", 17000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 17, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("d00fe4e8-485f-484c-aff2-cd44690c529e"), "", new Guid("b2c3975f-0eb1-46b7-badb-ae7bf4aeca5d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description29", 0m, 29000m, false, null, "Name29", 29000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 29, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("d736e995-5d8a-4e5b-8cfc-b5f3d9aec89d"), "", new Guid("1816b536-eb71-48a1-9322-3e503ae8506a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description23", 0m, 23000m, false, null, "Name23", 23000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 23, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("db1aa07f-a34c-4352-ad20-6ccffafffe26"), "", new Guid("535c49cc-4f1d-4d79-901a-b5b8a6234742"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description5", 0m, 5000m, false, null, "Name5", 5000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 5, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("e1ab5561-5807-46bc-800c-222a68806f3f"), "", new Guid("62718030-d393-4cc1-970f-c3df5a9b7b67"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description19", 0m, 19000m, false, null, "Name19", 19000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 19, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("e1d2e020-7bbb-41f4-82fb-57989926e9b7"), "", new Guid("1d307690-a6b6-48f3-9ff5-58c698d94221"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description21", 0m, 21000m, false, null, "Name21", 21000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 21, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") },
                    { new Guid("e4a5e285-2a0e-4353-995a-06af97335943"), "", new Guid("f94b5fcd-4f8a-4229-ad3a-7879edcbc52b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description22", 0m, 22000m, false, null, "Name22", 22000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 22, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("e4f6eb34-07e0-4307-b87f-ae838b945670"), "", new Guid("5764f64c-2117-42cc-beab-1fe9d868c789"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description16", 0m, 16000m, false, null, "Name16", 16000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 16, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("e6d47ee6-43ff-416b-aef3-65266500fa79"), "", new Guid("46b2e0d9-1a27-4f5a-b57e-58f92a6d16a2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description30", 0m, 30000m, false, null, "Name30", 30000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 30, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("e8bdca54-27a5-45a2-a5b0-84345a88f121"), "", new Guid("1ddccf79-8ac3-479e-a01f-2e9478021bcf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description40", 0m, 40000m, false, null, "Name40", 40000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 40, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("ee47df60-bc29-4bc5-9b3f-afe9e8547322"), "", new Guid("5242f491-4bd6-4c14-a182-e1ad767697fa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description6", 0m, 6000m, false, null, "Name6", 6000m, new Guid("26df3c94-715f-4048-a96a-04a6e80bbd15"), 6, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5ef2d83-48fd-41ea-952b-c3803a59b2c1") },
                    { new Guid("ffc676c0-8ff8-4fc1-9c38-f6211af1de2a"), "", new Guid("7497c0d3-c936-40c4-b59a-cedcc03af27c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Description9", 0m, 9000m, false, null, "Name9", 9000m, new Guid("acc02cc0-825a-4453-b923-e6ae7f4007a4"), 9, 0, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5ab34c8-d8ce-4e30-9446-13735a334ef2") }
                });
        }
    }
}
