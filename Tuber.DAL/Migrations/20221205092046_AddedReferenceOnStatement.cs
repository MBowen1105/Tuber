using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tuber.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedReferenceOnStatement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReferenceOnStatementStartCharacter",
                table: "ImportTemplates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ReferenceOnStatement",
                table: "Imports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 5, 9, 20, 46, 407, DateTimeKind.Utc).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 5, 9, 20, 46, 407, DateTimeKind.Utc).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 5, 9, 20, 46, 407, DateTimeKind.Utc).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2022, 12, 5, 9, 20, 46, 407, DateTimeKind.Utc).AddTicks(3328), new DateTime(2022, 12, 5, 9, 20, 46, 407, DateTimeKind.Utc).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 5, 9, 20, 46, 407, DateTimeKind.Utc).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 5, 9, 20, 46, 407, DateTimeKind.Utc).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 5, 9, 20, 46, 407, DateTimeKind.Utc).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 5, 9, 20, 46, 407, DateTimeKind.Utc).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 5, 9, 20, 46, 407, DateTimeKind.Utc).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 5, 9, 20, 46, 407, DateTimeKind.Utc).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 5, 9, 20, 46, 407, DateTimeKind.Utc).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 5, 9, 20, 46, 407, DateTimeKind.Utc).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                columns: new[] { "CreatedOnUtc", "ReferenceOnStatementStartCharacter" },
                values: new object[] { new DateTime(2022, 12, 5, 9, 20, 46, 407, DateTimeKind.Utc).AddTicks(6470), 14 });

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                columns: new[] { "CreatedOnUtc", "ReferenceOnStatementStartCharacter" },
                values: new object[] { new DateTime(2022, 12, 5, 9, 20, 46, 407, DateTimeKind.Utc).AddTicks(6474), 14 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReferenceOnStatementStartCharacter",
                table: "ImportTemplates");

            migrationBuilder.DropColumn(
                name: "ReferenceOnStatement",
                table: "Imports");

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 2, 11, 3, 13, 277, DateTimeKind.Utc).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 2, 11, 3, 13, 277, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 2, 11, 3, 13, 277, DateTimeKind.Utc).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2022, 12, 2, 11, 3, 13, 277, DateTimeKind.Utc).AddTicks(3851), new DateTime(2022, 12, 2, 11, 3, 13, 277, DateTimeKind.Utc).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 2, 11, 3, 13, 277, DateTimeKind.Utc).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 2, 11, 3, 13, 277, DateTimeKind.Utc).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 2, 11, 3, 13, 277, DateTimeKind.Utc).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 2, 11, 3, 13, 277, DateTimeKind.Utc).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 2, 11, 3, 13, 277, DateTimeKind.Utc).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 2, 11, 3, 13, 277, DateTimeKind.Utc).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 2, 11, 3, 13, 277, DateTimeKind.Utc).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 2, 11, 3, 13, 277, DateTimeKind.Utc).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 2, 11, 3, 13, 277, DateTimeKind.Utc).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 2, 11, 3, 13, 277, DateTimeKind.Utc).AddTicks(8152));
        }
    }
}
