using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tuber.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
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

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsCoreUser = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    BankId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    OrderBy = table.Column<int>(type: "int", nullable: false),
                    ImportTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.BankId);
                    table.ForeignKey(
                        name: "FK_Banks_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Banks_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ImportTemplates",
                columns: table => new
                {
                    ImportTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TemplateName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ImportFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpectedHeaderRowCount = table.Column<int>(type: "int", nullable: false),
                    ExpectedColumnCount = table.Column<int>(type: "int", nullable: false),
                    SeperatorChar = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    DateColumnNumber = table.Column<int>(type: "int", nullable: false),
                    DescriptionOnStatementColumnNumber = table.Column<int>(type: "int", nullable: false),
                    TransactionTypeColumnNumber = table.Column<int>(type: "int", nullable: false),
                    MoneyInColumnNumber = table.Column<int>(type: "int", nullable: false),
                    MoneyOutColumnNumber = table.Column<int>(type: "int", nullable: false),
                    BalanceOnStatementColumnNumber = table.Column<int>(type: "int", nullable: false),
                    SortCodeColumnNumber = table.Column<int>(type: "int", nullable: false),
                    AccountNumberColumnNumber = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportTemplates", x => x.ImportTemplateId);
                    table.ForeignKey(
                        name: "FK_ImportTemplates_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImportTemplates_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_BankAccounts_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BankAccounts_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FullName", "IsCoreUser", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), "Administrator", true, false },
                    { new Guid("e13a3a77-93c1-4e64-8d58-a517ca1be8d1"), "Mark Bowen", true, false }
                });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "BankId", "CreatedByUserId", "CreatedOnUtc", "ImportTemplateId", "IsDeleted", "Name", "OrderBy", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 24, 16, 12, 15, 543, DateTimeKind.Utc).AddTicks(900), null, true, "TSB", 50, null, null },
                    { new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 24, 16, 12, 15, 543, DateTimeKind.Utc).AddTicks(890), null, false, "Barclays Bank", 30, null, null },
                    { new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 24, 16, 12, 15, 543, DateTimeKind.Utc).AddTicks(896), null, false, "West Bromwich Building Society", 50, null, null },
                    { new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 24, 16, 12, 15, 543, DateTimeKind.Utc).AddTicks(887), null, false, "Lloyds Bank", 20, null, null },
                    { new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 24, 16, 12, 15, 543, DateTimeKind.Utc).AddTicks(894), null, false, "Virgin", 40, null, null },
                    { new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 24, 16, 12, 15, 543, DateTimeKind.Utc).AddTicks(879), new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"), false, "Co-Op Bank", 10, null, null }
                });

            migrationBuilder.InsertData(
                table: "ImportTemplates",
                columns: new[] { "ImportTemplateId", "AccountNumberColumnNumber", "BalanceOnStatementColumnNumber", "CreatedByUserId", "CreatedOnUtc", "DateColumnNumber", "DescriptionOnStatementColumnNumber", "ExpectedColumnCount", "ExpectedHeaderRowCount", "ImportFileName", "IsDeleted", "MoneyInColumnNumber", "MoneyOutColumnNumber", "SeperatorChar", "SortCodeColumnNumber", "TemplateName", "TransactionTypeColumnNumber", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"), 0, 6, new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 24, 16, 12, 15, 543, DateTimeKind.Utc).AddTicks(8737), 1, 2, 0, 1, "", false, 4, 5, ",", 0, "Co-Op Bank Template", 3, null, null },
                    { new Guid("f642096e-6573-4deb-96be-efba9016499c"), 4, 8, new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 24, 16, 12, 15, 543, DateTimeKind.Utc).AddTicks(8747), 1, 5, 0, 1, "", false, 7, 6, ",", 3, "Lloyds Bank Template", 2, null, null }
                });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "BankAccountId", "BankId", "CreatedByUserId", "CreatedOnUtc", "IsDeleted", "Name", "OrderBy", "UKBankAccount", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 24, 16, 12, 15, 543, DateTimeKind.Utc).AddTicks(3287), false, "Salary", 10, "09411905", null, null },
                    { new Guid("552d16a1-d98b-48e9-8580-13029843c116"), new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 24, 16, 12, 15, 543, DateTimeKind.Utc).AddTicks(3292), false, "Cash", 20, "00985630", null, null },
                    { new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"), new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 24, 16, 12, 15, 543, DateTimeKind.Utc).AddTicks(3301), false, "Lloyds 93DIX", 10, "09405515", null, null },
                    { new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"), new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 24, 16, 12, 15, 543, DateTimeKind.Utc).AddTicks(3369), true, "TSB Bank Account", 10, "98765555", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 24, 16, 12, 15, 543, DateTimeKind.Utc).AddTicks(3370) },
                    { new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"), new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 24, 16, 12, 15, 543, DateTimeKind.Utc).AddTicks(3364), false, "Lloyds 25PAR", 20, "09405515", null, null },
                    { new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"), new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 24, 16, 12, 15, 543, DateTimeKind.Utc).AddTicks(3296), false, "Savings", 30, "09405515", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_BankId",
                table: "BankAccounts",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_CreatedByUserId",
                table: "BankAccounts",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_UpdatedByUserId",
                table: "BankAccounts",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Banks_CreatedByUserId",
                table: "Banks",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Banks_UpdatedByUserId",
                table: "Banks",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ImportTemplates_CreatedByUserId",
                table: "ImportTemplates",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ImportTemplates_UpdatedByUserId",
                table: "ImportTemplates",
                column: "UpdatedByUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankAccounts");

            migrationBuilder.DropTable(
                name: "Imports");

            migrationBuilder.DropTable(
                name: "ImportTemplates");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
