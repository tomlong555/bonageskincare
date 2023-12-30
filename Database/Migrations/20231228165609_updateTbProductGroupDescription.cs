using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class updateTbProductGroupDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 11);

            migrationBuilder.AddColumn<string>(
                name: "ProductGroupDescription",
                table: "TbProductGroup",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductGroupDescription",
                table: "TbProductGroup");

            migrationBuilder.InsertData(
                table: "TbProductGroup",
                columns: new[] { "ProductGroupId", "CreateDate", "IsDeleted", "ProductGroupName", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 28, 16, 42, 54, 330, DateTimeKind.Utc).AddTicks(5817), false, "FLAWLESS CLEANSING", null },
                    { 2, new DateTime(2023, 12, 28, 16, 42, 54, 330, DateTimeKind.Utc).AddTicks(5821), false, "CLASSIQUE", null },
                    { 3, new DateTime(2023, 12, 28, 16, 42, 54, 330, DateTimeKind.Utc).AddTicks(5821), false, "EYE CARE", null },
                    { 4, new DateTime(2023, 12, 28, 16, 42, 54, 330, DateTimeKind.Utc).AddTicks(5822), false, "PRESTIGE", null },
                    { 5, new DateTime(2023, 12, 28, 16, 42, 54, 330, DateTimeKind.Utc).AddTicks(5822), false, "LUMIÉRE", null },
                    { 6, new DateTime(2023, 12, 28, 16, 42, 54, 330, DateTimeKind.Utc).AddTicks(5823), false, "RÉVIVE", null },
                    { 7, new DateTime(2023, 12, 28, 16, 42, 54, 330, DateTimeKind.Utc).AddTicks(5823), false, "GENÉSE", null },
                    { 8, new DateTime(2023, 12, 28, 16, 42, 54, 330, DateTimeKind.Utc).AddTicks(5824), false, "BODY CARE", null },
                    { 9, new DateTime(2023, 12, 28, 16, 42, 54, 330, DateTimeKind.Utc).AddTicks(5824), false, "HOMME", null },
                    { 10, new DateTime(2023, 12, 28, 16, 42, 54, 330, DateTimeKind.Utc).AddTicks(5825), false, "LIMITED EDITION HANDBAGS", null },
                    { 11, new DateTime(2023, 12, 28, 16, 42, 54, 330, DateTimeKind.Utc).AddTicks(5825), false, "SETS & GIFTS", null }
                });
        }
    }
}
