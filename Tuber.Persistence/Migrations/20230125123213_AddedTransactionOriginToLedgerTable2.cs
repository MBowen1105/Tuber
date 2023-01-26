﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tuber.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedTransactionOriginToLedgerTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppConfigs",
                keyColumn: "AppConfigId",
                keyValue: new Guid("de570e94-96ce-4fb8-b33e-22420790f577"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 506, DateTimeKind.Utc).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(2183), new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c8637e26-7598-49ce-89d6-82f2f184f540"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(2188), new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 504, DateTimeKind.Utc).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 504, DateTimeKind.Utc).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 504, DateTimeKind.Utc).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 504, DateTimeKind.Utc).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("64fba8d3-cef0-4a73-8f69-3fecfd186bb1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 504, DateTimeKind.Utc).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 504, DateTimeKind.Utc).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 504, DateTimeKind.Utc).AddTicks(9833));

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "BankId", "BankName", "CreatedByUserId", "CreatedOnUtc", "IsDeleted", "OrderBy", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[] { new Guid("ac5c2909-d1c7-448a-b59c-8509e19b313d"), "Scottish Widows", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 25, 12, 32, 12, 504, DateTimeKind.Utc).AddTicks(9844), true, 70, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3eefa969-31e0-46d3-9d81-d514035dd3de"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("90af6d97-3a28-47e9-b180-6cd406782c56"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("93678674-f2b0-48a3-91c3-050b506d258d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ff39de05-0b97-4c98-b013-9cee276774cf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("62846f42-1c01-4b2c-bca1-118dcc5cb7c1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 506, DateTimeKind.Utc).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("97730458-05ef-4e84-9e9f-d7b3d601976f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 506, DateTimeKind.Utc).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("b581cb5c-8510-48de-b292-bd02641ec08d"),
                columns: new[] { "Balance", "CreatedOnUtc", "MoneyIn", "MoneyOut", "RowNumber", "TransferBankAccountId" },
                values: new object[] { 11.890000000000001, new DateTime(2023, 1, 25, 12, 32, 12, 506, DateTimeKind.Utc).AddTicks(604), 11.890000000000001, null, 1, new Guid("0c942b54-d561-499a-843b-e4387e7e6415") });

            migrationBuilder.InsertData(
                table: "Ledgers",
                columns: new[] { "LedgerId", "Balance", "BankAccountId", "CategoryId", "CreatedByUserId", "CreatedOnUtc", "DateUtc", "Description", "IsReconciled", "MoneyIn", "MoneyOut", "Reference", "RowNumber", "SubcategoryId", "TransactionOrigin", "TransactionType", "TransferBankAccountId", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("27b590d4-41d5-4bdd-b593-084bd7756cba"), 464.63, new Guid("552d16a1-d98b-48e9-8580-13029843c116"), new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 25, 12, 32, 12, 506, DateTimeKind.Utc).AddTicks(622), new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "TFR 93000810462300", false, 100.0, null, "", 3, null, 1, "TRANSFER", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), null, null },
                    { new Guid("4e01f919-f0a8-47a3-aa32-7140597a640f"), 464.63, new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 25, 12, 32, 12, 506, DateTimeKind.Utc).AddTicks(619), new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "TFR 93000810462300", false, null, 100.0, "", 2, null, 1, "TRANSFER", new Guid("552d16a1-d98b-48e9-8580-13029843c116"), null, null },
                    { new Guid("567b5a46-7b17-4a1e-832e-f009fab60ef8"), 14.630000000000001, new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 25, 12, 32, 12, 506, DateTimeKind.Utc).AddTicks(625), new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "SCOTTISH WIDOWS", false, null, 450.0, "PR859326H", 1, null, 1, "DD", new Guid("f0781ba0-c93d-4115-8230-7329e4708c07"), null, null },
                    { new Guid("857fd6c8-e83f-4155-8909-64de3f18f566"), 595.0, new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 25, 12, 32, 12, 506, DateTimeKind.Utc).AddTicks(608), new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "PAYPAL PAYMENT", false, null, 11.9, "576J2223CC7UY", 2, null, 1, "DD", new Guid("c8637e26-7598-49ce-89d6-82f2f184f540"), null, null },
                    { new Guid("d37a4933-756f-4e8a-9c93-d812472178f6"), 23.789999999999999, new Guid("c8637e26-7598-49ce-89d6-82f2f184f540"), new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 25, 12, 32, 12, 506, DateTimeKind.Utc).AddTicks(611), new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "PAYPAL PAYMENT", false, 11.9, null, "576J2223CC7UY", 2, null, 1, "DD", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), null, null }
                });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("04ff391a-26fc-408b-b930-731114e2d994"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("179d1384-e290-4bb7-a52d-038a3221d330"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("3077c60b-5d01-4982-b60e-d032cf75d926"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("566195ce-d7a0-4252-8258-8b7b76b7846c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("5ab8de02-7a92-4df0-8ab3-8c3450fd9545"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("66e06ca1-305c-48db-88bc-155b040fc82f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("85ae154e-960e-4d35-8e77-a9e7d71eddf1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("cac01b14-67a7-4372-8eb1-5e9a0e8a007c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("ccbd867f-a971-4d3c-b879-2fccb8b92981"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("de86efb2-764c-48b0-841a-7e29ecb83640"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(8244));

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "BankAccountId", "BankAccountName", "BankId", "CreatedByUserId", "CreatedOnUtc", "ImportTemplateId", "IsDeleted", "OrderBy", "UKBankAccount", "UKSortCode", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[] { new Guid("f0781ba0-c93d-4115-8230-7329e4708c07"), "Scottish Widows Pension", new Guid("ac5c2909-d1c7-448a-b59c-8509e19b313d"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(2191), null, true, 10, "", "", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 25, 12, 32, 12, 505, DateTimeKind.Utc).AddTicks(2192) });

            migrationBuilder.InsertData(
                table: "Ledgers",
                columns: new[] { "LedgerId", "Balance", "BankAccountId", "CategoryId", "CreatedByUserId", "CreatedOnUtc", "DateUtc", "Description", "IsReconciled", "MoneyIn", "MoneyOut", "Reference", "RowNumber", "SubcategoryId", "TransactionOrigin", "TransactionType", "TransferBankAccountId", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[] { new Guid("6495197d-b80d-4358-9c2c-4e52779614f0"), 450.0, new Guid("f0781ba0-c93d-4115-8230-7329e4708c07"), new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 25, 12, 32, 12, 506, DateTimeKind.Utc).AddTicks(629), new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "SCOTTISH WIDOWS", false, 450.0, null, "PR859326H", 1, null, 1, "DD", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("27b590d4-41d5-4bdd-b593-084bd7756cba"));

            migrationBuilder.DeleteData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("4e01f919-f0a8-47a3-aa32-7140597a640f"));

            migrationBuilder.DeleteData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("567b5a46-7b17-4a1e-832e-f009fab60ef8"));

            migrationBuilder.DeleteData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("6495197d-b80d-4358-9c2c-4e52779614f0"));

            migrationBuilder.DeleteData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("857fd6c8-e83f-4155-8909-64de3f18f566"));

            migrationBuilder.DeleteData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("d37a4933-756f-4e8a-9c93-d812472178f6"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("f0781ba0-c93d-4115-8230-7329e4708c07"));

            migrationBuilder.DeleteData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("ac5c2909-d1c7-448a-b59c-8509e19b313d"));

            migrationBuilder.UpdateData(
                table: "AppConfigs",
                keyColumn: "AppConfigId",
                keyValue: new Guid("de570e94-96ce-4fb8-b33e-22420790f577"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(721), new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c8637e26-7598-49ce-89d6-82f2f184f540"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(726), new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 539, DateTimeKind.Utc).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 539, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 539, DateTimeKind.Utc).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 539, DateTimeKind.Utc).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("64fba8d3-cef0-4a73-8f69-3fecfd186bb1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 539, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 539, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 539, DateTimeKind.Utc).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3eefa969-31e0-46d3-9d81-d514035dd3de"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("90af6d97-3a28-47e9-b180-6cd406782c56"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("93678674-f2b0-48a3-91c3-050b506d258d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ff39de05-0b97-4c98-b013-9cee276774cf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("62846f42-1c01-4b2c-bca1-118dcc5cb7c1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("97730458-05ef-4e84-9e9f-d7b3d601976f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("b581cb5c-8510-48de-b292-bd02641ec08d"),
                columns: new[] { "Balance", "CreatedOnUtc", "MoneyIn", "MoneyOut", "RowNumber", "TransferBankAccountId" },
                values: new object[] { 595.0, new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(8997), null, 11.9, 2, new Guid("c8637e26-7598-49ce-89d6-82f2f184f540") });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("04ff391a-26fc-408b-b930-731114e2d994"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("179d1384-e290-4bb7-a52d-038a3221d330"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("3077c60b-5d01-4982-b60e-d032cf75d926"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("566195ce-d7a0-4252-8258-8b7b76b7846c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("5ab8de02-7a92-4df0-8ab3-8c3450fd9545"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("66e06ca1-305c-48db-88bc-155b040fc82f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("85ae154e-960e-4d35-8e77-a9e7d71eddf1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("cac01b14-67a7-4372-8eb1-5e9a0e8a007c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("ccbd867f-a971-4d3c-b879-2fccb8b92981"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("de86efb2-764c-48b0-841a-7e29ecb83640"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 25, 11, 39, 24, 540, DateTimeKind.Utc).AddTicks(6580));
        }
    }
}
