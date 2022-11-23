using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tuber.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedImportTemplateSeedingForCoOpAndLloyds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountNumberColumnNumber",
                table: "ImportTemplates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BalanceOnStatementColumnNumber",
                table: "ImportTemplates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DateColumnNumber",
                table: "ImportTemplates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DescriptionOnStatementColumnNumber",
                table: "ImportTemplates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HeaderRowCount",
                table: "ImportTemplates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImportFileName",
                table: "ImportTemplates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MoneyInColumnNumber",
                table: "ImportTemplates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MoneyOutColumnNumber",
                table: "ImportTemplates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SortCodeColumnNumber",
                table: "ImportTemplates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransactionTypeColumnNumber",
                table: "ImportTemplates",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 45, 23, 250, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 45, 23, 250, DateTimeKind.Utc).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 45, 23, 250, DateTimeKind.Utc).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2022, 11, 23, 17, 45, 23, 250, DateTimeKind.Utc).AddTicks(5921), new DateTime(2022, 11, 23, 17, 45, 23, 250, DateTimeKind.Utc).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 45, 23, 250, DateTimeKind.Utc).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 45, 23, 250, DateTimeKind.Utc).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 45, 23, 250, DateTimeKind.Utc).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 45, 23, 250, DateTimeKind.Utc).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 45, 23, 250, DateTimeKind.Utc).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 45, 23, 250, DateTimeKind.Utc).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 45, 23, 250, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 45, 23, 250, DateTimeKind.Utc).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                columns: new[] { "AccountNumberColumnNumber", "BalanceOnStatementColumnNumber", "CreatedOnUtc", "DateColumnNumber", "DescriptionOnStatementColumnNumber", "HeaderRowCount", "ImportFileName", "MoneyInColumnNumber", "MoneyOutColumnNumber", "SortCodeColumnNumber", "TransactionTypeColumnNumber" },
                values: new object[] { null, 6, new DateTime(2022, 11, 23, 17, 45, 23, 251, DateTimeKind.Utc).AddTicks(662), 1, 2, 1, "", 4, 5, null, 3 });

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                columns: new[] { "AccountNumberColumnNumber", "BalanceOnStatementColumnNumber", "CreatedOnUtc", "DateColumnNumber", "DescriptionOnStatementColumnNumber", "HeaderRowCount", "ImportFileName", "MoneyInColumnNumber", "MoneyOutColumnNumber", "SortCodeColumnNumber", "TransactionTypeColumnNumber" },
                values: new object[] { 4, 8, new DateTime(2022, 11, 23, 17, 45, 23, 251, DateTimeKind.Utc).AddTicks(667), 1, 5, 1, "", 7, 6, 3, 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountNumberColumnNumber",
                table: "ImportTemplates");

            migrationBuilder.DropColumn(
                name: "BalanceOnStatementColumnNumber",
                table: "ImportTemplates");

            migrationBuilder.DropColumn(
                name: "DateColumnNumber",
                table: "ImportTemplates");

            migrationBuilder.DropColumn(
                name: "DescriptionOnStatementColumnNumber",
                table: "ImportTemplates");

            migrationBuilder.DropColumn(
                name: "HeaderRowCount",
                table: "ImportTemplates");

            migrationBuilder.DropColumn(
                name: "ImportFileName",
                table: "ImportTemplates");

            migrationBuilder.DropColumn(
                name: "MoneyInColumnNumber",
                table: "ImportTemplates");

            migrationBuilder.DropColumn(
                name: "MoneyOutColumnNumber",
                table: "ImportTemplates");

            migrationBuilder.DropColumn(
                name: "SortCodeColumnNumber",
                table: "ImportTemplates");

            migrationBuilder.DropColumn(
                name: "TransactionTypeColumnNumber",
                table: "ImportTemplates");

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
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 28, 25, 43, DateTimeKind.Utc).AddTicks(7733));

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
    }
}
