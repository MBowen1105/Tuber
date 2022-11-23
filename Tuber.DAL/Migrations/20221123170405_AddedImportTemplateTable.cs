using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tuber.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedImportTemplateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ImportTemplateId",
                table: "Banks",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ImportTemplates",
                columns: table => new
                {
                    ImportTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TemplateName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
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

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 4, 4, 807, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 4, 4, 807, DateTimeKind.Utc).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 4, 4, 807, DateTimeKind.Utc).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2022, 11, 23, 17, 4, 4, 807, DateTimeKind.Utc).AddTicks(4062), new DateTime(2022, 11, 23, 17, 4, 4, 807, DateTimeKind.Utc).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 4, 4, 807, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 23, 17, 4, 4, 807, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                columns: new[] { "CreatedOnUtc", "ImportTemplateId" },
                values: new object[] { new DateTime(2022, 11, 23, 17, 4, 4, 807, DateTimeKind.Utc).AddTicks(1694), null });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                columns: new[] { "CreatedOnUtc", "ImportTemplateId" },
                values: new object[] { new DateTime(2022, 11, 23, 17, 4, 4, 807, DateTimeKind.Utc).AddTicks(1689), null });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                columns: new[] { "CreatedOnUtc", "ImportTemplateId" },
                values: new object[] { new DateTime(2022, 11, 23, 17, 4, 4, 807, DateTimeKind.Utc).AddTicks(1687), null });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                columns: new[] { "CreatedOnUtc", "ImportTemplateId", "Name" },
                values: new object[] { new DateTime(2022, 11, 23, 17, 4, 4, 807, DateTimeKind.Utc).AddTicks(1691), null, "Virgin" });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                columns: new[] { "CreatedOnUtc", "ImportTemplateId" },
                values: new object[] { new DateTime(2022, 11, 23, 17, 4, 4, 807, DateTimeKind.Utc).AddTicks(1679), null });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "BankId", "CreatedByUserId", "CreatedOnUtc", "ImportTemplateId", "Name", "OrderBy", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[] { new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 23, 17, 4, 4, 807, DateTimeKind.Utc).AddTicks(1692), null, "West Bromwich Building Society", 50, null, null });

            migrationBuilder.InsertData(
                table: "ImportTemplates",
                columns: new[] { "ImportTemplateId", "CreatedByUserId", "CreatedOnUtc", "IsActive", "TemplateName", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 23, 17, 4, 4, 807, DateTimeKind.Utc).AddTicks(6187), true, "Co-Op Bank Template", null, null },
                    { new Guid("f642096e-6573-4deb-96be-efba9016499c"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2022, 11, 23, 17, 4, 4, 807, DateTimeKind.Utc).AddTicks(6190), true, "Lloyds Bank Template", null, null }
                });

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
                name: "ImportTemplates");

            migrationBuilder.DeleteData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"));

            migrationBuilder.DropColumn(
                name: "ImportTemplateId",
                table: "Banks");

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 22, 14, 27, 31, 82, DateTimeKind.Utc).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 22, 14, 27, 31, 82, DateTimeKind.Utc).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 22, 14, 27, 31, 82, DateTimeKind.Utc).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2022, 11, 22, 14, 27, 31, 82, DateTimeKind.Utc).AddTicks(9180), new DateTime(2022, 11, 22, 14, 27, 31, 82, DateTimeKind.Utc).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 22, 14, 27, 31, 82, DateTimeKind.Utc).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 22, 14, 27, 31, 82, DateTimeKind.Utc).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 22, 14, 27, 31, 82, DateTimeKind.Utc).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 22, 14, 27, 31, 82, DateTimeKind.Utc).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 22, 14, 27, 31, 82, DateTimeKind.Utc).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                columns: new[] { "CreatedOnUtc", "Name" },
                values: new object[] { new DateTime(2022, 11, 22, 14, 27, 31, 82, DateTimeKind.Utc).AddTicks(7877), "Virgin Money" });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 22, 14, 27, 31, 82, DateTimeKind.Utc).AddTicks(7867));
        }
    }
}
