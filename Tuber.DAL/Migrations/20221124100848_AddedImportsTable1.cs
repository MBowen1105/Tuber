﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tuber.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedImportsTable1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Imports",
                columns: table => new
                {
                    ImportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BankAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImportRowNumber = table.Column<int>(type: "int", nullable: false),
                    DateValue = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DescriptionOnStatementValue = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    TransactionTypeValue = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MoneyInValue = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MoneyOutValue = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    BalanceOnStatementValue = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SortCodeValue = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AccountNumberValue = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ImportRowStatus = table.Column<int>(type: "int", nullable: false),
                    ValidationFailureMessages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImportedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImportedUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imports", x => x.ImportId);
                });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 8, 48, 317, DateTimeKind.Utc).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 8, 48, 317, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 8, 48, 317, DateTimeKind.Utc).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2022, 11, 24, 10, 8, 48, 317, DateTimeKind.Utc).AddTicks(1249), new DateTime(2022, 11, 24, 10, 8, 48, 317, DateTimeKind.Utc).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 8, 48, 317, DateTimeKind.Utc).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 8, 48, 317, DateTimeKind.Utc).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 8, 48, 316, DateTimeKind.Utc).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 8, 48, 316, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 8, 48, 316, DateTimeKind.Utc).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 8, 48, 316, DateTimeKind.Utc).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 8, 48, 316, DateTimeKind.Utc).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 8, 48, 316, DateTimeKind.Utc).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 8, 48, 317, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 8, 48, 317, DateTimeKind.Utc).AddTicks(3413));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imports");

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 4, 3, 647, DateTimeKind.Utc).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 4, 3, 647, DateTimeKind.Utc).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 4, 3, 647, DateTimeKind.Utc).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2022, 11, 24, 10, 4, 3, 647, DateTimeKind.Utc).AddTicks(8518), new DateTime(2022, 11, 24, 10, 4, 3, 647, DateTimeKind.Utc).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 4, 3, 647, DateTimeKind.Utc).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 4, 3, 647, DateTimeKind.Utc).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 4, 3, 647, DateTimeKind.Utc).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 4, 3, 647, DateTimeKind.Utc).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 4, 3, 647, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 4, 3, 647, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 4, 3, 647, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 4, 3, 647, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 4, 3, 648, DateTimeKind.Utc).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 24, 10, 4, 3, 648, DateTimeKind.Utc).AddTicks(3688));
        }
    }
}
