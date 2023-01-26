using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tuber.Persistence.Migrations
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppConfigs",
                columns: table => new
                {
                    AppConfigId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategorySuggestionHorizonDays = table.Column<int>(type: "int", nullable: false, defaultValue: 365),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppConfigs", x => x.AppConfigId);
                    table.ForeignKey(
                        name: "FK_AppConfigs_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppConfigs_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsCoreCategory = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_Categories_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Categories_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ImportTemplates",
                columns: table => new
                {
                    ImportTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImportTemplateName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ImportFileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectedHeaderRowCount = table.Column<int>(type: "int", nullable: false),
                    ExpectedColumnCount = table.Column<int>(type: "int", nullable: false),
                    SeperatorChar = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    DateTemplate = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DateColumnNumber = table.Column<int>(type: "int", nullable: false),
                    DescriptionOnStatementColumnNumber = table.Column<int>(type: "int", nullable: false),
                    ReferenceOnStatementStartCharacter = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    TransactionTypeColumnNumber = table.Column<int>(type: "int", nullable: false),
                    MoneyInColumnNumber = table.Column<int>(type: "int", nullable: false),
                    MoneyOutColumnNumber = table.Column<int>(type: "int", nullable: false),
                    BalanceOnStatementColumnNumber = table.Column<int>(type: "int", nullable: false),
                    SortCodeColumnNumber = table.Column<int>(type: "int", nullable: false),
                    AccountNumberColumnNumber = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
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
                name: "Institutions",
                columns: table => new
                {
                    InstitutionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstitutionName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    OrderBy = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institutions", x => x.InstitutionId);
                    table.ForeignKey(
                        name: "FK_Institutions_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Institutions_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Subcategories",
                columns: table => new
                {
                    SubcategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubcategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsCoreSubcategory = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcategories", x => x.SubcategoryId);
                    table.ForeignKey(
                        name: "FK_Subcategories_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subcategories_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "InstitutionAccounts",
                columns: table => new
                {
                    InstitutionAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstitutionAccountName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    UKSortCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    UKInstitutionAccount = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    OrderBy = table.Column<int>(type: "int", nullable: false),
                    InstitutionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImportTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OpeningBalance = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitutionAccounts", x => x.InstitutionAccountId);
                    table.ForeignKey(
                        name: "FK_InstitutionAccounts_ImportTemplates_ImportTemplateId",
                        column: x => x.ImportTemplateId,
                        principalTable: "ImportTemplates",
                        principalColumn: "ImportTemplateId");
                    table.ForeignKey(
                        name: "FK_InstitutionAccounts_Institutions_InstitutionId",
                        column: x => x.InstitutionId,
                        principalTable: "Institutions",
                        principalColumn: "InstitutionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstitutionAccounts_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_InstitutionAccounts_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "CategorySubcategories",
                columns: table => new
                {
                    CategorySubcategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubcategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsCoreCategorySubcategory = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorySubcategories", x => x.CategorySubcategoryId);
                    table.ForeignKey(
                        name: "FK_CategorySubcategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategorySubcategories_Subcategories_SubcategoryId",
                        column: x => x.SubcategoryId,
                        principalTable: "Subcategories",
                        principalColumn: "SubcategoryId");
                });

            migrationBuilder.CreateTable(
                name: "Imports",
                columns: table => new
                {
                    ImportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstitutionAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImportRowNumber = table.Column<int>(type: "int", nullable: false),
                    DateValueISO8601 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DescriptionOnStatementValue = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DescriptionValue = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ReferenceOnStatementValue = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    TransactionTypeValue = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MoneyInValue = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MoneyOutValue = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    BalanceOnStatementValue = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SortCodeValue = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AccountNumberValue = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubcategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransferInstitutionAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImportRowStatus = table.Column<int>(type: "int", nullable: false),
                    ValidationFailureMessages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImportedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImportedUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imports", x => x.ImportId);
                    table.ForeignKey(
                        name: "FK_Imports_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                    table.ForeignKey(
                        name: "FK_Imports_InstitutionAccounts_InstitutionAccountId",
                        column: x => x.InstitutionAccountId,
                        principalTable: "InstitutionAccounts",
                        principalColumn: "InstitutionAccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Imports_Subcategories_SubcategoryId",
                        column: x => x.SubcategoryId,
                        principalTable: "Subcategories",
                        principalColumn: "SubcategoryId");
                    table.ForeignKey(
                        name: "FK_Imports_Users_ImportedByUserId",
                        column: x => x.ImportedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Ledgers",
                columns: table => new
                {
                    LedgerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstitutionAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateUtc = table.Column<DateTime>(type: "datetime2", maxLength: 8, nullable: false),
                    RowNumber = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    MoneyIn = table.Column<double>(type: "float", nullable: true),
                    MoneyOut = table.Column<double>(type: "float", nullable: true),
                    Balance = table.Column<double>(type: "float", maxLength: 15, nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubcategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransferInstitutionAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransactionOrigin = table.Column<int>(type: "int", nullable: false),
                    IsReconciled = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ledgers", x => x.LedgerId);
                    table.ForeignKey(
                        name: "FK_Ledgers_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ledgers_InstitutionAccounts_InstitutionAccountId",
                        column: x => x.InstitutionAccountId,
                        principalTable: "InstitutionAccounts",
                        principalColumn: "InstitutionAccountId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Ledgers_Subcategories_SubcategoryId",
                        column: x => x.SubcategoryId,
                        principalTable: "Subcategories",
                        principalColumn: "SubcategoryId");
                    table.ForeignKey(
                        name: "FK_Ledgers_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Ledgers_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FullName", "IsCoreUser" },
                values: new object[,]
                {
                    { new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), "Administrator", true },
                    { new Guid("e13a3a77-93c1-4e64-8d58-a517ca1be8d1"), "Mark Bowen", true }
                });

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "AppConfigId", "CategorySuggestionHorizonDays", "CreatedByUserId", "CreatedOnUtc", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[] { new Guid("de570e94-96ce-4fb8-b33e-22420790f577"), 365, new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(3616), null, null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CreatedByUserId", "CreatedOnUtc", "IsCoreCategory", "IsDeleted", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("1c1397e2-6f8e-4a70-b497-8e8e0167a1b8"), "Directors Loan", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(9543), false, false, null, null },
                    { new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), "Transfer", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(9531), true, false, null, null },
                    { new Guid("3eefa969-31e0-46d3-9d81-d514035dd3de"), "Child Maintenance", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(9540), false, false, null, null },
                    { new Guid("4401527f-626e-432f-a048-f10ef4efa2c1"), "Directors Loan", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(9576), false, false, null, null },
                    { new Guid("643d121f-84ed-436b-af50-13225be46aef"), "Political Donations", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(9543), false, false, null, null },
                    { new Guid("7880f9a3-e60d-4eb4-94ef-cd64551d0ae6"), "Taxes", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(9577), false, false, null, null },
                    { new Guid("90af6d97-3a28-47e9-b180-6cd406782c56"), "Investment Income", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(9539), true, false, null, null },
                    { new Guid("93678674-f2b0-48a3-91c3-050b506d258d"), "Household Services", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(9537), true, false, null, null },
                    { new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"), "Motor", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(9534), true, false, null, null },
                    { new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"), "Bank Charges", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(9539), true, false, null, null },
                    { new Guid("d2ccc713-366d-4f7d-8716-fab5932ec73c"), "Other Income", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(9542), false, false, null, null },
                    { new Guid("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9"), "Mortage", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(9535), true, false, null, null },
                    { new Guid("ff39de05-0b97-4c98-b013-9cee276774cf"), "Entertainment", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(9536), true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "ImportTemplates",
                columns: new[] { "ImportTemplateId", "AccountNumberColumnNumber", "BalanceOnStatementColumnNumber", "CreatedByUserId", "CreatedOnUtc", "DateColumnNumber", "DateTemplate", "DescriptionOnStatementColumnNumber", "ExpectedColumnCount", "ExpectedHeaderRowCount", "ImportFileName", "ImportTemplateName", "MoneyInColumnNumber", "MoneyOutColumnNumber", "ReferenceOnStatementStartCharacter", "SeperatorChar", "SortCodeColumnNumber", "TransactionTypeColumnNumber", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[] { new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"), 0, 6, new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(7222), 1, "yyyy-mm-dd", 2, 6, 1, "", "Co-Op Bank Template", 4, 5, 19, ",", 0, 3, null, null });

            migrationBuilder.InsertData(
                table: "ImportTemplates",
                columns: new[] { "ImportTemplateId", "AccountNumberColumnNumber", "BalanceOnStatementColumnNumber", "CreatedByUserId", "CreatedOnUtc", "DateColumnNumber", "DateTemplate", "DescriptionOnStatementColumnNumber", "ExpectedColumnCount", "ExpectedHeaderRowCount", "ImportFileName", "ImportTemplateName", "MoneyInColumnNumber", "MoneyOutColumnNumber", "SeperatorChar", "SortCodeColumnNumber", "TransactionTypeColumnNumber", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[] { new Guid("f642096e-6573-4deb-96be-efba9016499c"), 4, 8, new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(7226), 1, "dd-mmm-yyyy", 5, 8, 1, "", "Lloyds Bank Template", 7, 6, ",", 3, 2, null, null });

            migrationBuilder.InsertData(
                table: "Institutions",
                columns: new[] { "InstitutionId", "CreatedByUserId", "CreatedOnUtc", "InstitutionName", "IsDeleted", "OrderBy", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[] { new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(1783), "TSB", true, 60, null, null });

            migrationBuilder.InsertData(
                table: "Institutions",
                columns: new[] { "InstitutionId", "CreatedByUserId", "CreatedOnUtc", "InstitutionName", "OrderBy", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(1773), "Barclays Institution", 30, null, null },
                    { new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(1782), "West Bromwich Building Society", 50, null, null },
                    { new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(1771), "Lloyds Institution", 20, null, null },
                    { new Guid("64fba8d3-cef0-4a73-8f69-3fecfd186bb1"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(1784), "PayPal", 70, null, null },
                    { new Guid("7115fa18-0319-4d9e-a45a-b7974f0381cf"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(1789), "Anna Institution", 120, null, null },
                    { new Guid("71302810-87a8-484c-83e2-148211a5b82d"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(1787), "Honda Finance", 100, null, null },
                    { new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(1780), "Virgin", 40, null, null },
                    { new Guid("72dfefb5-6408-4e5d-baaa-1217a2c230a4"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(1786), "Principality Building Society", 90, null, null },
                    { new Guid("8680ec5a-7f6c-4ca0-9326-34ad11a24ddc"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(1791), "EE Telecom", 140, null, null },
                    { new Guid("ac5c2909-d1c7-448a-b59c-8509e19b313d"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(1785), "Scottish Widows", 80, null, null },
                    { new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(1765), "Co-Op Institution", 10, null, null },
                    { new Guid("bd472814-2f59-4212-95b5-f0bb81192aff"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(1788), "BUPA", 110, null, null },
                    { new Guid("bfd54588-6c22-43c9-a207-ce52c645f324"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(1790), "Scottish Friendly", 130, null, null },
                    { new Guid("c5cff082-2dc8-4359-9909-30849738703e"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(1792), "Worcestershire Council", 150, null, null }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "SubcategoryId", "CreatedByUserId", "CreatedOnUtc", "IsCoreSubcategory", "IsDeleted", "SubcategoryName", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("04ff391a-26fc-408b-b930-731114e2d994"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(123), true, false, "Gas", null, null },
                    { new Guid("179d1384-e290-4bb7-a52d-038a3221d330"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(115), true, false, "Insurance", null, null },
                    { new Guid("3077c60b-5d01-4982-b60e-d032cf75d926"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(118), true, false, "Road Tax", null, null },
                    { new Guid("45048692-c142-48e4-83b8-fdd7177443c9"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(204), false, false, "Loyalty", null, null },
                    { new Guid("566195ce-d7a0-4252-8258-8b7b76b7846c"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(126), true, false, "Water", null, null },
                    { new Guid("5ab8de02-7a92-4df0-8ab3-8c3450fd9545"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(138), false, false, "Repayments", null, null },
                    { new Guid("66e06ca1-305c-48db-88bc-155b040fc82f"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(121), true, false, "Electricity", null, null },
                    { new Guid("85ae154e-960e-4d35-8e77-a9e7d71eddf1"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(133), false, false, "Gambling", null, null },
                    { new Guid("cac01b14-67a7-4372-8eb1-5e9a0e8a007c"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(107), true, false, "Fuel", null, null },
                    { new Guid("cb84a787-21d3-48eb-96c7-4dc404a8793d"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(208), false, false, "Council Tax", null, null },
                    { new Guid("ccbd867f-a971-4d3c-b879-2fccb8b92981"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(131), true, false, "Debit Interest", null, null },
                    { new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(128), true, false, "Mobile", null, null },
                    { new Guid("de86efb2-764c-48b0-841a-7e29ecb83640"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(136), false, false, "Internet", null, null }
                });

            migrationBuilder.InsertData(
                table: "CategorySubcategories",
                columns: new[] { "CategorySubcategoryId", "CategoryId", "IsCoreCategorySubcategory", "IsDeleted", "SubcategoryId" },
                values: new object[,]
                {
                    { new Guid("002e1e54-7359-4b50-aa57-0efb62f0a42c"), new Guid("93678674-f2b0-48a3-91c3-050b506d258d"), true, false, new Guid("04ff391a-26fc-408b-b930-731114e2d994") },
                    { new Guid("08c3ab1e-0554-4e70-8432-8443224dd42d"), new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"), false, false, new Guid("5ab8de02-7a92-4df0-8ab3-8c3450fd9545") },
                    { new Guid("7870b00b-d2d3-481b-9701-73f386262e8b"), new Guid("93678674-f2b0-48a3-91c3-050b506d258d"), true, false, new Guid("566195ce-d7a0-4252-8258-8b7b76b7846c") },
                    { new Guid("7f50d5aa-2959-4629-8eaa-e824b311549f"), new Guid("93678674-f2b0-48a3-91c3-050b506d258d"), true, false, new Guid("66e06ca1-305c-48db-88bc-155b040fc82f") },
                    { new Guid("80172b90-d0e3-41f1-bc00-985fc14f5926"), new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"), true, false, new Guid("3077c60b-5d01-4982-b60e-d032cf75d926") },
                    { new Guid("a913b3e2-ab64-4a83-8e61-b41930638b9f"), new Guid("93678674-f2b0-48a3-91c3-050b506d258d"), true, false, new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b") },
                    { new Guid("a99dcad5-5ea6-4d71-9f8c-a7f3db005a83"), new Guid("ff39de05-0b97-4c98-b013-9cee276774cf"), false, false, new Guid("85ae154e-960e-4d35-8e77-a9e7d71eddf1") },
                    { new Guid("c7f625d8-3b1c-4861-9589-f2e85e0596b3"), new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"), true, false, new Guid("179d1384-e290-4bb7-a52d-038a3221d330") },
                    { new Guid("d9035a09-2be1-4322-84f7-30397e4f50f2"), new Guid("93678674-f2b0-48a3-91c3-050b506d258d"), true, false, new Guid("de86efb2-764c-48b0-841a-7e29ecb83640") },
                    { new Guid("daaf4e6f-00dd-40c0-837f-cb566deb743f"), new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"), true, false, new Guid("ccbd867f-a971-4d3c-b879-2fccb8b92981") },
                    { new Guid("e79d158e-dd3c-4b13-86da-e0b8f9109ff7"), new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"), true, false, new Guid("cac01b14-67a7-4372-8eb1-5e9a0e8a007c") }
                });

            migrationBuilder.InsertData(
                table: "InstitutionAccounts",
                columns: new[] { "InstitutionAccountId", "CreatedByUserId", "CreatedOnUtc", "ImportTemplateId", "InstitutionAccountName", "InstitutionId", "OpeningBalance", "OrderBy", "UKInstitutionAccount", "UKSortCode", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[] { new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4061), new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"), "Salary", new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), 595.00999999999999, 10, "09411905", "089191", null, null });

            migrationBuilder.InsertData(
                table: "InstitutionAccounts",
                columns: new[] { "InstitutionAccountId", "CreatedByUserId", "CreatedOnUtc", "ImportTemplateId", "InstitutionAccountName", "InstitutionId", "OrderBy", "UKInstitutionAccount", "UKSortCode", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("0dce26bf-cd3f-4bbf-b2f9-a47e95d7fb3b"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4123), null, "Ethans Savings A/C", new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"), 30, "", "", null, null },
                    { new Guid("1b0a51db-1635-4df2-9faa-7f5d6f0450f1"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4140), null, "West Bromwich Building Society", new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"), 10, "", "", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4141) },
                    { new Guid("315e3cc7-3dcd-4f16-906a-4f433df80139"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4156), null, "EE Telecom A/C", new Guid("8680ec5a-7f6c-4ca0-9326-34ad11a24ddc"), 10, "", "", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4156) },
                    { new Guid("462c8d2c-ddd6-4de5-bc98-21c6094ffa3e"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4142), null, "Co-Op Travel Credit Card", new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), 40, "", "", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4145) },
                    { new Guid("552d16a1-d98b-48e9-8580-13029843c116"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4066), new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"), "Cash", new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), 20, "00985630", "089191", null, null },
                    { new Guid("6219e157-8c03-4eaa-b78f-4fde4a2b19d0"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4151), null, "Cyrus Solutions Check A/C", new Guid("7115fa18-0319-4d9e-a45a-b7974f0381cf"), 10, "", "", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4151) },
                    { new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4073), new Guid("f642096e-6573-4deb-96be-efba9016499c"), "Lloyds 93DIX", new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"), 10, "09405515", "901111", null, null },
                    { new Guid("7326c494-50b1-4128-bb2c-f36a475f5b81"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4076), null, "Barclays Check A/C", new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"), 10, "", "", null, null },
                    { new Guid("7d516d57-1e24-4f0c-9e23-67200adabe51"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4154), null, "Scottish Friendly PHI A/C", new Guid("bfd54588-6c22-43c9-a207-ce52c645f324"), 10, "", "", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4154) },
                    { new Guid("7e42a92d-4296-4eb9-9d4c-db86051c42c7"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4078), null, "Alexs Savings A/C", new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"), 20, "", "", null, null },
                    { new Guid("8219473f-a6c6-44ea-b9eb-561032dd372e"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4149), null, "BUPA Health A/C", new Guid("bd472814-2f59-4212-95b5-f0bb81192aff"), 10, "", "", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4149) },
                    { new Guid("85a437ee-b0b4-449c-9c81-8a2b40c94feb"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4147), null, "Honda Finance", new Guid("71302810-87a8-484c-83e2-148211a5b82d"), 10, "", "", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4147) },
                    { new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4126), null, "TSB Institution Account", new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"), 10, "98765555", "440191", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4127) },
                    { new Guid("b1436024-ad18-4f15-8d24-2aba82ea12fa"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4160), null, "Virgin Money ISA", new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"), 10, "", "", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4161) },
                    { new Guid("bbce5ac1-da50-4ec7-8a72-3011174c649c"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4158), null, "Council Tax A/C", new Guid("c5cff082-2dc8-4359-9909-30849738703e"), 10, "", "", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4158) },
                    { new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4074), new Guid("f642096e-6573-4deb-96be-efba9016499c"), "Lloyds 25PAR", new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"), 20, "09405515", "901111", null, null },
                    { new Guid("c8637e26-7598-49ce-89d6-82f2f184f540"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4132), null, "PayPal", new Guid("64fba8d3-cef0-4a73-8f69-3fecfd186bb1"), 10, "", "", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4132) },
                    { new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4069), new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"), "Savings", new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), 30, "09405515", "089191", null, null },
                    { new Guid("f0781ba0-c93d-4115-8230-7329e4708c07"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4134), null, "Scottish Widows Pension", new Guid("ac5c2909-d1c7-448a-b59c-8509e19b313d"), 10, "", "", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4135) },
                    { new Guid("f9d4bc01-e0b0-43e1-9ef3-b068dfc2fc4a"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4138), null, "Principality Building Society", new Guid("72dfefb5-6408-4e5d-baaa-1217a2c230a4"), 10, "", "", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 305, DateTimeKind.Utc).AddTicks(4138) }
                });

            migrationBuilder.InsertData(
                table: "Ledgers",
                columns: new[] { "LedgerId", "Balance", "CategoryId", "CreatedByUserId", "CreatedOnUtc", "DateUtc", "Description", "InstitutionAccountId", "IsReconciled", "MoneyIn", "MoneyOut", "Reference", "RowNumber", "SubcategoryId", "TransactionOrigin", "TransactionType", "TransferInstitutionAccountId", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("06226032-0cd7-406c-ae33-90aa2061e045"), -109.68000000000001, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2613), new DateTime(2022, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "PRINCIPALITY BS", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), false, null, 124.31, "079271710", 1, null, 1, "DD", new Guid("f9d4bc01-e0b0-43e1-9ef3-b068dfc2fc4a"), null, null },
                    { new Guid("069215d0-7731-4751-90f3-4e4e98cf676c"), 4.6500000000000004, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2639), new DateTime(2022, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "M Bowen", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), false, 200.0, null, "PROFIT TAKING", 1, null, 1, "CREDIT", new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"), null, null },
                    { new Guid("0a7eea23-0537-408e-935a-36e89ea0db6c"), 0.0, new Guid("d2ccc713-366d-4f7d-8716-fab5932ec73c"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2633), new DateTime(2022, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "EVERYDAYREWARD NET", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), false, 1.0, null, "", 4, new Guid("45048692-c142-48e4-83b8-fdd7177443c9"), 1, "CREDIT", null, null, null },
                    { new Guid("147f2b53-72cb-4bbb-adbf-14e036c97814"), 0.0, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2642), new DateTime(2022, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "M Bowen", new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"), false, null, 200.0, "PROFIT TAKING", 1, null, 1, "CREDIT", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), null, null },
                    { new Guid("17e934ca-2006-4624-b82e-673755e4a0e2"), 0.0, new Guid("1c1397e2-6f8e-4a70-b497-8e8e0167a1b8"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2711), new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "CYRUS SOLUTIONS", new Guid("6219e157-8c03-4eaa-b78f-4fde4a2b19d0"), false, 30.0, null, "LOAN TO CYSOL", 1, null, 1, "BP/SO", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), null, null },
                    { new Guid("1c13a7f0-7256-4765-abca-2d7d636e16f5"), -176.59, new Guid("643d121f-84ed-436b-af50-13225be46aef"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2695), new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "LABOUR PARTY", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), false, null, 4.6699999999999999, "653577715906242518", 2, null, 1, "DD", null, null, null },
                    { new Guid("1ca9a32c-64e3-49cb-91ef-7956d3962deb"), 126.31999999999999, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2702), new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "BUPA CENTRAL A/C", new Guid("8219473f-a6c6-44ea-b9eb-561032dd372e"), false, 126.31999999999999, null, "9086677780", 1, null, 1, "DD", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), null, null },
                    { new Guid("216effe9-7e8e-497f-8aa2-8e58c4f07e62"), 0.0, new Guid("93678674-f2b0-48a3-91c3-050b506d258d"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2729), new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "EE LIMITED", new Guid("315e3cc7-3dcd-4f16-906a-4f433df80139"), false, 30.449999999999999, null, "Q08791420316823829", 1, new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b"), 1, "DD", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), null, null },
                    { new Guid("27b590d4-41d5-4bdd-b593-084bd7756cba"), 464.63, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2602), new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "TFR 93000810462300", new Guid("552d16a1-d98b-48e9-8580-13029843c116"), false, 100.0, null, "", 3, null, 1, "TRANSFER", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), null, null },
                    { new Guid("31880754-8033-41c7-8886-e152fb80043c"), -302.91000000000003, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2699), new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "BUPA CENTRAL A/C", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), false, null, 126.31999999999999, "9086677780", 3, null, 1, "DD", new Guid("8219473f-a6c6-44ea-b9eb-561032dd372e"), null, null },
                    { new Guid("442b688c-8329-418c-8f84-b77a0b61dfa0"), -305.80000000000001, new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2705), new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "DEBIT INTEREST", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), false, null, 2.8900000000000001, "INTEREST", 4, null, 1, "", null, null, null },
                    { new Guid("4e01f919-f0a8-47a3-aa32-7140597a640f"), 464.63, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2598), new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "TFR 93000810462300", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), false, null, 100.0, "", 2, null, 1, "TRANSFER", new Guid("552d16a1-d98b-48e9-8580-13029843c116"), null, null },
                    { new Guid("4f8a8b62-6d95-4854-8add-fc31e0a6a50f"), 90.939999999999998, new Guid("4401527f-626e-432f-a048-f10ef4efa2c1"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2720), new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "SCOTTISH FRIENDLY", new Guid("7d516d57-1e24-4f0c-9e23-67200adabe51"), false, 90.939999999999998, null, "PSD/OBC10256454", 1, null, 1, "DD", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), null, null },
                    { new Guid("5217de79-f7ee-4a30-9d2c-9227a0b47941"), 34.810000000000002, new Guid("7880f9a3-e60d-4eb4-94ef-cd64551d0ae6"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2732), new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "REDDITCH BOROUGH C", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), false, 150.0, null, "01      4001843058", 4, new Guid("cb84a787-21d3-48eb-96c7-4dc404a8793d"), 1, "CREDIT", new Guid("bbce5ac1-da50-4ec7-8a72-3011174c649c"), null, null },
                    { new Guid("567b5a46-7b17-4a1e-832e-f009fab60ef8"), 14.630000000000001, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2606), new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "SCOTTISH WIDOWS", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), false, null, 450.0, "PR859326H", 1, null, 1, "DD", new Guid("f0781ba0-c93d-4115-8230-7329e4708c07"), null, null },
                    { new Guid("62846f42-1c01-4b2c-bca1-118dcc5cb7c1"), 564.63, new Guid("93678674-f2b0-48a3-91c3-050b506d258d"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2595), new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "PNET3584204-1", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), false, null, 30.370000000000001, "", 1, new Guid("de86efb2-764c-48b0-841a-7e29ecb83640"), 1, "DD", null, null, null },
                    { new Guid("6495197d-b80d-4358-9c2c-4e52779614f0"), 450.0, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2609), new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "SCOTTISH WIDOWS", new Guid("f0781ba0-c93d-4115-8230-7329e4708c07"), false, 450.0, null, "PR859326H", 1, null, 1, "DD", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), null, null },
                    { new Guid("67a77698-15bb-4b79-b6a5-e053d9a3fa2f"), 124.31, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2616), new DateTime(2022, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "PRINCIPALITY BS", new Guid("f9d4bc01-e0b0-43e1-9ef3-b068dfc2fc4a"), false, 124.31, null, "079271710", 1, null, 1, "DD", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), null, null },
                    { new Guid("6cc18b28-9390-4837-a181-0444810515e7"), 0.0, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2630), new DateTime(2022, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "THE CO-OP BANK", new Guid("462c8d2c-ddd6-4de5-bc98-21c6094ffa3e"), false, 5.9900000000000002, null, "4552061305790731", 1, null, 1, "DD", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), null, null },
                    { new Guid("6cd73668-eb60-4d7b-94be-d2247f8ea4cc"), -84.739999999999995, new Guid("ff39de05-0b97-4c98-b013-9cee276774cf"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2723), new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "CAMELOT LOTTERY", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), false, null, 8.0, "A00143/3965", 2, new Guid("85ae154e-960e-4d35-8e77-a9e7d71eddf1"), 1, "DD", null, null, null },
                    { new Guid("6dcb4fb2-f386-4950-ac00-112b7a2dda36"), 0.0, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2687), new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "HONDA FINANCE EURO", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), false, null, 176.56999999999999, "0704899-2219333577", 1, null, 1, "DD", new Guid("85a437ee-b0b4-449c-9c81-8a2b40c94feb"), null, null },
                    { new Guid("819bd791-b27c-403f-97b9-899d73ca2060"), -115.19, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2725), new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "EE LIMITED", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), false, null, 30.449999999999999, "Q08791420316823829", 3, null, 1, "DD", new Guid("315e3cc7-3dcd-4f16-906a-4f433df80139"), null, null },
                    { new Guid("857fd6c8-e83f-4155-8909-64de3f18f566"), 595.0, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2589), new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "PAYPAL PAYMENT", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), false, null, 11.9, "576J2223CC7UY", 2, null, 1, "DD", new Guid("c8637e26-7598-49ce-89d6-82f2f184f540"), null, null },
                    { new Guid("8bae9b31-420c-475d-bdf8-e1c259a62546"), -190.36000000000001, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2619), new DateTime(2022, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "WEST BROMWICH BSOC", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), false, null, 80.680000000000007, "9015660300023849", 2, null, 1, "DD", new Guid("1b0a51db-1635-4df2-9faa-7f5d6f0450f1"), null, null },
                    { new Guid("8fe3ef95-7cbc-40e6-9772-432d2e0dfca2"), 150.0, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2735), new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "REDDITCH BOROUGH C", new Guid("bbce5ac1-da50-4ec7-8a72-3011174c649c"), false, null, 150.0, "01      4001843058", 1, null, 1, "CREDIT", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), null, null },
                    { new Guid("97730458-05ef-4e84-9e9f-d7b3d601976f"), 606.89999999999998, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2579), new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "PAYPAL PAYMENT", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), false, null, 11.890000000000001, "576J2223CC7UY", 1, null, 1, "DD", new Guid("c8637e26-7598-49ce-89d6-82f2f184f540"), null, null },
                    { new Guid("9980d6a7-949c-4375-83c9-186efe3c96e8"), -190.36000000000001, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2625), new DateTime(2022, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "THE CO-OP BANK", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), false, null, 5.9900000000000002, "4552061305790731", 3, null, 1, "DD", new Guid("462c8d2c-ddd6-4de5-bc98-21c6094ffa3e"), null, null },
                    { new Guid("a4f38fb9-2893-4be0-bba2-a111f053c65f"), -335.80000000000001, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2708), new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "CYRUS SOLUTIONS", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), false, null, 30.0, "LOAN TO CYSOL", 5, null, 1, "BP/SO", new Guid("6219e157-8c03-4eaa-b78f-4fde4a2b19d0"), null, null },
                    { new Guid("b581cb5c-8510-48de-b292-bd02641ec08d"), 11.890000000000001, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2585), new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "PAYPAL PAYMENT", new Guid("c8637e26-7598-49ce-89d6-82f2f184f540"), false, 11.890000000000001, null, "576J2223CC7UY", 1, null, 1, "DD", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), null, null },
                    { new Guid("b8625f27-c65d-448d-ad9f-b60cc7dfd735"), -76.739999999999995, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2716), new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "SCOTTISH FRIENDLY", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), false, null, 90.939999999999998, "PSD/OBC10256454", 1, null, 1, "DD", new Guid("7d516d57-1e24-4f0c-9e23-67200adabe51"), null, null },
                    { new Guid("bf009ba6-7586-4ab9-9597-87502f284a3f"), 0.0, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2692), new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "HONDA FINANCE EURO", new Guid("85a437ee-b0b4-449c-9c81-8a2b40c94feb"), false, 176.56999999999999, null, "0704899-2219333577", 1, null, 1, "DD", new Guid("85a437ee-b0b4-449c-9c81-8a2b40c94feb"), null, null },
                    { new Guid("c13ae2e6-cf8a-4583-8db5-9834bb20fa5a"), 0.0, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2622), new DateTime(2022, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "WEST BROMWICH BSOC", new Guid("1b0a51db-1635-4df2-9faa-7f5d6f0450f1"), false, 80.680000000000007, null, "079271710", 1, null, 1, "DD", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), null, null },
                    { new Guid("d37a4933-756f-4e8a-9c93-d812472178f6"), 23.789999999999999, new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 22, 22, 38, 306, DateTimeKind.Utc).AddTicks(2592), new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "PAYPAL PAYMENT", new Guid("c8637e26-7598-49ce-89d6-82f2f184f540"), false, 11.9, null, "576J2223CC7UY", 2, null, 1, "DD", new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppConfigs_CreatedByUserId",
                table: "AppConfigs",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AppConfigs_UpdatedByUserId",
                table: "AppConfigs",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CreatedByUserId",
                table: "Categories",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_UpdatedByUserId",
                table: "Categories",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CategorySubcategories_CategoryId",
                table: "CategorySubcategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategorySubcategories_SubcategoryId",
                table: "CategorySubcategories",
                column: "SubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Imports_CategoryId",
                table: "Imports",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Imports_ImportedByUserId",
                table: "Imports",
                column: "ImportedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Imports_InstitutionAccountId",
                table: "Imports",
                column: "InstitutionAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Imports_SubcategoryId",
                table: "Imports",
                column: "SubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ImportTemplates_CreatedByUserId",
                table: "ImportTemplates",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ImportTemplates_UpdatedByUserId",
                table: "ImportTemplates",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitutionAccounts_CreatedByUserId",
                table: "InstitutionAccounts",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitutionAccounts_ImportTemplateId",
                table: "InstitutionAccounts",
                column: "ImportTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitutionAccounts_InstitutionId",
                table: "InstitutionAccounts",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitutionAccounts_UpdatedByUserId",
                table: "InstitutionAccounts",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Institutions_CreatedByUserId",
                table: "Institutions",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Institutions_UpdatedByUserId",
                table: "Institutions",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ledgers_CategoryId",
                table: "Ledgers",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Ledgers_CreatedByUserId",
                table: "Ledgers",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ledgers_InstitutionAccountId",
                table: "Ledgers",
                column: "InstitutionAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Ledgers_SubcategoryId",
                table: "Ledgers",
                column: "SubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Ledgers_UpdatedByUserId",
                table: "Ledgers",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Subcategories_CreatedByUserId",
                table: "Subcategories",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Subcategories_UpdatedByUserId",
                table: "Subcategories",
                column: "UpdatedByUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppConfigs");

            migrationBuilder.DropTable(
                name: "CategorySubcategories");

            migrationBuilder.DropTable(
                name: "Imports");

            migrationBuilder.DropTable(
                name: "Ledgers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "InstitutionAccounts");

            migrationBuilder.DropTable(
                name: "Subcategories");

            migrationBuilder.DropTable(
                name: "ImportTemplates");

            migrationBuilder.DropTable(
                name: "Institutions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
