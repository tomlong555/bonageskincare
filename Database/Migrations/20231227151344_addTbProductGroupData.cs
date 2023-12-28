using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class addTbProductGroupData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TbProductGroup",
                columns: new[] { "ProductGroupId", "CreateDate", "IsDeleted", "ProductGroupName", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 27, 15, 13, 44, 322, DateTimeKind.Utc).AddTicks(2600), false, "FLAWLESS CLEANSING", null },
                    { 2, new DateTime(2023, 12, 27, 15, 13, 44, 322, DateTimeKind.Utc).AddTicks(2604), false, "CLASSIQUE", null },
                    { 3, new DateTime(2023, 12, 27, 15, 13, 44, 322, DateTimeKind.Utc).AddTicks(2604), false, "EYE CARE", null },
                    { 4, new DateTime(2023, 12, 27, 15, 13, 44, 322, DateTimeKind.Utc).AddTicks(2605), false, "PRESTIGE", null },
                    { 5, new DateTime(2023, 12, 27, 15, 13, 44, 322, DateTimeKind.Utc).AddTicks(2606), false, "LUMIÉRE", null },
                    { 6, new DateTime(2023, 12, 27, 15, 13, 44, 322, DateTimeKind.Utc).AddTicks(2606), false, "RÉVIVE", null },
                    { 7, new DateTime(2023, 12, 27, 15, 13, 44, 322, DateTimeKind.Utc).AddTicks(2607), false, "GENÉSE", null },
                    { 8, new DateTime(2023, 12, 27, 15, 13, 44, 322, DateTimeKind.Utc).AddTicks(2607), false, "BODY CARE", null },
                    { 10, new DateTime(2023, 12, 27, 15, 13, 44, 322, DateTimeKind.Utc).AddTicks(2608), false, "HOMME", null },
                    { 11, new DateTime(2023, 12, 27, 15, 13, 44, 322, DateTimeKind.Utc).AddTicks(2608), false, "LIMITED EDITION HANDBAGS", null },
                    { 12, new DateTime(2023, 12, 27, 15, 13, 44, 322, DateTimeKind.Utc).AddTicks(2609), false, "SETS & GIFTS", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 12);
        }
    }
}
