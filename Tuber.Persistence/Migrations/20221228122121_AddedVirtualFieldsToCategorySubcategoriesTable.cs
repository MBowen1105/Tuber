using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tuber.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedVirtualFieldsToCategorySubcategoriesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 12, 21, 21, 462, DateTimeKind.Utc).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 12, 21, 21, 462, DateTimeKind.Utc).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 12, 21, 21, 462, DateTimeKind.Utc).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2022, 12, 28, 12, 21, 21, 462, DateTimeKind.Utc).AddTicks(4743), new DateTime(2022, 12, 28, 12, 21, 21, 462, DateTimeKind.Utc).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 12, 21, 21, 462, DateTimeKind.Utc).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 12, 21, 21, 462, DateTimeKind.Utc).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 12, 21, 21, 462, DateTimeKind.Utc).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 12, 21, 21, 462, DateTimeKind.Utc).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 12, 21, 21, 462, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 12, 21, 21, 462, DateTimeKind.Utc).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 12, 21, 21, 462, DateTimeKind.Utc).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 12, 21, 21, 462, DateTimeKind.Utc).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 12, 21, 21, 462, DateTimeKind.Utc).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3eefa969-31e0-46d3-9d81-d514035dd3de"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 12, 21, 21, 462, DateTimeKind.Utc).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 12, 21, 21, 462, DateTimeKind.Utc).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 12, 21, 21, 462, DateTimeKind.Utc).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 12, 21, 21, 462, DateTimeKind.Utc).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 28, 12, 21, 21, 462, DateTimeKind.Utc).AddTicks(7671));

            migrationBuilder.CreateIndex(
                name: "IX_CategorySubcategories_CategoryId",
                table: "CategorySubcategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategorySubcategories_SubcategoryId",
                table: "CategorySubcategories",
                column: "SubcategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySubcategories_Categories_CategoryId",
                table: "CategorySubcategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySubcategories_Subcategories_SubcategoryId",
                table: "CategorySubcategories",
                column: "SubcategoryId",
                principalTable: "Subcategories",
                principalColumn: "SubcategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategorySubcategories_Categories_CategoryId",
                table: "CategorySubcategories");

            migrationBuilder.DropForeignKey(
                name: "FK_CategorySubcategories_Subcategories_SubcategoryId",
                table: "CategorySubcategories");

            migrationBuilder.DropIndex(
                name: "IX_CategorySubcategories_CategoryId",
                table: "CategorySubcategories");

            migrationBuilder.DropIndex(
                name: "IX_CategorySubcategories_SubcategoryId",
                table: "CategorySubcategories");

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 15, 10, 2, 35, 141, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 15, 10, 2, 35, 141, DateTimeKind.Utc).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 15, 10, 2, 35, 141, DateTimeKind.Utc).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2022, 12, 15, 10, 2, 35, 141, DateTimeKind.Utc).AddTicks(6331), new DateTime(2022, 12, 15, 10, 2, 35, 141, DateTimeKind.Utc).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 15, 10, 2, 35, 141, DateTimeKind.Utc).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 15, 10, 2, 35, 141, DateTimeKind.Utc).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 15, 10, 2, 35, 141, DateTimeKind.Utc).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 15, 10, 2, 35, 141, DateTimeKind.Utc).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 15, 10, 2, 35, 141, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 15, 10, 2, 35, 141, DateTimeKind.Utc).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 15, 10, 2, 35, 141, DateTimeKind.Utc).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 15, 10, 2, 35, 141, DateTimeKind.Utc).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 15, 10, 2, 35, 142, DateTimeKind.Utc).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3eefa969-31e0-46d3-9d81-d514035dd3de"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 15, 10, 2, 35, 142, DateTimeKind.Utc).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 15, 10, 2, 35, 142, DateTimeKind.Utc).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 15, 10, 2, 35, 142, DateTimeKind.Utc).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 15, 10, 2, 35, 142, DateTimeKind.Utc).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2022, 12, 15, 10, 2, 35, 142, DateTimeKind.Utc).AddTicks(2061));
        }
    }
}
