using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tuber.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RemovedImportTemplateFromBankAccountModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Banks_ImportTemplates_ImportTemplateId",
                table: "Banks");

            migrationBuilder.DropIndex(
                name: "IX_Banks_ImportTemplateId",
                table: "Banks");

            migrationBuilder.DropColumn(
                name: "ImportTemplateId",
                table: "Banks");

            migrationBuilder.UpdateData(
                table: "AppConfigs",
                keyColumn: "AppConfigId",
                keyValue: new Guid("de570e94-96ce-4fb8-b33e-22420790f577"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 914, DateTimeKind.Utc).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(2838), new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3eefa969-31e0-46d3-9d81-d514035dd3de"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("93678674-f2b0-48a3-91c3-050b506d258d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ff39de05-0b97-4c98-b013-9cee276774cf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("62846f42-1c01-4b2c-bca1-118dcc5cb7c1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 914, DateTimeKind.Utc).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("97730458-05ef-4e84-9e9f-d7b3d601976f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 914, DateTimeKind.Utc).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("b581cb5c-8510-48de-b292-bd02641ec08d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 914, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("04ff391a-26fc-408b-b930-731114e2d994"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("179d1384-e290-4bb7-a52d-038a3221d330"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("3077c60b-5d01-4982-b60e-d032cf75d926"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("566195ce-d7a0-4252-8258-8b7b76b7846c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("66e06ca1-305c-48db-88bc-155b040fc82f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("85ae154e-960e-4d35-8e77-a9e7d71eddf1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("cac01b14-67a7-4372-8eb1-5e9a0e8a007c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("ccbd867f-a971-4d3c-b879-2fccb8b92981"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 34, 41, 913, DateTimeKind.Utc).AddTicks(8622));

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_ImportTemplateId",
                table: "BankAccounts",
                column: "ImportTemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_BankAccounts_ImportTemplates_ImportTemplateId",
                table: "BankAccounts",
                column: "ImportTemplateId",
                principalTable: "ImportTemplates",
                principalColumn: "ImportTemplateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankAccounts_ImportTemplates_ImportTemplateId",
                table: "BankAccounts");

            migrationBuilder.DropIndex(
                name: "IX_BankAccounts_ImportTemplateId",
                table: "BankAccounts");

            migrationBuilder.AddColumn<Guid>(
                name: "ImportTemplateId",
                table: "Banks",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppConfigs",
                keyColumn: "AppConfigId",
                keyValue: new Guid("de570e94-96ce-4fb8-b33e-22420790f577"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 232, DateTimeKind.Utc).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(3393), new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                columns: new[] { "CreatedOnUtc", "ImportTemplateId" },
                values: new object[] { new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(1683), null });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                columns: new[] { "CreatedOnUtc", "ImportTemplateId" },
                values: new object[] { new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(1679), null });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                columns: new[] { "CreatedOnUtc", "ImportTemplateId" },
                values: new object[] { new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(1682), null });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                columns: new[] { "CreatedOnUtc", "ImportTemplateId" },
                values: new object[] { new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(1677), new Guid("f642096e-6573-4deb-96be-efba9016499c") });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                columns: new[] { "CreatedOnUtc", "ImportTemplateId" },
                values: new object[] { new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(1681), null });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                columns: new[] { "CreatedOnUtc", "ImportTemplateId" },
                values: new object[] { new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(1671), new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3eefa969-31e0-46d3-9d81-d514035dd3de"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("93678674-f2b0-48a3-91c3-050b506d258d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ff39de05-0b97-4c98-b013-9cee276774cf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("62846f42-1c01-4b2c-bca1-118dcc5cb7c1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 232, DateTimeKind.Utc).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("97730458-05ef-4e84-9e9f-d7b3d601976f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 232, DateTimeKind.Utc).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("b581cb5c-8510-48de-b292-bd02641ec08d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 232, DateTimeKind.Utc).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("04ff391a-26fc-408b-b930-731114e2d994"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("179d1384-e290-4bb7-a52d-038a3221d330"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("3077c60b-5d01-4982-b60e-d032cf75d926"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("566195ce-d7a0-4252-8258-8b7b76b7846c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("66e06ca1-305c-48db-88bc-155b040fc82f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("85ae154e-960e-4d35-8e77-a9e7d71eddf1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("cac01b14-67a7-4372-8eb1-5e9a0e8a007c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("ccbd867f-a971-4d3c-b879-2fccb8b92981"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 17, 12, 13, 22, 231, DateTimeKind.Utc).AddTicks(9605));

            migrationBuilder.CreateIndex(
                name: "IX_Banks_ImportTemplateId",
                table: "Banks",
                column: "ImportTemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Banks_ImportTemplates_ImportTemplateId",
                table: "Banks",
                column: "ImportTemplateId",
                principalTable: "ImportTemplates",
                principalColumn: "ImportTemplateId");
        }
    }
}
