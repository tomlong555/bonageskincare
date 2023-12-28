using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class updateTbFileProduct_fk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbFileProduct_TbFile_TbFileFileId",
                table: "TbFileProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_TbFileProduct_TbProduct_TbProductProductId",
                table: "TbFileProduct");

            migrationBuilder.DropIndex(
                name: "IX_TbFileProduct_TbFileFileId",
                table: "TbFileProduct");

            migrationBuilder.DropIndex(
                name: "IX_TbFileProduct_TbProductProductId",
                table: "TbFileProduct");

            migrationBuilder.DropColumn(
                name: "TbFileFileId",
                table: "TbFileProduct");

            migrationBuilder.DropColumn(
                name: "TbProductProductId",
                table: "TbFileProduct");

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 4, 50, 66, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 4, 50, 66, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 4, 50, 66, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 4, 50, 66, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 4, 50, 66, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 4, 50, 66, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 4, 50, 66, DateTimeKind.Utc).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 4, 50, 66, DateTimeKind.Utc).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 4, 50, 66, DateTimeKind.Utc).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 4, 50, 66, DateTimeKind.Utc).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 4, 50, 66, DateTimeKind.Utc).AddTicks(8104));

            migrationBuilder.CreateIndex(
                name: "IX_TbFileProduct_FileId",
                table: "TbFileProduct",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_TbFileProduct_ProductId",
                table: "TbFileProduct",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_TbFileProduct_TbFile_FileId",
                table: "TbFileProduct",
                column: "FileId",
                principalTable: "TbFile",
                principalColumn: "FileId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TbFileProduct_TbProduct_ProductId",
                table: "TbFileProduct",
                column: "ProductId",
                principalTable: "TbProduct",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbFileProduct_TbFile_FileId",
                table: "TbFileProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_TbFileProduct_TbProduct_ProductId",
                table: "TbFileProduct");

            migrationBuilder.DropIndex(
                name: "IX_TbFileProduct_FileId",
                table: "TbFileProduct");

            migrationBuilder.DropIndex(
                name: "IX_TbFileProduct_ProductId",
                table: "TbFileProduct");

            migrationBuilder.AddColumn<int>(
                name: "TbFileFileId",
                table: "TbFileProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TbProductProductId",
                table: "TbFileProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 4, 7, 621, DateTimeKind.Utc).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 4, 7, 621, DateTimeKind.Utc).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 4, 7, 621, DateTimeKind.Utc).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 4, 7, 621, DateTimeKind.Utc).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 4, 7, 621, DateTimeKind.Utc).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 4, 7, 621, DateTimeKind.Utc).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 4, 7, 621, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 4, 7, 621, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 4, 7, 621, DateTimeKind.Utc).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 4, 7, 621, DateTimeKind.Utc).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 4, 7, 621, DateTimeKind.Utc).AddTicks(125));

            migrationBuilder.CreateIndex(
                name: "IX_TbFileProduct_TbFileFileId",
                table: "TbFileProduct",
                column: "TbFileFileId");

            migrationBuilder.CreateIndex(
                name: "IX_TbFileProduct_TbProductProductId",
                table: "TbFileProduct",
                column: "TbProductProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_TbFileProduct_TbFile_TbFileFileId",
                table: "TbFileProduct",
                column: "TbFileFileId",
                principalTable: "TbFile",
                principalColumn: "FileId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TbFileProduct_TbProduct_TbProductProductId",
                table: "TbFileProduct",
                column: "TbProductProductId",
                principalTable: "TbProduct",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
