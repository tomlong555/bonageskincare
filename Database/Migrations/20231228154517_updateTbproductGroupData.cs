using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class updateTbproductGroupData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 15, 45, 17, 66, DateTimeKind.Utc).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 15, 45, 17, 66, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 15, 45, 17, 66, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 15, 45, 17, 66, DateTimeKind.Utc).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 15, 45, 17, 66, DateTimeKind.Utc).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 15, 45, 17, 66, DateTimeKind.Utc).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 15, 45, 17, 66, DateTimeKind.Utc).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 15, 45, 17, 66, DateTimeKind.Utc).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 10,
                columns: new[] { "CreateDate", "ProductGroupName" },
                values: new object[] { new DateTime(2023, 12, 28, 15, 45, 17, 66, DateTimeKind.Utc).AddTicks(5839), "LIMITED EDITION HANDBAGS" });

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 11,
                columns: new[] { "CreateDate", "ProductGroupName" },
                values: new object[] { new DateTime(2023, 12, 28, 15, 45, 17, 66, DateTimeKind.Utc).AddTicks(5839), "SETS & GIFTS" });

            migrationBuilder.InsertData(
                table: "TbProductGroup",
                columns: new[] { "ProductGroupId", "CreateDate", "IsDeleted", "ProductGroupName", "UpdateDate" },
                values: new object[] { 9, new DateTime(2023, 12, 28, 15, 45, 17, 66, DateTimeKind.Utc).AddTicks(5838), false, "HOMME", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 9, 55, 57, 893, DateTimeKind.Utc).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 9, 55, 57, 893, DateTimeKind.Utc).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 9, 55, 57, 893, DateTimeKind.Utc).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 9, 55, 57, 893, DateTimeKind.Utc).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 9, 55, 57, 893, DateTimeKind.Utc).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 9, 55, 57, 893, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 9, 55, 57, 893, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 9, 55, 57, 893, DateTimeKind.Utc).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 10,
                columns: new[] { "CreateDate", "ProductGroupName" },
                values: new object[] { new DateTime(2023, 12, 28, 9, 55, 57, 893, DateTimeKind.Utc).AddTicks(447), "HOMME" });

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 11,
                columns: new[] { "CreateDate", "ProductGroupName" },
                values: new object[] { new DateTime(2023, 12, 28, 9, 55, 57, 893, DateTimeKind.Utc).AddTicks(448), "LIMITED EDITION HANDBAGS" });

            migrationBuilder.InsertData(
                table: "TbProductGroup",
                columns: new[] { "ProductGroupId", "CreateDate", "IsDeleted", "ProductGroupName", "UpdateDate" },
                values: new object[] { 12, new DateTime(2023, 12, 28, 9, 55, 57, 893, DateTimeKind.Utc).AddTicks(449), false, "SETS & GIFTS", null });
        }
    }
}
