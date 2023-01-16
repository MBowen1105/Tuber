using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tuber.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedImportTemplateToBankTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(636), new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 975, DateTimeKind.Utc).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 975, DateTimeKind.Utc).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 975, DateTimeKind.Utc).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 975, DateTimeKind.Utc).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 975, DateTimeKind.Utc).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 975, DateTimeKind.Utc).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3eefa969-31e0-46d3-9d81-d514035dd3de"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("93678674-f2b0-48a3-91c3-050b506d258d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ff39de05-0b97-4c98-b013-9cee276774cf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(4450));

            migrationBuilder.InsertData(
                table: "Ledgers",
                columns: new[] { "LedgerId", "Balance", "BankAccountId", "CategoryId", "CreatedByUserId", "CreatedOnUtc", "DateUtc", "Description", "IsManualEntry", "IsReconciled", "MoneyIn", "MoneyOut", "Reference", "RowNumber", "SubcategoryId", "TransactionType", "TransferBankAccountId", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("62846f42-1c01-4b2c-bca1-118dcc5cb7c1"), 2056.3200000000002, new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(9377), new DateTime(2022, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "DEBIT INTEREST", false, false, 0.17000000000000001, null, "INTEREST", 0, new Guid("ccbd867f-a971-4d3c-b879-2fccb8b92981"), "DD", null, null, null },
                    { new Guid("97730458-05ef-4e84-9e9f-d7b3d601976f"), 1406.3199999999999, new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), new Guid("93678674-f2b0-48a3-91c3-050b506d258d"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(9368), new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "EE LIMITED", false, false, null, 24.57, "Q08791420324918228", 0, new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b"), "DD", null, null, null },
                    { new Guid("b581cb5c-8510-48de-b292-bd02641ec08d"), 1430.8900000000001, new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), new Guid("ff39de05-0b97-4c98-b013-9cee276774cf"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(9373), new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "CAMELOT LOTTERY", false, false, null, 8.0, "A00143/3965", 0, new Guid("85ae154e-960e-4d35-8e77-a9e7d71eddf1"), "DD", null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("04ff391a-26fc-408b-b930-731114e2d994"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("179d1384-e290-4bb7-a52d-038a3221d330"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("3077c60b-5d01-4982-b60e-d032cf75d926"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("566195ce-d7a0-4252-8258-8b7b76b7846c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("66e06ca1-305c-48db-88bc-155b040fc82f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("85ae154e-960e-4d35-8e77-a9e7d71eddf1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("cac01b14-67a7-4372-8eb1-5e9a0e8a007c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("ccbd867f-a971-4d3c-b879-2fccb8b92981"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 12, 53, 14, 976, DateTimeKind.Utc).AddTicks(7088));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("62846f42-1c01-4b2c-bca1-118dcc5cb7c1"));

            migrationBuilder.DeleteData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("97730458-05ef-4e84-9e9f-d7b3d601976f"));

            migrationBuilder.DeleteData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("b581cb5c-8510-48de-b292-bd02641ec08d"));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(2131), new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3eefa969-31e0-46d3-9d81-d514035dd3de"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("93678674-f2b0-48a3-91c3-050b506d258d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ff39de05-0b97-4c98-b013-9cee276774cf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("04ff391a-26fc-408b-b930-731114e2d994"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("179d1384-e290-4bb7-a52d-038a3221d330"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("3077c60b-5d01-4982-b60e-d032cf75d926"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("566195ce-d7a0-4252-8258-8b7b76b7846c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("66e06ca1-305c-48db-88bc-155b040fc82f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("85ae154e-960e-4d35-8e77-a9e7d71eddf1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("cac01b14-67a7-4372-8eb1-5e9a0e8a007c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("ccbd867f-a971-4d3c-b879-2fccb8b92981"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 16, 10, 49, 30, 875, DateTimeKind.Utc).AddTicks(7585));
        }
    }
}
