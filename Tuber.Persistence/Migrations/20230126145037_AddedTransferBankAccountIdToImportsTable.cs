using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tuber.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedTransferBankAccountIdToImportsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TransferBankAccountId",
                table: "Imports",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppConfigs",
                keyColumn: "AppConfigId",
                keyValue: new Guid("de570e94-96ce-4fb8-b33e-22420790f577"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(5964), new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c8637e26-7598-49ce-89d6-82f2f184f540"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(5971), new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("f0781ba0-c93d-4115-8230-7329e4708c07"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(5973), new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("f9d4bc01-e0b0-43e1-9ef3-b068dfc2fc4a"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(5975), new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("64fba8d3-cef0-4a73-8f69-3fecfd186bb1"),
                columns: new[] { "CreatedOnUtc", "IsDeleted" },
                values: new object[] { new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(3573), false });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("72dfefb5-6408-4e5d-baaa-1217a2c230a4"),
                columns: new[] { "BankName", "CreatedOnUtc", "IsDeleted" },
                values: new object[] { "Principality Building Society", new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(3619), false });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("ac5c2909-d1c7-448a-b59c-8509e19b313d"),
                columns: new[] { "CreatedOnUtc", "IsDeleted" },
                values: new object[] { new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(3617), false });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3eefa969-31e0-46d3-9d81-d514035dd3de"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("90af6d97-3a28-47e9-b180-6cd406782c56"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("93678674-f2b0-48a3-91c3-050b506d258d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ff39de05-0b97-4c98-b013-9cee276774cf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 917, DateTimeKind.Utc).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("06226032-0cd7-406c-ae33-90aa2061e045"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("27b590d4-41d5-4bdd-b593-084bd7756cba"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("4e01f919-f0a8-47a3-aa32-7140597a640f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("567b5a46-7b17-4a1e-832e-f009fab60ef8"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("62846f42-1c01-4b2c-bca1-118dcc5cb7c1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("6495197d-b80d-4358-9c2c-4e52779614f0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("857fd6c8-e83f-4155-8909-64de3f18f566"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("97730458-05ef-4e84-9e9f-d7b3d601976f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("b581cb5c-8510-48de-b292-bd02641ec08d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("d37a4933-756f-4e8a-9c93-d812472178f6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("04ff391a-26fc-408b-b930-731114e2d994"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("179d1384-e290-4bb7-a52d-038a3221d330"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("3077c60b-5d01-4982-b60e-d032cf75d926"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("566195ce-d7a0-4252-8258-8b7b76b7846c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("5ab8de02-7a92-4df0-8ab3-8c3450fd9545"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("66e06ca1-305c-48db-88bc-155b040fc82f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("85ae154e-960e-4d35-8e77-a9e7d71eddf1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("cac01b14-67a7-4372-8eb1-5e9a0e8a007c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("ccbd867f-a971-4d3c-b879-2fccb8b92981"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("de86efb2-764c-48b0-841a-7e29ecb83640"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 14, 50, 36, 918, DateTimeKind.Utc).AddTicks(1966));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransferBankAccountId",
                table: "Imports");

            migrationBuilder.UpdateData(
                table: "AppConfigs",
                keyColumn: "AppConfigId",
                keyValue: new Guid("de570e94-96ce-4fb8-b33e-22420790f577"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(3149), new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c8637e26-7598-49ce-89d6-82f2f184f540"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(3154), new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("f0781ba0-c93d-4115-8230-7329e4708c07"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(3156), new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("f9d4bc01-e0b0-43e1-9ef3-b068dfc2fc4a"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(3159), new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("64fba8d3-cef0-4a73-8f69-3fecfd186bb1"),
                columns: new[] { "CreatedOnUtc", "IsDeleted" },
                values: new object[] { new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(448), true });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("72dfefb5-6408-4e5d-baaa-1217a2c230a4"),
                columns: new[] { "BankName", "CreatedOnUtc", "IsDeleted" },
                values: new object[] { "Principality Buildig Society", new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(450), true });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("ac5c2909-d1c7-448a-b59c-8509e19b313d"),
                columns: new[] { "CreatedOnUtc", "IsDeleted" },
                values: new object[] { new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(449), true });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3eefa969-31e0-46d3-9d81-d514035dd3de"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("90af6d97-3a28-47e9-b180-6cd406782c56"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("93678674-f2b0-48a3-91c3-050b506d258d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ff39de05-0b97-4c98-b013-9cee276774cf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 796, DateTimeKind.Utc).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("06226032-0cd7-406c-ae33-90aa2061e045"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("27b590d4-41d5-4bdd-b593-084bd7756cba"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("4e01f919-f0a8-47a3-aa32-7140597a640f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("567b5a46-7b17-4a1e-832e-f009fab60ef8"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("62846f42-1c01-4b2c-bca1-118dcc5cb7c1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("6495197d-b80d-4358-9c2c-4e52779614f0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("857fd6c8-e83f-4155-8909-64de3f18f566"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("97730458-05ef-4e84-9e9f-d7b3d601976f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("b581cb5c-8510-48de-b292-bd02641ec08d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("d37a4933-756f-4e8a-9c93-d812472178f6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("04ff391a-26fc-408b-b930-731114e2d994"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("179d1384-e290-4bb7-a52d-038a3221d330"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("3077c60b-5d01-4982-b60e-d032cf75d926"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("566195ce-d7a0-4252-8258-8b7b76b7846c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("5ab8de02-7a92-4df0-8ab3-8c3450fd9545"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("66e06ca1-305c-48db-88bc-155b040fc82f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("85ae154e-960e-4d35-8e77-a9e7d71eddf1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("cac01b14-67a7-4372-8eb1-5e9a0e8a007c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("ccbd867f-a971-4d3c-b879-2fccb8b92981"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("de86efb2-764c-48b0-841a-7e29ecb83640"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 13, 36, 13, 797, DateTimeKind.Utc).AddTicks(1179));
        }
    }
}
