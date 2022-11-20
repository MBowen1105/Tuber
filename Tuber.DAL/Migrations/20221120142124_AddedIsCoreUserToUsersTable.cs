using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tuber.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedIsCoreUserToUsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCoreUser",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 21, 24, 274, DateTimeKind.Utc).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 21, 24, 274, DateTimeKind.Utc).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 21, 24, 274, DateTimeKind.Utc).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 21, 24, 274, DateTimeKind.Utc).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 21, 24, 274, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 21, 24, 274, DateTimeKind.Utc).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 21, 24, 274, DateTimeKind.Utc).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 21, 24, 274, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 21, 24, 274, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 21, 24, 274, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                columns: new[] { "CreatedOn", "IsCoreUser" },
                values: new object[] { new DateTime(2022, 11, 20, 14, 21, 24, 274, DateTimeKind.Utc).AddTicks(8671), true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCoreUser",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 18, 33, 898, DateTimeKind.Utc).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 18, 33, 898, DateTimeKind.Utc).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 18, 33, 898, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 18, 33, 898, DateTimeKind.Utc).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 18, 33, 898, DateTimeKind.Utc).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 18, 33, 898, DateTimeKind.Utc).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 18, 33, 898, DateTimeKind.Utc).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 18, 33, 898, DateTimeKind.Utc).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 18, 33, 898, DateTimeKind.Utc).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 18, 33, 898, DateTimeKind.Utc).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 18, 33, 898, DateTimeKind.Utc).AddTicks(8107));
        }
    }
}
