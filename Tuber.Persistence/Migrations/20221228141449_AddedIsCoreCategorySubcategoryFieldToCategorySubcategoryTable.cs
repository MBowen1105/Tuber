﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tuber.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedIsCoreCategorySubcategoryFieldToCategorySubcategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCoreCategorySubcategory",
                table: "CategorySubcategories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 14, 14, 48, 641, DateTimeKind.Utc).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 14, 14, 48, 641, DateTimeKind.Utc).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 14, 14, 48, 641, DateTimeKind.Utc).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2022, 12, 28, 14, 14, 48, 641, DateTimeKind.Utc).AddTicks(1356), new DateTime(2022, 12, 28, 14, 14, 48, 641, DateTimeKind.Utc).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 14, 14, 48, 641, DateTimeKind.Utc).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 14, 14, 48, 641, DateTimeKind.Utc).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 14, 14, 48, 640, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 14, 14, 48, 640, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 14, 14, 48, 640, DateTimeKind.Utc).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 14, 14, 48, 640, DateTimeKind.Utc).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 14, 14, 48, 640, DateTimeKind.Utc).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 14, 14, 48, 640, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 14, 14, 48, 641, DateTimeKind.Utc).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3eefa969-31e0-46d3-9d81-d514035dd3de"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 14, 14, 48, 641, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 14, 14, 48, 641, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 14, 14, 48, 641, DateTimeKind.Utc).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "CategorySubcategories",
                keyColumn: "CategorySubcategoryId",
                keyValue: new Guid("e79d158e-dd3c-4b13-86da-e0b8f9109ff7"),
                column: "IsCoreCategorySubcategory",
                value: false);

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 14, 14, 48, 641, DateTimeKind.Utc).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 14, 14, 48, 641, DateTimeKind.Utc).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("cac01b14-67a7-4372-8eb1-5e9a0e8a007c"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 14, 14, 48, 641, DateTimeKind.Utc).AddTicks(7813));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCoreCategorySubcategory",
                table: "CategorySubcategories");

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 13, 51, 31, 102, DateTimeKind.Utc).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 13, 51, 31, 102, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 13, 51, 31, 102, DateTimeKind.Utc).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2022, 12, 28, 13, 51, 31, 102, DateTimeKind.Utc).AddTicks(8536), new DateTime(2022, 12, 28, 13, 51, 31, 102, DateTimeKind.Utc).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 13, 51, 31, 102, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 13, 51, 31, 102, DateTimeKind.Utc).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 13, 51, 31, 102, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 13, 51, 31, 102, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 13, 51, 31, 102, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 13, 51, 31, 102, DateTimeKind.Utc).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 13, 51, 31, 102, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 13, 51, 31, 102, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 13, 51, 31, 103, DateTimeKind.Utc).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3eefa969-31e0-46d3-9d81-d514035dd3de"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 13, 51, 31, 103, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 13, 51, 31, 103, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 13, 51, 31, 103, DateTimeKind.Utc).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 13, 51, 31, 103, DateTimeKind.Utc).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 13, 51, 31, 103, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("cac01b14-67a7-4372-8eb1-5e9a0e8a007c"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 13, 51, 31, 103, DateTimeKind.Utc).AddTicks(3923));
        }
    }
}
