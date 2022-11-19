using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tuber.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    OrderBy = table.Column<int>(type: "int", nullable: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    UKBankAccount = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    OrderBy = table.Column<int>(type: "int", nullable: false),
                    BankId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankAccounts_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "CreatedByUserId", "CreatedOn", "IsArchived", "Name", "OrderBy", "UpdatedByUserId", "UpdatedOn" },
                values: new object[] { new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 19, 12, 15, 41, 991, DateTimeKind.Utc).AddTicks(9858), true, "TSB", 50, null, null });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "CreatedByUserId", "CreatedOn", "Name", "OrderBy", "UpdatedByUserId", "UpdatedOn" },
                values: new object[,]
                {
                    { new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 19, 12, 15, 41, 991, DateTimeKind.Utc).AddTicks(9855), "Barclays Bank", 30, null, null },
                    { new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 19, 12, 15, 41, 991, DateTimeKind.Utc).AddTicks(9852), "Lloyds Bank", 20, null, null },
                    { new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 19, 12, 15, 41, 991, DateTimeKind.Utc).AddTicks(9857), "Virgin Money", 40, null, null },
                    { new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 19, 12, 15, 41, 991, DateTimeKind.Utc).AddTicks(9845), "Co-Op Bank", 10, null, null }
                });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "BankId", "CreatedByUserId", "CreatedOn", "Name", "OrderBy", "UKBankAccount", "UpdatedByUserId", "UpdatedOn" },
                values: new object[,]
                {
                    { new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 19, 12, 15, 41, 992, DateTimeKind.Utc).AddTicks(2383), "Salary", 10, "09411905", null, null },
                    { new Guid("552d16a1-d98b-48e9-8580-13029843c116"), new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 19, 12, 15, 41, 992, DateTimeKind.Utc).AddTicks(2390), "Cash", 20, "00985630", null, null },
                    { new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"), new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 19, 12, 15, 41, 992, DateTimeKind.Utc).AddTicks(2397), "Lloyds 93DIX", 10, "09405515", null, null },
                    { new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"), new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 19, 12, 15, 41, 992, DateTimeKind.Utc).AddTicks(2399), "Lloyds 25PAR", 20, "09405515", null, null },
                    { new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"), new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 19, 12, 15, 41, 992, DateTimeKind.Utc).AddTicks(2393), "Savings", 30, "09405515", null, null }
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
                name: "Banks");
        }
    }
}
