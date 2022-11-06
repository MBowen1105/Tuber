using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tuber.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedBarclaysBankSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bank",
                columns: new[] { "Id", "IsArchived", "Name" },
                values: new object[] { new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"), false, "Barclays Bank" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bank",
                keyColumn: "Id",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"));
        }
    }
}
