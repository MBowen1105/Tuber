using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tuber.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedBankSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bank",
                columns: new[] { "Id", "IsArchived", "Name" },
                values: new object[] { new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"), false, "Lloyds Bank" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bank",
                keyColumn: "Id",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"));
        }
    }
}
