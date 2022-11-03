using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tuber.DAL.Migrations
{
    /// <inheritdoc />
    public partial class seededbank : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bank",
                columns: new[] { "Id", "IsArchived", "Name" },
                values: new object[] { new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), false, "Co-Op Bank" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bank",
                keyColumn: "Id",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"));
        }
    }
}
