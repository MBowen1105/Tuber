﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tuber.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeededProfitTakingFrom25PARLedger : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppConfigs",
                keyColumn: "AppConfigId",
                keyValue: new Guid("de570e94-96ce-4fb8-b33e-22420790f577"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 643, DateTimeKind.Utc).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("1b0a51db-1635-4df2-9faa-7f5d6f0450f1"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(1543), new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("462c8d2c-ddd6-4de5-bc98-21c6094ffa3e"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(1545), new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(1530), new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c8637e26-7598-49ce-89d6-82f2f184f540"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(1536), new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("f0781ba0-c93d-4115-8230-7329e4708c07"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(1538), new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("f9d4bc01-e0b0-43e1-9ef3-b068dfc2fc4a"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(1541), new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 641, DateTimeKind.Utc).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 641, DateTimeKind.Utc).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 641, DateTimeKind.Utc).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 641, DateTimeKind.Utc).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("64fba8d3-cef0-4a73-8f69-3fecfd186bb1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 641, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 641, DateTimeKind.Utc).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("72dfefb5-6408-4e5d-baaa-1217a2c230a4"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 641, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("ac5c2909-d1c7-448a-b59c-8509e19b313d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 641, DateTimeKind.Utc).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 641, DateTimeKind.Utc).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3eefa969-31e0-46d3-9d81-d514035dd3de"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("90af6d97-3a28-47e9-b180-6cd406782c56"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("93678674-f2b0-48a3-91c3-050b506d258d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d2ccc713-366d-4f7d-8716-fab5932ec73c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ff39de05-0b97-4c98-b013-9cee276774cf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("06226032-0cd7-406c-ae33-90aa2061e045"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 643, DateTimeKind.Utc).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("0a7eea23-0537-408e-935a-36e89ea0db6c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 643, DateTimeKind.Utc).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("27b590d4-41d5-4bdd-b593-084bd7756cba"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 643, DateTimeKind.Utc).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("4e01f919-f0a8-47a3-aa32-7140597a640f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 643, DateTimeKind.Utc).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("567b5a46-7b17-4a1e-832e-f009fab60ef8"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 643, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("62846f42-1c01-4b2c-bca1-118dcc5cb7c1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 643, DateTimeKind.Utc).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("6495197d-b80d-4358-9c2c-4e52779614f0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 643, DateTimeKind.Utc).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("67a77698-15bb-4b79-b6a5-e053d9a3fa2f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 643, DateTimeKind.Utc).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("6cc18b28-9390-4837-a181-0444810515e7"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 643, DateTimeKind.Utc).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("857fd6c8-e83f-4155-8909-64de3f18f566"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 643, DateTimeKind.Utc).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("8bae9b31-420c-475d-bdf8-e1c259a62546"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 643, DateTimeKind.Utc).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("97730458-05ef-4e84-9e9f-d7b3d601976f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("9980d6a7-949c-4375-83c9-186efe3c96e8"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 643, DateTimeKind.Utc).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("b581cb5c-8510-48de-b292-bd02641ec08d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 643, DateTimeKind.Utc).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("c13ae2e6-cf8a-4583-8db5-9834bb20fa5a"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 643, DateTimeKind.Utc).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("d37a4933-756f-4e8a-9c93-d812472178f6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 643, DateTimeKind.Utc).AddTicks(7));

            migrationBuilder.InsertData(
                table: "Ledgers",
                columns: new[] { "LedgerId", "Balance", "BankAccountId", "CategoryId", "CreatedByUserId", "CreatedOnUtc", "DateUtc", "Description", "IsReconciled", "MoneyIn", "MoneyOut", "Reference", "RowNumber", "SubcategoryId", "TransactionOrigin", "TransactionType", "TransferBankAccountId", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("069215d0-7731-4751-90f3-4e4e98cf676c"), 4.6500000000000004, new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 15, 36, 42, 643, DateTimeKind.Utc).AddTicks(111), new DateTime(2022, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "M Bowen", false, 200.0, null, "PROFIT TAKING", 1, null, 1, "CREDIT", new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"), null, null },
                    { new Guid("147f2b53-72cb-4bbb-adbf-14e036c97814"), 0.0, new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"), new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 15, 36, 42, 643, DateTimeKind.Utc).AddTicks(114), new DateTime(2022, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "M Bowen", false, null, 200.0, "PROFIT TAKING", 1, null, 1, "CREDIT", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), null, null }
                });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("04ff391a-26fc-408b-b930-731114e2d994"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("179d1384-e290-4bb7-a52d-038a3221d330"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("3077c60b-5d01-4982-b60e-d032cf75d926"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("45048692-c142-48e4-83b8-fdd7177443c9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("566195ce-d7a0-4252-8258-8b7b76b7846c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("5ab8de02-7a92-4df0-8ab3-8c3450fd9545"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("66e06ca1-305c-48db-88bc-155b040fc82f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("85ae154e-960e-4d35-8e77-a9e7d71eddf1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("cac01b14-67a7-4372-8eb1-5e9a0e8a007c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("ccbd867f-a971-4d3c-b879-2fccb8b92981"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("de86efb2-764c-48b0-841a-7e29ecb83640"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 36, 42, 642, DateTimeKind.Utc).AddTicks(7633));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("069215d0-7731-4751-90f3-4e4e98cf676c"));

            migrationBuilder.DeleteData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("147f2b53-72cb-4bbb-adbf-14e036c97814"));

            migrationBuilder.UpdateData(
                table: "AppConfigs",
                keyColumn: "AppConfigId",
                keyValue: new Guid("de570e94-96ce-4fb8-b33e-22420790f577"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 75, DateTimeKind.Utc).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("1b0a51db-1635-4df2-9faa-7f5d6f0450f1"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(723), new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("462c8d2c-ddd6-4de5-bc98-21c6094ffa3e"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(725), new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(711), new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c8637e26-7598-49ce-89d6-82f2f184f540"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(716), new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("f0781ba0-c93d-4115-8230-7329e4708c07"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(719), new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(719) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("f9d4bc01-e0b0-43e1-9ef3-b068dfc2fc4a"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(721), new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 73, DateTimeKind.Utc).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 73, DateTimeKind.Utc).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 73, DateTimeKind.Utc).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 73, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("64fba8d3-cef0-4a73-8f69-3fecfd186bb1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 73, DateTimeKind.Utc).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 73, DateTimeKind.Utc).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("72dfefb5-6408-4e5d-baaa-1217a2c230a4"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 73, DateTimeKind.Utc).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("ac5c2909-d1c7-448a-b59c-8509e19b313d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 73, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 73, DateTimeKind.Utc).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3eefa969-31e0-46d3-9d81-d514035dd3de"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("90af6d97-3a28-47e9-b180-6cd406782c56"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("93678674-f2b0-48a3-91c3-050b506d258d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d2ccc713-366d-4f7d-8716-fab5932ec73c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ff39de05-0b97-4c98-b013-9cee276774cf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("06226032-0cd7-406c-ae33-90aa2061e045"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("0a7eea23-0537-408e-935a-36e89ea0db6c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("27b590d4-41d5-4bdd-b593-084bd7756cba"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("4e01f919-f0a8-47a3-aa32-7140597a640f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("567b5a46-7b17-4a1e-832e-f009fab60ef8"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("62846f42-1c01-4b2c-bca1-118dcc5cb7c1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("6495197d-b80d-4358-9c2c-4e52779614f0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("67a77698-15bb-4b79-b6a5-e053d9a3fa2f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("6cc18b28-9390-4837-a181-0444810515e7"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("857fd6c8-e83f-4155-8909-64de3f18f566"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("8bae9b31-420c-475d-bdf8-e1c259a62546"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("97730458-05ef-4e84-9e9f-d7b3d601976f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("9980d6a7-949c-4375-83c9-186efe3c96e8"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("b581cb5c-8510-48de-b292-bd02641ec08d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("c13ae2e6-cf8a-4583-8db5-9834bb20fa5a"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("d37a4933-756f-4e8a-9c93-d812472178f6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("04ff391a-26fc-408b-b930-731114e2d994"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("179d1384-e290-4bb7-a52d-038a3221d330"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("3077c60b-5d01-4982-b60e-d032cf75d926"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("45048692-c142-48e4-83b8-fdd7177443c9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("566195ce-d7a0-4252-8258-8b7b76b7846c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("5ab8de02-7a92-4df0-8ab3-8c3450fd9545"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("66e06ca1-305c-48db-88bc-155b040fc82f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("85ae154e-960e-4d35-8e77-a9e7d71eddf1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("cac01b14-67a7-4372-8eb1-5e9a0e8a007c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("ccbd867f-a971-4d3c-b879-2fccb8b92981"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("de86efb2-764c-48b0-841a-7e29ecb83640"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 28, 32, 74, DateTimeKind.Utc).AddTicks(7359));
        }
    }
}