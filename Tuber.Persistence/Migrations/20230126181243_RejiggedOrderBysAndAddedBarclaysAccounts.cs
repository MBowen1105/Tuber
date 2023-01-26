﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tuber.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RejiggedOrderBysAndAddedBarclaysAccounts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppConfigs",
                keyColumn: "AppConfigId",
                keyValue: new Guid("de570e94-96ce-4fb8-b33e-22420790f577"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("1b0a51db-1635-4df2-9faa-7f5d6f0450f1"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2864), new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("315e3cc7-3dcd-4f16-906a-4f433df80139"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2881), new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("462c8d2c-ddd6-4de5-bc98-21c6094ffa3e"),
                columns: new[] { "CreatedOnUtc", "OrderBy", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2866), 40, new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("6219e157-8c03-4eaa-b78f-4fde4a2b19d0"),
                columns: new[] { "BankAccountName", "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { "Cyrus Solutions Check A/C", new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2876), new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("7d516d57-1e24-4f0c-9e23-67200adabe51"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2879), new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8219473f-a6c6-44ea-b9eb-561032dd372e"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2874), new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("85a437ee-b0b4-449c-9c81-8a2b40c94feb"),
                columns: new[] { "BankAccountName", "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { "Honda Finance", new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2872), new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2807), new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("bbce5ac1-da50-4ec7-8a72-3011174c649c"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2883), new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c8637e26-7598-49ce-89d6-82f2f184f540"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2813), new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("f0781ba0-c93d-4115-8230-7329e4708c07"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2815), new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("f9d4bc01-e0b0-43e1-9ef3-b068dfc2fc4a"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2862), new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2862) });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "BankAccountId", "BankAccountName", "BankId", "CreatedByUserId", "CreatedOnUtc", "ImportTemplateId", "OrderBy", "UKBankAccount", "UKSortCode", "UpdatedByUserId", "UpdatedOnUtc" },
                values: new object[,]
                {
                    { new Guid("0dce26bf-cd3f-4bbf-b2f9-a47e95d7fb3b"), "Ethans Savings A/C", new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2805), null, 30, "", "", null, null },
                    { new Guid("7326c494-50b1-4128-bb2c-f36a475f5b81"), "Barclays Check A/C", new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2802), null, 10, "", "", null, null },
                    { new Guid("7e42a92d-4296-4eb9-9d4c-db86051c42c7"), "Alexs Savings A/C", new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"), new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"), new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(2803), null, 20, "", "", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                columns: new[] { "CreatedOnUtc", "OrderBy" },
                values: new object[] { new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(432), 60 });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("64fba8d3-cef0-4a73-8f69-3fecfd186bb1"),
                columns: new[] { "CreatedOnUtc", "OrderBy" },
                values: new object[] { new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(433), 70 });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("7115fa18-0319-4d9e-a45a-b7974f0381cf"),
                columns: new[] { "CreatedOnUtc", "OrderBy" },
                values: new object[] { new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(439), 120 });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71302810-87a8-484c-83e2-148211a5b82d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("72dfefb5-6408-4e5d-baaa-1217a2c230a4"),
                columns: new[] { "CreatedOnUtc", "OrderBy" },
                values: new object[] { new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(436), 90 });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("8680ec5a-7f6c-4ca0-9326-34ad11a24ddc"),
                columns: new[] { "CreatedOnUtc", "OrderBy" },
                values: new object[] { new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(441), 140 });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("ac5c2909-d1c7-448a-b59c-8509e19b313d"),
                columns: new[] { "CreatedOnUtc", "OrderBy" },
                values: new object[] { new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(435), 80 });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("bd472814-2f59-4212-95b5-f0bb81192aff"),
                columns: new[] { "CreatedOnUtc", "OrderBy" },
                values: new object[] { new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(438), 110 });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("bfd54588-6c22-43c9-a207-ce52c645f324"),
                columns: new[] { "CreatedOnUtc", "OrderBy" },
                values: new object[] { new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(440), 130 });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("c5cff082-2dc8-4359-9909-30849738703e"),
                columns: new[] { "CreatedOnUtc", "OrderBy" },
                values: new object[] { new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(442), 150 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1c1397e2-6f8e-4a70-b497-8e8e0167a1b8"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3eefa969-31e0-46d3-9d81-d514035dd3de"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4401527f-626e-432f-a048-f10ef4efa2c1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("643d121f-84ed-436b-af50-13225be46aef"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7880f9a3-e60d-4eb4-94ef-cd64551d0ae6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("90af6d97-3a28-47e9-b180-6cd406782c56"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("93678674-f2b0-48a3-91c3-050b506d258d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d2ccc713-366d-4f7d-8716-fab5932ec73c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ff39de05-0b97-4c98-b013-9cee276774cf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("06226032-0cd7-406c-ae33-90aa2061e045"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("069215d0-7731-4751-90f3-4e4e98cf676c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("0a7eea23-0537-408e-935a-36e89ea0db6c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("147f2b53-72cb-4bbb-adbf-14e036c97814"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("17e934ca-2006-4624-b82e-673755e4a0e2"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("1c13a7f0-7256-4765-abca-2d7d636e16f5"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("1ca9a32c-64e3-49cb-91ef-7956d3962deb"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("216effe9-7e8e-497f-8aa2-8e58c4f07e62"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("27b590d4-41d5-4bdd-b593-084bd7756cba"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("31880754-8033-41c7-8886-e152fb80043c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("442b688c-8329-418c-8f84-b77a0b61dfa0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("4e01f919-f0a8-47a3-aa32-7140597a640f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("4f8a8b62-6d95-4854-8add-fc31e0a6a50f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("5217de79-f7ee-4a30-9d2c-9227a0b47941"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("567b5a46-7b17-4a1e-832e-f009fab60ef8"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("62846f42-1c01-4b2c-bca1-118dcc5cb7c1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("6495197d-b80d-4358-9c2c-4e52779614f0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("67a77698-15bb-4b79-b6a5-e053d9a3fa2f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("6cc18b28-9390-4837-a181-0444810515e7"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("6cd73668-eb60-4d7b-94be-d2247f8ea4cc"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("6dcb4fb2-f386-4950-ac00-112b7a2dda36"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("819bd791-b27c-403f-97b9-899d73ca2060"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("857fd6c8-e83f-4155-8909-64de3f18f566"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("8bae9b31-420c-475d-bdf8-e1c259a62546"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("8fe3ef95-7cbc-40e6-9772-432d2e0dfca2"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("97730458-05ef-4e84-9e9f-d7b3d601976f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("9980d6a7-949c-4375-83c9-186efe3c96e8"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("a4f38fb9-2893-4be0-bba2-a111f053c65f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("b581cb5c-8510-48de-b292-bd02641ec08d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("b8625f27-c65d-448d-ad9f-b60cc7dfd735"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("bf009ba6-7586-4ab9-9597-87502f284a3f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("c13ae2e6-cf8a-4583-8db5-9834bb20fa5a"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("d37a4933-756f-4e8a-9c93-d812472178f6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 629, DateTimeKind.Utc).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("04ff391a-26fc-408b-b930-731114e2d994"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("179d1384-e290-4bb7-a52d-038a3221d330"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("3077c60b-5d01-4982-b60e-d032cf75d926"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("45048692-c142-48e4-83b8-fdd7177443c9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("566195ce-d7a0-4252-8258-8b7b76b7846c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("5ab8de02-7a92-4df0-8ab3-8c3450fd9545"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("66e06ca1-305c-48db-88bc-155b040fc82f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("85ae154e-960e-4d35-8e77-a9e7d71eddf1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("cac01b14-67a7-4372-8eb1-5e9a0e8a007c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("cb84a787-21d3-48eb-96c7-4dc404a8793d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("ccbd867f-a971-4d3c-b879-2fccb8b92981"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("de86efb2-764c-48b0-841a-7e29ecb83640"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 18, 12, 42, 628, DateTimeKind.Utc).AddTicks(8735));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0dce26bf-cd3f-4bbf-b2f9-a47e95d7fb3b"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("7326c494-50b1-4128-bb2c-f36a475f5b81"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("7e42a92d-4296-4eb9-9d4c-db86051c42c7"));

            migrationBuilder.UpdateData(
                table: "AppConfigs",
                keyColumn: "AppConfigId",
                keyValue: new Guid("de570e94-96ce-4fb8-b33e-22420790f577"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("1b0a51db-1635-4df2-9faa-7f5d6f0450f1"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6615), new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("315e3cc7-3dcd-4f16-906a-4f433df80139"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6630), new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("462c8d2c-ddd6-4de5-bc98-21c6094ffa3e"),
                columns: new[] { "CreatedOnUtc", "OrderBy", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6617), 10, new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("6219e157-8c03-4eaa-b78f-4fde4a2b19d0"),
                columns: new[] { "BankAccountName", "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { "Ctrus Solutions Check A/C", new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6623), new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("7d516d57-1e24-4f0c-9e23-67200adabe51"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6628), new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8219473f-a6c6-44ea-b9eb-561032dd372e"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6620), new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("85a437ee-b0b4-449c-9c81-8a2b40c94feb"),
                columns: new[] { "BankAccountName", "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { "Honda Motors", new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6618), new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6603), new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("bbce5ac1-da50-4ec7-8a72-3011174c649c"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6632), new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c8637e26-7598-49ce-89d6-82f2f184f540"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6608), new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("f0781ba0-c93d-4115-8230-7329e4708c07"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6610), new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6611) });

            migrationBuilder.UpdateData(
                table: "BankAccounts",
                keyColumn: "BankAccountId",
                keyValue: new Guid("f9d4bc01-e0b0-43e1-9ef3-b068dfc2fc4a"),
                columns: new[] { "CreatedOnUtc", "UpdatedOnUtc" },
                values: new object[] { new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6613), new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                columns: new[] { "CreatedOnUtc", "OrderBy" },
                values: new object[] { new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(4205), 50 });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("5a250fff-d109-429a-b59d-e7582c6272a0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("64fba8d3-cef0-4a73-8f69-3fecfd186bb1"),
                columns: new[] { "CreatedOnUtc", "OrderBy" },
                values: new object[] { new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(4206), 60 });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("7115fa18-0319-4d9e-a45a-b7974f0381cf"),
                columns: new[] { "CreatedOnUtc", "OrderBy" },
                values: new object[] { new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(4212), 110 });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71302810-87a8-484c-83e2-148211a5b82d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("72dfefb5-6408-4e5d-baaa-1217a2c230a4"),
                columns: new[] { "CreatedOnUtc", "OrderBy" },
                values: new object[] { new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(4208), 80 });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("8680ec5a-7f6c-4ca0-9326-34ad11a24ddc"),
                columns: new[] { "CreatedOnUtc", "OrderBy" },
                values: new object[] { new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(4216), 130 });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("ac5c2909-d1c7-448a-b59c-8509e19b313d"),
                columns: new[] { "CreatedOnUtc", "OrderBy" },
                values: new object[] { new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(4207), 70 });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("bd472814-2f59-4212-95b5-f0bb81192aff"),
                columns: new[] { "CreatedOnUtc", "OrderBy" },
                values: new object[] { new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(4211), 100 });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("bfd54588-6c22-43c9-a207-ce52c645f324"),
                columns: new[] { "CreatedOnUtc", "OrderBy" },
                values: new object[] { new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(4213), 120 });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "BankId",
                keyValue: new Guid("c5cff082-2dc8-4359-9909-30849738703e"),
                columns: new[] { "CreatedOnUtc", "OrderBy" },
                values: new object[] { new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(4217), 140 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1c1397e2-6f8e-4a70-b497-8e8e0167a1b8"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("27d48d80-b231-4c28-b1e5-af2100d24913"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3eefa969-31e0-46d3-9d81-d514035dd3de"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4401527f-626e-432f-a048-f10ef4efa2c1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("643d121f-84ed-436b-af50-13225be46aef"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7880f9a3-e60d-4eb4-94ef-cd64551d0ae6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("90af6d97-3a28-47e9-b180-6cd406782c56"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("93678674-f2b0-48a3-91c3-050b506d258d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("97ea6440-ddb5-42ad-967f-5c9d34646b14"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ba134b1e-095b-4dc7-800d-94f27a1d9747"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d2ccc713-366d-4f7d-8716-fab5932ec73c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ebb8bab4-a579-41ca-b42b-bf1bdb9b52f9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ff39de05-0b97-4c98-b013-9cee276774cf"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "ImportTemplates",
                keyColumn: "ImportTemplateId",
                keyValue: new Guid("f642096e-6573-4deb-96be-efba9016499c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 601, DateTimeKind.Utc).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("06226032-0cd7-406c-ae33-90aa2061e045"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("069215d0-7731-4751-90f3-4e4e98cf676c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("0a7eea23-0537-408e-935a-36e89ea0db6c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("147f2b53-72cb-4bbb-adbf-14e036c97814"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("17e934ca-2006-4624-b82e-673755e4a0e2"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("1c13a7f0-7256-4765-abca-2d7d636e16f5"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("1ca9a32c-64e3-49cb-91ef-7956d3962deb"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("216effe9-7e8e-497f-8aa2-8e58c4f07e62"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("27b590d4-41d5-4bdd-b593-084bd7756cba"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("31880754-8033-41c7-8886-e152fb80043c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("442b688c-8329-418c-8f84-b77a0b61dfa0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("4e01f919-f0a8-47a3-aa32-7140597a640f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("4f8a8b62-6d95-4854-8add-fc31e0a6a50f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("5217de79-f7ee-4a30-9d2c-9227a0b47941"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("567b5a46-7b17-4a1e-832e-f009fab60ef8"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("62846f42-1c01-4b2c-bca1-118dcc5cb7c1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("6495197d-b80d-4358-9c2c-4e52779614f0"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("67a77698-15bb-4b79-b6a5-e053d9a3fa2f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("6cc18b28-9390-4837-a181-0444810515e7"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("6cd73668-eb60-4d7b-94be-d2247f8ea4cc"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("6dcb4fb2-f386-4950-ac00-112b7a2dda36"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("819bd791-b27c-403f-97b9-899d73ca2060"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("857fd6c8-e83f-4155-8909-64de3f18f566"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("8bae9b31-420c-475d-bdf8-e1c259a62546"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("8fe3ef95-7cbc-40e6-9772-432d2e0dfca2"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("97730458-05ef-4e84-9e9f-d7b3d601976f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("9980d6a7-949c-4375-83c9-186efe3c96e8"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("a4f38fb9-2893-4be0-bba2-a111f053c65f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("b581cb5c-8510-48de-b292-bd02641ec08d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("b8625f27-c65d-448d-ad9f-b60cc7dfd735"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("bf009ba6-7586-4ab9-9597-87502f284a3f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("c13ae2e6-cf8a-4583-8db5-9834bb20fa5a"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Ledgers",
                keyColumn: "LedgerId",
                keyValue: new Guid("d37a4933-756f-4e8a-9c93-d812472178f6"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("04ff391a-26fc-408b-b930-731114e2d994"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("179d1384-e290-4bb7-a52d-038a3221d330"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("3077c60b-5d01-4982-b60e-d032cf75d926"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("45048692-c142-48e4-83b8-fdd7177443c9"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("566195ce-d7a0-4252-8258-8b7b76b7846c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("5ab8de02-7a92-4df0-8ab3-8c3450fd9545"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("66e06ca1-305c-48db-88bc-155b040fc82f"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("85ae154e-960e-4d35-8e77-a9e7d71eddf1"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("cac01b14-67a7-4372-8eb1-5e9a0e8a007c"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("cb84a787-21d3-48eb-96c7-4dc404a8793d"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("ccbd867f-a971-4d3c-b879-2fccb8b92981"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("d1d1f7ac-1609-4537-a965-eb118ce91a5b"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryId",
                keyValue: new Guid("de86efb2-764c-48b0-841a-7e29ecb83640"),
                column: "CreatedOnUtc",
                value: new DateTime(2023, 1, 26, 17, 37, 46, 602, DateTimeKind.Utc).AddTicks(2840));
        }
    }
}
