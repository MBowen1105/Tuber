using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tuber.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedImportTemplateToCoOpBank : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 28, 25, 44, DateTimeKind.Utc).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 28, 25, 44, DateTimeKind.Utc).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 28, 25, 44, DateTimeKind.Utc).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2022, 11, 23, 17, 28, 25, 44, DateTimeKind.Utc).AddTicks(1383), new DateTime(2022, 11, 23, 17, 28, 25, 44, DateTimeKind.Utc).AddTicks(1386) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 28, 25, 44, DateTimeKind.Utc).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 28, 25, 44, DateTimeKind.Utc).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 28, 25, 43, DateTimeKind.Utc).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 28, 25, 43, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 28, 25, 43, DateTimeKind.Utc).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 28, 25, 43, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 28, 25, 43, DateTimeKind.Utc).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                columns: new[] { "CreatedOnUtc", "ImportTemplateId" },
                values: new object[] { new DateTime(2022, 11, 23, 17, 28, 25, 43, DateTimeKind.Utc).AddTicks(7733), new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962") });

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 28, 25, 44, DateTimeKind.Utc).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 28, 25, 44, DateTimeKind.Utc).AddTicks(7204));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(2735), new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                columns: new[] { "CreatedOnUtc", "ImportTemplateId" },
                values: new object[] { new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(236), null });

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(6592));
        }
    }
}
