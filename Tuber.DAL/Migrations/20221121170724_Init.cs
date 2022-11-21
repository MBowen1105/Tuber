using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tuber.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    BankId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    OrderBy = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.BankId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsCoreUser = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    BankAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    UKBankAccount = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    OrderBy = table.Column<int>(type: "int", nullable: false),
                    BankId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.BankAccountId);
                    table.ForeignKey(
                        name: "FK_BankAccounts_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "BankId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "BankId", "CreatedByUserName", "CreatedOnUtc", "Name", "OrderBy", "UpdatedByUserName", "UpdatedOnUtc" },
                values: new object[] { new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"), "Mark Bowen", new DateTime(2022, 11, 21, 17, 7, 24, 584, DateTimeKind.Utc).AddTicks(6227), "TSB", 50, null, null });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "BankId", "CreatedByUserName", "CreatedOnUtc", "IsActive", "Name", "OrderBy", "UpdatedByUserName", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"), "Mark Bowen", new DateTime(2022, 11, 21, 17, 7, 24, 584, DateTimeKind.Utc).AddTicks(6224), true, "Barclays Bank", 30, null, null },
                    { new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"), "Mark Bowen", new DateTime(2022, 11, 21, 17, 7, 24, 584, DateTimeKind.Utc).AddTicks(6222), true, "Lloyds Bank", 20, null, null }
                });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "BankId", "CreatedByUserName", "CreatedOnUtc", "Name", "OrderBy", "UpdatedByUserName", "UpdatedOnUtc" },
                values: new object[] { new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"), "Mark Bowen", new DateTime(2022, 11, 21, 17, 7, 24, 584, DateTimeKind.Utc).AddTicks(6225), "Virgin Money", 40, null, null });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "BankId", "CreatedByUserName", "CreatedOnUtc", "IsActive", "Name", "OrderBy", "UpdatedByUserName", "UpdatedOnUtc" },
                values: new object[] { new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), "Mark Bowen", new DateTime(2022, 11, 21, 17, 7, 24, 584, DateTimeKind.Utc).AddTicks(6216), true, "Co-Op Bank", 10, null, null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedByUserName", "CreatedOnUtc", "FullName", "IsActive", "IsCoreUser", "UpdatedByUserName", "UpdatedOnUtc" },
                values: new object[] { new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark Bowen", true, true, null, null });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "BankAccountId", "BankId", "CreatedByUserName", "CreatedOnUtc", "IsActive", "Name", "OrderBy", "UKBankAccount", "UpdatedByUserName", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), "Mark Bowen", new DateTime(2022, 11, 21, 17, 7, 24, 584, DateTimeKind.Utc).AddTicks(7532), true, "Salary", 10, "09411905", null, null },
                    { new Guid("552d16a1-d98b-48e9-8580-13029843c116"), new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), "Mark Bowen", new DateTime(2022, 11, 21, 17, 7, 24, 584, DateTimeKind.Utc).AddTicks(7537), true, "Cash", 20, "00985630", null, null },
                    { new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"), new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"), "Mark Bowen", new DateTime(2022, 11, 21, 17, 7, 24, 584, DateTimeKind.Utc).AddTicks(7541), true, "Lloyds 93DIX", 10, "09405515", null, null }
                });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "BankAccountId", "BankId", "CreatedByUserName", "CreatedOnUtc", "Name", "OrderBy", "UKBankAccount", "UpdatedByUserName", "UpdatedOnUtc" },
                values: new object[] { new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"), new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"), "Mark Bowen", new DateTime(2022, 11, 21, 17, 7, 24, 584, DateTimeKind.Utc).AddTicks(7545), "HSBC Bank", 10, "98765555", "Mark Bowen", new DateTime(2022, 11, 21, 17, 7, 24, 584, DateTimeKind.Utc).AddTicks(7546) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "BankAccountId", "BankId", "CreatedByUserName", "CreatedOnUtc", "IsActive", "Name", "OrderBy", "UKBankAccount", "UpdatedByUserName", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"), new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"), "Mark Bowen", new DateTime(2022, 11, 21, 17, 7, 24, 584, DateTimeKind.Utc).AddTicks(7543), true, "Lloyds 25PAR", 20, "09405515", null, null },
                    { new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"), new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), "Mark Bowen", new DateTime(2022, 11, 21, 17, 7, 24, 584, DateTimeKind.Utc).AddTicks(7539), true, "Savings", 30, "09405515", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_BankId",
                table: "BankAccounts",
                column: "BankId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankAccounts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Banks");
        }
    }
}
