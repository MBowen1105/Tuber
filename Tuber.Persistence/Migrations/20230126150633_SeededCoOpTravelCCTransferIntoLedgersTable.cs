using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tuber.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeededCoOpTravelCCTransferIntoLedgersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppConfigs",
                keyColumn: "AppConfigId",
                keyValue: new Guid("de570e94-96ce-4fb8-b33e-22420790f577"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 67, DateTimeKind.Utc).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("1b0a51db-1635-4df2-9faa-7f5d6f0450f1"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(3169), new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(3157), new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c8637e26-7598-49ce-89d6-82f2f184f540"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(3162), new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("f0781ba0-c93d-4115-8230-7329e4708c07"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(3165), new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("f9d4bc01-e0b0-43e1-9ef3-b068dfc2fc4a"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(3167), new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(3168) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "BankAccountId", "BankAccountName", "BankId", "CreatedByUserId", "CreatedOnUtc", "ImportTemplateId", "IsDeleted", "OrderBy", "UKBankAccount", "UKSortCode", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[] { new Guid("462c8d2c-ddd6-4de5-bc98-21c6094ffa3e"), "Co-Op Travel Credit Card", new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(3172), null, true, 10, "", "", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("64fba8d3-cef0-4a73-8f69-3fecfd186bb1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("72dfefb5-6408-4e5d-baaa-1217a2c230a4"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("ac5c2909-d1c7-448a-b59c-8509e19b313d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3eefa969-31e0-46d3-9d81-d514035dd3de"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("90af6d97-3a28-47e9-b180-6cd406782c56"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("93678674-f2b0-48a3-91c3-050b506d258d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ff39de05-0b97-4c98-b013-9cee276774cf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("06226032-0cd7-406c-ae33-90aa2061e045"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 67, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("27b590d4-41d5-4bdd-b593-084bd7756cba"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 67, DateTimeKind.Utc).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("4e01f919-f0a8-47a3-aa32-7140597a640f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 67, DateTimeKind.Utc).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("567b5a46-7b17-4a1e-832e-f009fab60ef8"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 67, DateTimeKind.Utc).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("62846f42-1c01-4b2c-bca1-118dcc5cb7c1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 67, DateTimeKind.Utc).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("6495197d-b80d-4358-9c2c-4e52779614f0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 67, DateTimeKind.Utc).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("67a77698-15bb-4b79-b6a5-e053d9a3fa2f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 67, DateTimeKind.Utc).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("857fd6c8-e83f-4155-8909-64de3f18f566"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 67, DateTimeKind.Utc).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("8bae9b31-420c-475d-bdf8-e1c259a62546"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 67, DateTimeKind.Utc).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("97730458-05ef-4e84-9e9f-d7b3d601976f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 67, DateTimeKind.Utc).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("b581cb5c-8510-48de-b292-bd02641ec08d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 67, DateTimeKind.Utc).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("c13ae2e6-cf8a-4583-8db5-9834bb20fa5a"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 67, DateTimeKind.Utc).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("d37a4933-756f-4e8a-9c93-d812472178f6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 67, DateTimeKind.Utc).AddTicks(1500));

            migrationBuilder.InsertData(
                table: "Ledgers",
                columns: new[] { "LedgerId", "Balance", "BankAccountId", "CategoryId", "CreatedByUserId", "CreatedOnUtc", "DateUtc", "Description", "IsReconciled", "MoneyIn", "MoneyOut", "Reference", "RowNumber", "SubcategoryId", "TransactionOrigin", "TransactionType", "TransferBankAccountId", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[] { new Guid("9980d6a7-949c-4375-83c9-186efe3c96e8"), -190.36000000000001, new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 15, 6, 33, 67, DateTimeKind.Utc).AddTicks(1576), new DateTime(2022, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "THE CO-OP BANK", false, null, 5.9900000000000002, "4552061305790731", 3, null, 1, "DD", new Guid("462c8d2c-ddd6-4de5-bc98-21c6094ffa3e"), null, null });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("04ff391a-26fc-408b-b930-731114e2d994"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("179d1384-e290-4bb7-a52d-038a3221d330"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("3077c60b-5d01-4982-b60e-d032cf75d926"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("566195ce-d7a0-4252-8258-8b7b76b7846c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("5ab8de02-7a92-4df0-8ab3-8c3450fd9545"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("66e06ca1-305c-48db-88bc-155b040fc82f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("85ae154e-960e-4d35-8e77-a9e7d71eddf1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("cac01b14-67a7-4372-8eb1-5e9a0e8a007c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("ccbd867f-a971-4d3c-b879-2fccb8b92981"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("de86efb2-764c-48b0-841a-7e29ecb83640"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 15, 6, 33, 66, DateTimeKind.Utc).AddTicks(9097));

            migrationBuilder.InsertData(
                table: "Ledgers",
                columns: new[] { "LedgerId", "Balance", "BankAccountId", "CategoryId", "CreatedByUserId", "CreatedOnUtc", "DateUtc", "Description", "IsReconciled", "MoneyIn", "MoneyOut", "Reference", "RowNumber", "SubcategoryId", "TransactionOrigin", "TransactionType", "TransferBankAccountId", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[] { new Guid("6cc18b28-9390-4837-a181-0444810515e7"), 0.0, new Guid("462c8d2c-ddd6-4de5-bc98-21c6094ffa3e"), new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 15, 6, 33, 67, DateTimeKind.Utc).AddTicks(1579), new DateTime(2022, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "THE CO-OP BANK", false, 5.9900000000000002, null, "4552061305790731", 1, null, 1, "DD", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("6cc18b28-9390-4837-a181-0444810515e7"));

            migrationBuilder.DeleteData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("9980d6a7-949c-4375-83c9-186efe3c96e8"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("462c8d2c-ddd6-4de5-bc98-21c6094ffa3e"));

            migrationBuilder.UpdateData(
                table: "AppConfigs",
                keyColumn: "AppConfigId",
                keyValue: new Guid("de570e94-96ce-4fb8-b33e-22420790f577"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("1b0a51db-1635-4df2-9faa-7f5d6f0450f1"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(4836), new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(4822), new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c8637e26-7598-49ce-89d6-82f2f184f540"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(4827), new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("f0781ba0-c93d-4115-8230-7329e4708c07"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(4830), new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("f9d4bc01-e0b0-43e1-9ef3-b068dfc2fc4a"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(4833), new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("64fba8d3-cef0-4a73-8f69-3fecfd186bb1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("72dfefb5-6408-4e5d-baaa-1217a2c230a4"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("ac5c2909-d1c7-448a-b59c-8509e19b313d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3eefa969-31e0-46d3-9d81-d514035dd3de"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("90af6d97-3a28-47e9-b180-6cd406782c56"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("93678674-f2b0-48a3-91c3-050b506d258d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ff39de05-0b97-4c98-b013-9cee276774cf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 162, DateTimeKind.Utc).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("06226032-0cd7-406c-ae33-90aa2061e045"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("27b590d4-41d5-4bdd-b593-084bd7756cba"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("4e01f919-f0a8-47a3-aa32-7140597a640f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("567b5a46-7b17-4a1e-832e-f009fab60ef8"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("62846f42-1c01-4b2c-bca1-118dcc5cb7c1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("6495197d-b80d-4358-9c2c-4e52779614f0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("67a77698-15bb-4b79-b6a5-e053d9a3fa2f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("857fd6c8-e83f-4155-8909-64de3f18f566"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("8bae9b31-420c-475d-bdf8-e1c259a62546"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("97730458-05ef-4e84-9e9f-d7b3d601976f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("b581cb5c-8510-48de-b292-bd02641ec08d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("c13ae2e6-cf8a-4583-8db5-9834bb20fa5a"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("d37a4933-756f-4e8a-9c93-d812472178f6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("04ff391a-26fc-408b-b930-731114e2d994"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("179d1384-e290-4bb7-a52d-038a3221d330"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("3077c60b-5d01-4982-b60e-d032cf75d926"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("566195ce-d7a0-4252-8258-8b7b76b7846c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("5ab8de02-7a92-4df0-8ab3-8c3450fd9545"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("66e06ca1-305c-48db-88bc-155b040fc82f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("85ae154e-960e-4d35-8e77-a9e7d71eddf1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("cac01b14-67a7-4372-8eb1-5e9a0e8a007c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("ccbd867f-a971-4d3c-b879-2fccb8b92981"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("de86efb2-764c-48b0-841a-7e29ecb83640"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 58, 0, 163, DateTimeKind.Utc).AddTicks(1813));
        }
    }
}
