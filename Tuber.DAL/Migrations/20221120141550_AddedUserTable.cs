using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tuber.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 15, 50, 250, DateTimeKind.Utc).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 15, 50, 250, DateTimeKind.Utc).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 15, 50, 250, DateTimeKind.Utc).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 15, 50, 250, DateTimeKind.Utc).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 15, 50, 250, DateTimeKind.Utc).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 15, 50, 250, DateTimeKind.Utc).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 15, 50, 250, DateTimeKind.Utc).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 15, 50, 250, DateTimeKind.Utc).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 15, 50, 250, DateTimeKind.Utc).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 20, 14, 15, 50, 250, DateTimeKind.Utc).AddTicks(578));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedByUserId", "CreatedOn", "FullName", "UpdatedByUserId", "UpdatedOn" },
                values: new object[] { new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 20, 14, 15, 50, 250, DateTimeKind.Utc).AddTicks(3296), "Mark Bowen", null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 12, 15, 41, 992, DateTimeKind.Utc).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 12, 15, 41, 992, DateTimeKind.Utc).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 12, 15, 41, 992, DateTimeKind.Utc).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 12, 15, 41, 992, DateTimeKind.Utc).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 12, 15, 41, 992, DateTimeKind.Utc).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 12, 15, 41, 991, DateTimeKind.Utc).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 12, 15, 41, 991, DateTimeKind.Utc).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 12, 15, 41, 991, DateTimeKind.Utc).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 12, 15, 41, 991, DateTimeKind.Utc).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 19, 12, 15, 41, 991, DateTimeKind.Utc).AddTicks(9845));
        }
    }
}
