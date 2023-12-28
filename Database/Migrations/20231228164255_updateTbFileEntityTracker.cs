using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class updateTbFileEntityTracker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "TbFile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TbFile",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TbFile",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 42, 54, 330, DateTimeKind.Utc).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 42, 54, 330, DateTimeKind.Utc).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 42, 54, 330, DateTimeKind.Utc).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 42, 54, 330, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 42, 54, 330, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 42, 54, 330, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 42, 54, 330, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 42, 54, 330, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 42, 54, 330, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 42, 54, 330, DateTimeKind.Utc).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 42, 54, 330, DateTimeKind.Utc).AddTicks(5825));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "TbFile");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TbFile");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TbFile");

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 21, 37, 899, DateTimeKind.Utc).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 21, 37, 899, DateTimeKind.Utc).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 21, 37, 899, DateTimeKind.Utc).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 21, 37, 899, DateTimeKind.Utc).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 21, 37, 899, DateTimeKind.Utc).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 21, 37, 899, DateTimeKind.Utc).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 21, 37, 899, DateTimeKind.Utc).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 21, 37, 899, DateTimeKind.Utc).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 21, 37, 899, DateTimeKind.Utc).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 21, 37, 899, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 16, 21, 37, 899, DateTimeKind.Utc).AddTicks(8850));
        }
    }
}
