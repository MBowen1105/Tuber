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
                    { new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(255), null, true, "TSB", 50, null, null },
                    { new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(247), null, false, "Barclays Bank", 30, null, null },
                    { new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(253), null, false, "West Bromwich Building Society", 50, null, null },
                    { new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(243), null, false, "Lloyds Bank", 20, null, null },
                    { new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(250), null, false, "Virgin", 40, null, null },
                    { new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(236), null, false, "Co-Op Bank", 10, null, null }
                });

            migrationBuilder.InsertData(
                table: "ImportTemplates",
                columns: new[] { "ImportTemplateId", "CreatedByUserId", "CreatedOnUtc", "IsDeleted", "TemplateName", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(6587), false, "Co-Op Bank Template", null, null },
                    { new Guid("f642096e-6573-4deb-96be-efba9016499c"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(6592), false, "Lloyds Bank Template", null, null }
                });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "BankAccountId", "BankId", "CreatedByUserId", "CreatedOnUtc", "IsDeleted", "Name", "OrderBy", "UKBankAccount", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(2717), false, "Salary", 10, "09411905", null, null },
                    { new Guid("552d16a1-d98b-48e9-8580-13029843c116"), new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(2723), false, "Cash", 20, "00985630", null, null },
                    { new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"), new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(2729), false, "Lloyds 93DIX", 10, "09405515", null, null },
                    { new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"), new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(2735), true, "TSB Bank Account", 10, "98765555", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(2737) },
                    { new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"), new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(2732), false, "Lloyds 25PAR", 20, "09405515", null, null },
                    { new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"), new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 23, 17, 20, 55, 351, DateTimeKind.Utc).AddTicks(2727), false, "Savings", 30, "09405515", null, null }
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
                name: "ImportTemplates");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
