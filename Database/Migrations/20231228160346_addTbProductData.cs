using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class addTbProductData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 3, 45, 971, DateTimeKind.Utc).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 3, 45, 971, DateTimeKind.Utc).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 3, 45, 971, DateTimeKind.Utc).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 3, 45, 971, DateTimeKind.Utc).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 3, 45, 971, DateTimeKind.Utc).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 3, 45, 971, DateTimeKind.Utc).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 3, 45, 971, DateTimeKind.Utc).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 3, 45, 971, DateTimeKind.Utc).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 3, 45, 971, DateTimeKind.Utc).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 3, 45, 971, DateTimeKind.Utc).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 3, 45, 971, DateTimeKind.Utc).AddTicks(4305));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 3, 33, 447, DateTimeKind.Utc).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 3, 33, 447, DateTimeKind.Utc).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 3, 33, 447, DateTimeKind.Utc).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 3, 33, 447, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 3, 33, 447, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 3, 33, 447, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 3, 33, 447, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 3, 33, 447, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 3, 33, 447, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 3, 33, 447, DateTimeKind.Utc).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 3, 33, 447, DateTimeKind.Utc).AddTicks(843));
        }
    }
}
