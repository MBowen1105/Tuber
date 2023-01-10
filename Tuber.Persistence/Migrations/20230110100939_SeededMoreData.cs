using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tuber.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeededMoreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 803, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 803, DateTimeKind.Utc).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 803, DateTimeKind.Utc).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 10, 10, 9, 38, 803, DateTimeKind.Utc).AddTicks(3612), new DateTime(2023, 1, 10, 10, 9, 38, 803, DateTimeKind.Utc).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 803, DateTimeKind.Utc).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 803, DateTimeKind.Utc).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 803, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 803, DateTimeKind.Utc).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 803, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 803, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 803, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 803, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 804, DateTimeKind.Utc).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3eefa969-31e0-46d3-9d81-d514035dd3de"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 804, DateTimeKind.Utc).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("93678674-f2b0-48a3-91c3-050b506d258d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 804, DateTimeKind.Utc).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 804, DateTimeKind.Utc).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 804, DateTimeKind.Utc).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ff39de05-0b97-4c98-b013-9cee276774cf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 804, DateTimeKind.Utc).AddTicks(2524));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CreatedByUserId", "CreatedOnUtc", "IsCoreCategory", "IsDeleted", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[] { new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"), "Interest Earned", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 10, 10, 9, 38, 804, DateTimeKind.Utc).AddTicks(2527), true, false, null, null });

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 803, DateTimeKind.Utc).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 803, DateTimeKind.Utc).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("b581cb5c-8510-48de-b292-bd02641ec08d"),
                columns: new[] { "Balance", "CreatedOnUtc", "DateUtc", "MoneyOut" },
                values: new object[] { 1430.8900000000001, new DateTime(2023, 1, 10, 10, 9, 38, 804, DateTimeKind.Utc).AddTicks(7323), new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.0 });

            migrationBuilder.InsertData(
                table: "Ledgers",
                columns: new[] { "LedgerId", "Balance", "BankAccountId", "CategorySubcategoryId", "CreatedByUserId", "CreatedOnUtc", "DateUtc", "Description", "MoneyIn", "MoneyOut", "Reference", "TransactionType", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("62846f42-1c01-4b2c-bca1-118dcc5cb7c1"), 2056.3200000000002, new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), new Guid("daaf4e6f-00dd-40c0-837f-cb566deb743f"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 10, 10, 9, 38, 804, DateTimeKind.Utc).AddTicks(7327), new DateTime(2022, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "DEBIT INTEREST", 0.17000000000000001, null, "INTEREST", "DD", null, null },
                    { new Guid("97730458-05ef-4e84-9e9f-d7b3d601976f"), 1406.3199999999999, new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), new Guid("a913b3e2-ab64-4a83-8e61-b41930638b9f"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 10, 10, 9, 38, 804, DateTimeKind.Utc).AddTicks(7229), new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "EE LIMITED", null, 24.57, "Q08791420324918228", "DD", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("04ff391a-26fc-408b-b930-731114e2d994"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 804, DateTimeKind.Utc).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("179d1384-e290-4bb7-a52d-038a3221d330"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 804, DateTimeKind.Utc).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("3077c60b-5d01-4982-b60e-d032cf75d926"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 804, DateTimeKind.Utc).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("566195ce-d7a0-4252-8258-8b7b76b7846c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 804, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("66e06ca1-305c-48db-88bc-155b040fc82f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 804, DateTimeKind.Utc).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("85ae154e-960e-4d35-8e77-a9e7d71eddf1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 804, DateTimeKind.Utc).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("cac01b14-67a7-4372-8eb1-5e9a0e8a007c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 10, 9, 38, 804, DateTimeKind.Utc).AddTicks(3641));

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "SubcategoryId", "CreatedByUserId", "CreatedOnUtc", "IsCoreSubcategory", "IsDeleted", "SubcategoryName", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[] { new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 10, 10, 9, 38, 804, DateTimeKind.Utc).AddTicks(3674), true, false, "Mobile", null, null });

            migrationBuilder.InsertData(
                table: "CategorySubcategories",
                columns: new[] { "CategorySubcategoryId", "CategoryId", "IsCoreCategorySubcategory", "IsDeleted", "SubcategoryId" },
                values: new object[,]
                {
                    { new Guid("a913b3e2-ab64-4a83-8e61-b41930638b9f"), new Guid("93678674-f2b0-48a3-91c3-050b506d258d"), true, false, new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b") },
                    { new Guid("daaf4e6f-00dd-40c0-837f-cb566deb743f"), new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"), true, false, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategorySubcategories",
                keyColumn: "CategorySubcategoryId",
                keyValue: new Guid("a913b3e2-ab64-4a83-8e61-b41930638b9f"));

            migrationBuilder.DeleteData(
                table: "CategorySubcategories",
                keyColumn: "CategorySubcategoryId",
                keyValue: new Guid("daaf4e6f-00dd-40c0-837f-cb566deb743f"));

            migrationBuilder.DeleteData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("62846f42-1c01-4b2c-bca1-118dcc5cb7c1"));

            migrationBuilder.DeleteData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("97730458-05ef-4e84-9e9f-d7b3d601976f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b"));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 691, DateTimeKind.Utc).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 691, DateTimeKind.Utc).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 691, DateTimeKind.Utc).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 10, 9, 32, 33, 691, DateTimeKind.Utc).AddTicks(523), new DateTime(2023, 1, 10, 9, 32, 33, 691, DateTimeKind.Utc).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 691, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 691, DateTimeKind.Utc).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 690, DateTimeKind.Utc).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 690, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 690, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 690, DateTimeKind.Utc).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 690, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 690, DateTimeKind.Utc).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 692, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3eefa969-31e0-46d3-9d81-d514035dd3de"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 692, DateTimeKind.Utc).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("93678674-f2b0-48a3-91c3-050b506d258d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 692, DateTimeKind.Utc).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 692, DateTimeKind.Utc).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 692, DateTimeKind.Utc).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ff39de05-0b97-4c98-b013-9cee276774cf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 692, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 691, DateTimeKind.Utc).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 691, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("b581cb5c-8510-48de-b292-bd02641ec08d"),
                columns: new[] { "Balance", "CreatedOnUtc", "DateUtc", "MoneyOut" },
                values: new object[] { 604.44000000000005, new DateTime(2023, 1, 10, 9, 32, 33, 692, DateTimeKind.Utc).AddTicks(5733), new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0 });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("04ff391a-26fc-408b-b930-731114e2d994"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 692, DateTimeKind.Utc).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("179d1384-e290-4bb7-a52d-038a3221d330"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 692, DateTimeKind.Utc).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("3077c60b-5d01-4982-b60e-d032cf75d926"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 692, DateTimeKind.Utc).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("566195ce-d7a0-4252-8258-8b7b76b7846c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 692, DateTimeKind.Utc).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("66e06ca1-305c-48db-88bc-155b040fc82f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 692, DateTimeKind.Utc).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("85ae154e-960e-4d35-8e77-a9e7d71eddf1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 692, DateTimeKind.Utc).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("cac01b14-67a7-4372-8eb1-5e9a0e8a007c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 10, 9, 32, 33, 692, DateTimeKind.Utc).AddTicks(1967));
        }
    }
}
