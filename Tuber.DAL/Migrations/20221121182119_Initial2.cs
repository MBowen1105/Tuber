using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tuber.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedByUserName",
                table: "Banks");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserName",
                table: "BankAccounts");

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedByUserId",
                table: "Banks",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedByUserId",
                table: "BankAccounts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                columns: new[] { "CreatedOnUtc", "UpdatedByUserId" },
                values: new object[] { new DateTime(2022, 11, 21, 18, 21, 19, 72, DateTimeKind.Utc).AddTicks(9508), null });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                columns: new[] { "CreatedOnUtc", "UpdatedByUserId" },
                values: new object[] { new DateTime(2022, 11, 21, 18, 21, 19, 72, DateTimeKind.Utc).AddTicks(9516), null });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                columns: new[] { "CreatedOnUtc", "UpdatedByUserId" },
                values: new object[] { new DateTime(2022, 11, 21, 18, 21, 19, 72, DateTimeKind.Utc).AddTicks(9524), null });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2022, 11, 21, 18, 21, 19, 72, DateTimeKind.Utc).AddTicks(9532), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 21, 18, 21, 19, 72, DateTimeKind.Utc).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                columns: new[] { "CreatedOnUtc", "UpdatedByUserId" },
                values: new object[] { new DateTime(2022, 11, 21, 18, 21, 19, 72, DateTimeKind.Utc).AddTicks(9529), null });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                columns: new[] { "CreatedOnUtc", "UpdatedByUserId" },
                values: new object[] { new DateTime(2022, 11, 21, 18, 21, 19, 72, DateTimeKind.Utc).AddTicks(9520), null });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                columns: new[] { "CreatedOnUtc", "UpdatedByUserId" },
                values: new object[] { new DateTime(2022, 11, 21, 18, 21, 19, 72, DateTimeKind.Utc).AddTicks(6843), null });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                columns: new[] { "CreatedOnUtc", "UpdatedByUserId" },
                values: new object[] { new DateTime(2022, 11, 21, 18, 21, 19, 72, DateTimeKind.Utc).AddTicks(6835), null });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                columns: new[] { "CreatedOnUtc", "UpdatedByUserId" },
                values: new object[] { new DateTime(2022, 11, 21, 18, 21, 19, 72, DateTimeKind.Utc).AddTicks(6774), null });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                columns: new[] { "CreatedOnUtc", "UpdatedByUserId" },
                values: new object[] { new DateTime(2022, 11, 21, 18, 21, 19, 72, DateTimeKind.Utc).AddTicks(6840), null });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                columns: new[] { "CreatedOnUtc", "UpdatedByUserId" },
                values: new object[] { new DateTime(2022, 11, 21, 18, 21, 19, 72, DateTimeKind.Utc).AddTicks(6765), null });

            migrationBuilder.CreateIndex(
                name: "IX_Banks_UpdatedByUserId",
                table: "Banks",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_UpdatedByUserId",
                table: "BankAccounts",
                column: "UpdatedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BankAccounts_Users_UpdatedByUserId",
                table: "BankAccounts",
                column: "UpdatedByUserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Banks_Users_UpdatedByUserId",
                table: "Banks",
                column: "UpdatedByUserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankAccounts_Users_UpdatedByUserId",
                table: "BankAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Banks_Users_UpdatedByUserId",
                table: "Banks");

            migrationBuilder.DropIndex(
                name: "IX_Banks_UpdatedByUserId",
                table: "Banks");

            migrationBuilder.DropIndex(
                name: "IX_BankAccounts_UpdatedByUserId",
                table: "BankAccounts");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Banks");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "BankAccounts");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserName",
                table: "Banks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserName",
                table: "BankAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                columns: new[] { "CreatedOnUtc", "UpdatedByUserName" },
                values: new object[] { new DateTime(2022, 11, 21, 18, 8, 25, 545, DateTimeKind.Utc).AddTicks(8770), null });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                columns: new[] { "CreatedOnUtc", "UpdatedByUserName" },
                values: new object[] { new DateTime(2022, 11, 21, 18, 8, 25, 545, DateTimeKind.Utc).AddTicks(8775), null });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                columns: new[] { "CreatedOnUtc", "UpdatedByUserName" },
                values: new object[] { new DateTime(2022, 11, 21, 18, 8, 25, 545, DateTimeKind.Utc).AddTicks(8782), null });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedByUserName", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2022, 11, 21, 18, 8, 25, 545, DateTimeKind.Utc).AddTicks(8788), "Mark Bowen", new DateTime(2022, 11, 21, 18, 8, 25, 545, DateTimeKind.Utc).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                columns: new[] { "CreatedOnUtc", "UpdatedByUserName" },
                values: new object[] { new DateTime(2022, 11, 21, 18, 8, 25, 545, DateTimeKind.Utc).AddTicks(8785), null });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                columns: new[] { "CreatedOnUtc", "UpdatedByUserName" },
                values: new object[] { new DateTime(2022, 11, 21, 18, 8, 25, 545, DateTimeKind.Utc).AddTicks(8779), null });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                columns: new[] { "CreatedOnUtc", "UpdatedByUserName" },
                values: new object[] { new DateTime(2022, 11, 21, 18, 8, 25, 545, DateTimeKind.Utc).AddTicks(6639), null });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                columns: new[] { "CreatedOnUtc", "UpdatedByUserName" },
                values: new object[] { new DateTime(2022, 11, 21, 18, 8, 25, 545, DateTimeKind.Utc).AddTicks(6635), null });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                columns: new[] { "CreatedOnUtc", "UpdatedByUserName" },
                values: new object[] { new DateTime(2022, 11, 21, 18, 8, 25, 545, DateTimeKind.Utc).AddTicks(6633), null });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                columns: new[] { "CreatedOnUtc", "UpdatedByUserName" },
                values: new object[] { new DateTime(2022, 11, 21, 18, 8, 25, 545, DateTimeKind.Utc).AddTicks(6637), null });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                columns: new[] { "CreatedOnUtc", "UpdatedByUserName" },
                values: new object[] { new DateTime(2022, 11, 21, 18, 8, 25, 545, DateTimeKind.Utc).AddTicks(6625), null });
        }
    }
}
