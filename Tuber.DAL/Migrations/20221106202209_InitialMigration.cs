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
                name: "Bank",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    OrderBy = table.Column<int>(type: "int", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankAccount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    OrderBy = table.Column<int>(type: "int", nullable: false),
                    BankId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankAccount_Bank_BankId",
                        column: x => x.BankId,
                        principalTable: "Bank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bank",
                columns: new[] { "Id", "IsArchived", "Name", "OrderBy" },
                values: new object[,]
                {
                    { new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"), false, "Barclays Bank", 30 },
                    { new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"), false, "Lloyds Bank", 20 },
                    { new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), false, "Co-Op Bank", 10 }
                });

            migrationBuilder.InsertData(
                table: "BankAccount",
                columns: new[] { "Id", "BankId", "IsArchived", "Name", "OrderBy" },
                values: new object[,]
                {
                    { new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), false, "Salary", 10 },
                    { new Guid("552d16a1-d98b-48e9-8580-13029843c116"), new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), false, "Cash", 20 },
                    { new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"), new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), false, "Savings", 30 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankAccount_BankId",
                table: "BankAccount",
                column: "BankId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankAccount");

            migrationBuilder.DropTable(
                name: "Bank");
        }
    }
}
