﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tuber.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedCreatedByUserToImportTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(9708), new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                columns: new[] { "CreatedOnUtc", "ExpectedColumnCount" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 50, 18, 416, DateTimeKind.Utc).AddTicks(5910), 6 });

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                columns: new[] { "CreatedOnUtc", "ExpectedColumnCount" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 50, 18, 416, DateTimeKind.Utc).AddTicks(5925), 8 });

            migrationBuilder.CreateIndex(
                name: "IX_Imports_ImportedByUserId",
                table: "Imports",
                column: "ImportedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imports_Users_ImportedByUserId",
                table: "Imports",
                column: "ImportedByUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imports_Users_ImportedByUserId",
                table: "Imports");

            migrationBuilder.DropIndex(
                name: "IX_Imports_ImportedByUserId",
                table: "Imports");

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 28, 19, 39, 4, 424, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 28, 19, 39, 4, 424, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 28, 19, 39, 4, 424, DateTimeKind.Utc).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 39, 4, 424, DateTimeKind.Utc).AddTicks(4121), new DateTime(2022, 11, 28, 19, 39, 4, 424, DateTimeKind.Utc).AddTicks(4122) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 28, 19, 39, 4, 424, DateTimeKind.Utc).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 28, 19, 39, 4, 424, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 28, 19, 39, 4, 424, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 28, 19, 39, 4, 424, DateTimeKind.Utc).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 28, 19, 39, 4, 424, DateTimeKind.Utc).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 28, 19, 39, 4, 424, DateTimeKind.Utc).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 28, 19, 39, 4, 424, DateTimeKind.Utc).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 28, 19, 39, 4, 424, DateTimeKind.Utc).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                columns: new[] { "CreatedOnUtc", "ExpectedColumnCount" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 39, 4, 424, DateTimeKind.Utc).AddTicks(7006), 0 });

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                columns: new[] { "CreatedOnUtc", "ExpectedColumnCount" },
                values: new object[] { new DateTime(2022, 11, 28, 19, 39, 4, 424, DateTimeKind.Utc).AddTicks(7011), 0 });
        }
    }
}