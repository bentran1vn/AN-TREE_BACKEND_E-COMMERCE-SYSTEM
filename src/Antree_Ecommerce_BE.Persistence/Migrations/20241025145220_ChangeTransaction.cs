using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Antree_Ecommerce_BE.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTransaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Subscription_SubscriptionId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_SubscriptionId",
                table: "User");

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

            migrationBuilder.DropColumn(
                name: "SubscriptionId",
                table: "User");

            migrationBuilder.AddColumn<Guid>(
                name: "SubcriptionId",
                table: "Transaction",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SubscriptionId",
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

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_SubscriptionId",
                table: "Transaction",
                column: "SubscriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Subscription_SubscriptionId",
                table: "Transaction",
                column: "SubscriptionId",
                principalTable: "Subscription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Subscription_SubscriptionId",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_SubscriptionId",
                table: "Transaction");

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

            migrationBuilder.DropColumn(
                name: "SubscriptionId",
                table: "Transaction");

            migrationBuilder.AddColumn<Guid>(
                name: "SubscriptionId",
                table: "User",
                type: "uniqueidentifier",
                nullable: true);

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
                name: "IX_User_SubscriptionId",
                table: "User",
                column: "SubscriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Subscription_SubscriptionId",
                table: "User",
                column: "SubscriptionId",
                principalTable: "Subscription",
                principalColumn: "Id");
        }
    }
}
