using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tuber.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedUKSortCodeToBankAccountTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UKSortCode",
                table: "BankAccounts",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                columns: new[] { "CreatedOnUtc", "IsDeleted", "UKSortCode" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 10, 47, 440, DateTimeKind.Utc).AddTicks(1489), true, "089191" });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                columns: new[] { "CreatedOnUtc", "IsDeleted", "UKSortCode" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 10, 47, 440, DateTimeKind.Utc).AddTicks(1498), true, "089191" });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                columns: new[] { "CreatedOnUtc", "IsDeleted", "UKSortCode" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 10, 47, 440, DateTimeKind.Utc).AddTicks(1509), true, "901111" });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UKSortCode", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 10, 47, 440, DateTimeKind.Utc).AddTicks(1520), "440191", new DateTime(2022, 12, 1, 15, 10, 47, 440, DateTimeKind.Utc).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                columns: new[] { "CreatedOnUtc", "IsDeleted", "UKSortCode" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 10, 47, 440, DateTimeKind.Utc).AddTicks(1514), true, "901111" });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                columns: new[] { "CreatedOnUtc", "IsDeleted", "UKSortCode" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 10, 47, 440, DateTimeKind.Utc).AddTicks(1504), true, "089191" });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 1, 15, 10, 47, 439, DateTimeKind.Utc).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                columns: new[] { "CreatedOnUtc", "IsDeleted" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 10, 47, 439, DateTimeKind.Utc).AddTicks(8720), true });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                columns: new[] { "CreatedOnUtc", "IsDeleted" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 10, 47, 439, DateTimeKind.Utc).AddTicks(8726), true });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                columns: new[] { "CreatedOnUtc", "IsDeleted" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 10, 47, 439, DateTimeKind.Utc).AddTicks(8718), true });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                columns: new[] { "CreatedOnUtc", "IsDeleted" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 10, 47, 439, DateTimeKind.Utc).AddTicks(8724), true });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                columns: new[] { "CreatedOnUtc", "IsDeleted" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 10, 47, 439, DateTimeKind.Utc).AddTicks(8707), true });

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 1, 15, 10, 47, 440, DateTimeKind.Utc).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 1, 15, 10, 47, 440, DateTimeKind.Utc).AddTicks(5531));

            migrationBuilder.CreateIndex(
                name: "IX_Banks_ImportTemplateId",
                table: "Banks",
                column: "ImportTemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Banks_ImportTemplates_ImportTemplateId",
                table: "Banks",
                column: "ImportTemplateId",
                principalTable: "ImportTemplates",
                principalColumn: "ImportTemplateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Banks_ImportTemplates_ImportTemplateId",
                table: "Banks");

            migrationBuilder.DropIndex(
                name: "IX_Banks_ImportTemplateId",
                table: "Banks");

            migrationBuilder.DropColumn(
                name: "UKSortCode",
                table: "BankAccounts");

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                columns: new[] { "CreatedOnUtc", "IsDeleted" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(9681), false });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                columns: new[] { "CreatedOnUtc", "IsDeleted" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(9687), false });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                columns: new[] { "CreatedOnUtc", "IsDeleted" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(9697), false });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(9708), new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                columns: new[] { "CreatedOnUtc", "IsDeleted" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(9703), false });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                columns: new[] { "CreatedOnUtc", "IsDeleted" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(9692), false });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                columns: new[] { "CreatedOnUtc", "IsDeleted" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(6943), false });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                columns: new[] { "CreatedOnUtc", "IsDeleted" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(6949), false });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                columns: new[] { "CreatedOnUtc", "IsDeleted" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(6939), false });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                columns: new[] { "CreatedOnUtc", "IsDeleted" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(6946), false });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                columns: new[] { "CreatedOnUtc", "IsDeleted" },
                values: new object[] { new DateTime(2022, 11, 29, 12, 50, 18, 415, DateTimeKind.Utc).AddTicks(6931), false });

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 29, 12, 50, 18, 416, DateTimeKind.Utc).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 11, 29, 12, 50, 18, 416, DateTimeKind.Utc).AddTicks(5925));
        }
    }
}
