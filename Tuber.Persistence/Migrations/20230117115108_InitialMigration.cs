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
                });

            migrationBuilder.CreateTable(
                name: "Imports",
                columns: table => new
                {
                    ImportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BankAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Ledgers",
                columns: table => new
                {
                    LedgerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BankAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateUtc = table.Column<DateTime>(type: "datetime2", maxLength: 8, nullable: false),
                    RowNumber = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    MoneyIn = table.Column<double>(type: "float", nullable: true),
                    MoneyOut = table.Column<double>(type: "float", nullable: true),
                    Balance = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubcategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransferBankAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsManualEntry = table.Column<bool>(type: "bit", nullable: false),
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
                        name: "FK_Ledgers_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ledgers_Users_UpdatedByUserId",
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
                name: "Banks",
                columns: table => new
                {
                    BankId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    OrderBy = table.Column<int>(type: "int", nullable: false),
                    ImportTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.BankId);
                    table.ForeignKey(
                        name: "FK_Banks_ImportTemplates_ImportTemplateId",
                        column: x => x.ImportTemplateId,
                        principalTable: "ImportTemplates",
                        principalColumn: "ImportTemplateId");
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
                name: "BankAccounts",
                columns: table => new
                {
                    BankAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BankAccountName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    UKSortCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    UKBankAccount = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    OrderBy = table.Column<int>(type: "int", nullable: false),
                    BankId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImportTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
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
                        principalColumn: "UserId");
                });

            migrationBuilder.InsertData(
                table: "CategorySubcategories",
                columns: new[] { "CategorySubcategoryId", "CategoryId", "IsCoreCategorySubcategory", "IsDeleted", "SubcategoryId" },
                values: new object[,]
                {
                    { new Guid("002e1e54-7359-4b50-aa57-0efb62f0a42c"), new Guid("93678674-f2b0-48a3-91c3-050b506d258d"), true, false, new Guid("04ff391a-26fc-408b-b930-731114e2d994") },
                    { new Guid("7870b00b-d2d3-481b-9701-73f386262e8b"), new Guid("93678674-f2b0-48a3-91c3-050b506d258d"), true, false, new Guid("566195ce-d7a0-4252-8258-8b7b76b7846c") },
                    { new Guid("7f50d5aa-2959-4629-8eaa-e824b311549f"), new Guid("93678674-f2b0-48a3-91c3-050b506d258d"), true, false, new Guid("66e06ca1-305c-48db-88bc-155b040fc82f") },
                    { new Guid("80172b90-d0e3-41f1-bc00-985fc14f5926"), new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"), true, false, new Guid("3077c60b-5d01-4982-b60e-d032cf75d926") },
                    { new Guid("a913b3e2-ab64-4a83-8e61-b41930638b9f"), new Guid("93678674-f2b0-48a3-91c3-050b506d258d"), true, false, new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b") },
                    { new Guid("a99dcad5-5ea6-4d71-9f8c-a7f3db005a83"), new Guid("ff39de05-0b97-4c98-b013-9cee276774cf"), false, false, new Guid("85ae154e-960e-4d35-8e77-a9e7d71eddf1") },
                    { new Guid("c7f625d8-3b1c-4861-9589-f2e85e0596b3"), new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"), true, false, new Guid("179d1384-e290-4bb7-a52d-038a3221d330") },
                    { new Guid("daaf4e6f-00dd-40c0-837f-cb566deb743f"), new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"), true, false, new Guid("ccbd867f-a971-4d3c-b879-2fccb8b92981") },
                    { new Guid("e79d158e-dd3c-4b13-86da-e0b8f9109ff7"), new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"), true, false, new Guid("cac01b14-67a7-4372-8eb1-5e9a0e8a007c") }
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
                values: new object[] { new Guid("de570e94-96ce-4fb8-b33e-22420790f577"), 365, new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 687, DateTimeKind.Utc).AddTicks(7636), null, null });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "BankId", "BankName", "CreatedByUserId", "CreatedOnUtc", "ImportTemplateId", "IsDeleted", "OrderBy", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[] { new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"), "TSB", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 686, DateTimeKind.Utc).AddTicks(7510), null, true, 50, null, null });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "BankId", "BankName", "CreatedByUserId", "CreatedOnUtc", "ImportTemplateId", "OrderBy", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"), "Barclays Bank", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 686, DateTimeKind.Utc).AddTicks(7506), null, 30, null, null },
                    { new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"), "West Bromwich Building Society", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 686, DateTimeKind.Utc).AddTicks(7508), null, 50, null, null },
                    { new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"), "Virgin", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 686, DateTimeKind.Utc).AddTicks(7507), null, 40, null, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CreatedByUserId", "CreatedOnUtc", "IsCoreCategory", "IsDeleted", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"), "Transfer", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 687, DateTimeKind.Utc).AddTicks(4317), true, false, null, null },
                    { new Guid("3eefa969-31e0-46d3-9d81-d514035dd3de"), "Child Maintenance", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 687, DateTimeKind.Utc).AddTicks(4337), false, false, null, null },
                    { new Guid("93678674-f2b0-48a3-91c3-050b506d258d"), "Household Services", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 687, DateTimeKind.Utc).AddTicks(4323), true, false, null, null },
                    { new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"), "Motor", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 687, DateTimeKind.Utc).AddTicks(4319), true, false, null, null },
                    { new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"), "Bank Charged", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 687, DateTimeKind.Utc).AddTicks(4323), true, false, null, null },
                    { new Guid("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9"), "Mortage", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 687, DateTimeKind.Utc).AddTicks(4320), true, false, null, null },
                    { new Guid("ff39de05-0b97-4c98-b013-9cee276774cf"), "Entertainment", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 687, DateTimeKind.Utc).AddTicks(4322), true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "ImportTemplates",
                columns: new[] { "ImportTemplateId", "AccountNumberColumnNumber", "BalanceOnStatementColumnNumber", "CreatedByUserId", "CreatedOnUtc", "DateColumnNumber", "DateTemplate", "DescriptionOnStatementColumnNumber", "ExpectedColumnCount", "ExpectedHeaderRowCount", "ImportFileName", "ImportTemplateName", "MoneyInColumnNumber", "MoneyOutColumnNumber", "ReferenceOnStatementStartCharacter", "SeperatorChar", "SortCodeColumnNumber", "TransactionTypeColumnNumber", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[] { new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"), 0, 6, new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 687, DateTimeKind.Utc).AddTicks(2549), 1, "yyyy-mm-dd", 2, 6, 1, "", "Co-Op Bank Template", 4, 5, 19, ",", 0, 3, null, null });

            migrationBuilder.InsertData(
                table: "ImportTemplates",
                columns: new[] { "ImportTemplateId", "AccountNumberColumnNumber", "BalanceOnStatementColumnNumber", "CreatedByUserId", "CreatedOnUtc", "DateColumnNumber", "DateTemplate", "DescriptionOnStatementColumnNumber", "ExpectedColumnCount", "ExpectedHeaderRowCount", "ImportFileName", "ImportTemplateName", "MoneyInColumnNumber", "MoneyOutColumnNumber", "SeperatorChar", "SortCodeColumnNumber", "TransactionTypeColumnNumber", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[] { new Guid("f642096e-6573-4deb-96be-efba9016499c"), 4, 8, new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 687, DateTimeKind.Utc).AddTicks(2552), 1, "dd-mmm-yyyy", 5, 8, 1, "", "Lloyds Bank Template", 7, 6, ",", 3, 2, null, null });

            migrationBuilder.InsertData(
                table: "Ledgers",
                columns: new[] { "LedgerId", "Balance", "BankAccountId", "CategoryId", "CreatedByUserId", "CreatedOnUtc", "DateUtc", "Description", "IsManualEntry", "IsReconciled", "MoneyIn", "MoneyOut", "Reference", "RowNumber", "SubcategoryId", "TransactionType", "TransferBankAccountId", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("62846f42-1c01-4b2c-bca1-118dcc5cb7c1"), 2056.3200000000002, new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 687, DateTimeKind.Utc).AddTicks(6782), new DateTime(2022, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "DEBIT INTEREST", false, false, 0.17000000000000001, null, "INTEREST", 0, new Guid("ccbd867f-a971-4d3c-b879-2fccb8b92981"), "DD", null, null, null },
                    { new Guid("97730458-05ef-4e84-9e9f-d7b3d601976f"), 1406.3199999999999, new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), new Guid("93678674-f2b0-48a3-91c3-050b506d258d"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 687, DateTimeKind.Utc).AddTicks(6774), new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "EE LIMITED", false, false, null, 24.57, "Q08791420324918228", 0, new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b"), "DD", null, null, null },
                    { new Guid("b581cb5c-8510-48de-b292-bd02641ec08d"), 1430.8900000000001, new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), new Guid("ff39de05-0b97-4c98-b013-9cee276774cf"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 687, DateTimeKind.Utc).AddTicks(6778), new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "CAMELOT LOTTERY", false, false, null, 8.0, "A00143/3965", 0, new Guid("85ae154e-960e-4d35-8e77-a9e7d71eddf1"), "DD", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "SubcategoryId", "CreatedByUserId", "CreatedOnUtc", "IsCoreSubcategory", "IsDeleted", "SubcategoryName", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("04ff391a-26fc-408b-b930-731114e2d994"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 687, DateTimeKind.Utc).AddTicks(4858), true, false, "Gas", null, null },
                    { new Guid("179d1384-e290-4bb7-a52d-038a3221d330"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 687, DateTimeKind.Utc).AddTicks(4852), true, false, "Insurance", null, null },
                    { new Guid("3077c60b-5d01-4982-b60e-d032cf75d926"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 687, DateTimeKind.Utc).AddTicks(4854), true, false, "Road Tax", null, null },
                    { new Guid("566195ce-d7a0-4252-8258-8b7b76b7846c"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 687, DateTimeKind.Utc).AddTicks(4862), true, false, "Water", null, null },
                    { new Guid("66e06ca1-305c-48db-88bc-155b040fc82f"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 687, DateTimeKind.Utc).AddTicks(4856), true, false, "Electricity", null, null },
                    { new Guid("85ae154e-960e-4d35-8e77-a9e7d71eddf1"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 687, DateTimeKind.Utc).AddTicks(4868), false, false, "Gambling", null, null },
                    { new Guid("cac01b14-67a7-4372-8eb1-5e9a0e8a007c"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 687, DateTimeKind.Utc).AddTicks(4839), true, false, "Fuel", null, null },
                    { new Guid("ccbd867f-a971-4d3c-b879-2fccb8b92981"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 687, DateTimeKind.Utc).AddTicks(4866), true, false, "Debit Interest", null, null },
                    { new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 687, DateTimeKind.Utc).AddTicks(4864), true, false, "Mobile", null, null }
                });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "BankAccountId", "BankAccountName", "BankId", "CreatedByUserId", "CreatedOnUtc", "ImportTemplateId", "IsDeleted", "OrderBy", "UKBankAccount", "UKSortCode", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[] { new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"), "TSB Bank Account", new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 686, DateTimeKind.Utc).AddTicks(9366), null, true, 10, "98765555", "440191", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 686, DateTimeKind.Utc).AddTicks(9367) });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "BankId", "BankName", "CreatedByUserId", "CreatedOnUtc", "ImportTemplateId", "OrderBy", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"), "Lloyds Bank", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 686, DateTimeKind.Utc).AddTicks(7504), new Guid("f642096e-6573-4deb-96be-efba9016499c"), 20, null, null },
                    { new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), "Co-Op Bank", new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 686, DateTimeKind.Utc).AddTicks(7497), new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"), 10, null, null }
                });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "BankAccountId", "BankAccountName", "BankId", "CreatedByUserId", "CreatedOnUtc", "ImportTemplateId", "OrderBy", "UKBankAccount", "UKSortCode", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("0c942b54-d561-499a-843b-e4387e7e6415"), "Salary", new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 686, DateTimeKind.Utc).AddTicks(9358), new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"), 10, "09411905", "089191", null, null },
                    { new Guid("552d16a1-d98b-48e9-8580-13029843c116"), "Cash", new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 686, DateTimeKind.Utc).AddTicks(9361), new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"), 20, "00985630", "089191", null, null },
                    { new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"), "Lloyds 93DIX", new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 686, DateTimeKind.Utc).AddTicks(9363), new Guid("f642096e-6573-4deb-96be-efba9016499c"), 10, "09405515", "901111", null, null },
                    { new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"), "Lloyds 25PAR", new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 686, DateTimeKind.Utc).AddTicks(9365), new Guid("f642096e-6573-4deb-96be-efba9016499c"), 20, "09405515", "901111", null, null },
                    { new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"), "Savings", new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 17, 11, 51, 7, 686, DateTimeKind.Utc).AddTicks(9362), new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"), 30, "09405515", "089191", null, null }
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
                name: "IX_Banks_ImportTemplateId",
                table: "Banks",
                column: "ImportTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Banks_UpdatedByUserId",
                table: "Banks",
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
                name: "IX_ImportTemplates_CreatedByUserId",
                table: "ImportTemplates",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ImportTemplates_UpdatedByUserId",
                table: "ImportTemplates",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ledgers_CreatedByUserId",
                table: "Ledgers",
                column: "CreatedByUserId");

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
                name: "BankAccounts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "CategorySubcategories");

            migrationBuilder.DropTable(
                name: "Imports");

            migrationBuilder.DropTable(
                name: "Ledgers");

            migrationBuilder.DropTable(
                name: "Subcategories");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "ImportTemplates");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
