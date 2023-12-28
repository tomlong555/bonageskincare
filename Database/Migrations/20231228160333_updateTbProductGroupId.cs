using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class updateTbProductGroupId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbProduct_TbProductGroup_TbProductGroupProductGroupId",
                table: "TbProduct");

            migrationBuilder.DropIndex(
                name: "IX_TbProduct_TbProductGroupProductGroupId",
                table: "TbProduct");

            migrationBuilder.DropColumn(
                name: "TbProductGroupProductGroupId",
                table: "TbProduct");

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

            migrationBuilder.CreateIndex(
                name: "IX_TbProduct_ProductGroupId",
                table: "TbProduct",
                column: "ProductGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_TbProduct_TbProductGroup_ProductGroupId",
                table: "TbProduct",
                column: "ProductGroupId",
                principalTable: "TbProductGroup",
                principalColumn: "ProductGroupId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbProduct_TbProductGroup_ProductGroupId",
                table: "TbProduct");

            migrationBuilder.DropIndex(
                name: "IX_TbProduct_ProductGroupId",
                table: "TbProduct");

            migrationBuilder.AddColumn<int>(
                name: "TbProductGroupProductGroupId",
                table: "TbProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 15, 50, 56, 51, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 15, 50, 56, 51, DateTimeKind.Utc).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 15, 50, 56, 51, DateTimeKind.Utc).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 15, 50, 56, 51, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 15, 50, 56, 51, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 15, 50, 56, 51, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 15, 50, 56, 51, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 15, 50, 56, 51, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 15, 50, 56, 51, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 15, 50, 56, 51, DateTimeKind.Utc).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 15, 50, 56, 51, DateTimeKind.Utc).AddTicks(4645));

            migrationBuilder.CreateIndex(
                name: "IX_TbProduct_TbProductGroupProductGroupId",
                table: "TbProduct",
                column: "TbProductGroupProductGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_TbProduct_TbProductGroup_TbProductGroupProductGroupId",
                table: "TbProduct",
                column: "TbProductGroupProductGroupId",
                principalTable: "TbProductGroup",
                principalColumn: "ProductGroupId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
