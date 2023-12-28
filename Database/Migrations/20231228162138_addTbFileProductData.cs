using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class addTbFileProductData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TbFileProduct",
                columns: new[] { "FileProductId", "FileId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 2 },
                    { 4, 4, 3 },
                    { 5, 5, 3 },
                    { 6, 6, 4 },
                    { 7, 7, 4 },
                    { 8, 8, 5 },
                    { 9, 9, 6 },
                    { 10, 10, 6 },
                    { 11, 11, 7 },
                    { 12, 12, 7 },
                    { 13, 13, 8 },
                    { 14, 14, 8 },
                    { 15, 15, 9 },
                    { 16, 16, 9 },
                    { 17, 17, 10 },
                    { 18, 18, 10 },
                    { 19, 19, 11 },
                    { 20, 20, 11 },
                    { 21, 21, 12 },
                    { 22, 22, 12 },
                    { 23, 23, 13 },
                    { 24, 24, 13 },
                    { 25, 25, 14 },
                    { 26, 26, 14 },
                    { 27, 27, 15 },
                    { 28, 28, 15 },
                    { 29, 29, 16 },
                    { 30, 30, 16 },
                    { 31, 31, 16 },
                    { 32, 32, 17 },
                    { 33, 33, 17 },
                    { 34, 34, 17 },
                    { 35, 35, 18 },
                    { 36, 36, 18 },
                    { 37, 37, 19 },
                    { 38, 38, 19 },
                    { 39, 39, 19 },
                    { 40, 40, 20 },
                    { 41, 41, 20 },
                    { 42, 42, 21 }
                });

            migrationBuilder.InsertData(
                table: "TbFileProduct",
                columns: new[] { "FileProductId", "FileId", "ProductId" },
                values: new object[,]
                {
                    { 43, 43, 21 },
                    { 44, 44, 22 },
                    { 45, 45, 22 },
                    { 46, 46, 22 },
                    { 47, 47, 22 },
                    { 48, 48, 22 },
                    { 49, 49, 23 },
                    { 50, 50, 23 },
                    { 51, 51, 24 },
                    { 52, 52, 24 },
                    { 53, 53, 25 },
                    { 54, 54, 25 },
                    { 55, 55, 26 },
                    { 56, 56, 26 },
                    { 57, 57, 26 },
                    { 58, 58, 27 },
                    { 59, 59, 28 },
                    { 60, 60, 28 },
                    { 61, 61, 29 },
                    { 62, 62, 29 },
                    { 63, 63, 30 },
                    { 64, 64, 30 },
                    { 65, 65, 31 },
                    { 66, 66, 31 },
                    { 67, 67, 32 },
                    { 68, 68, 32 },
                    { 69, 69, 33 },
                    { 70, 70, 33 },
                    { 71, 71, 34 },
                    { 72, 72, 34 },
                    { 73, 73, 34 },
                    { 74, 74, 35 },
                    { 75, 75, 35 },
                    { 76, 76, 36 },
                    { 77, 77, 36 },
                    { 78, 78, 37 },
                    { 79, 79, 37 },
                    { 80, 80, 37 },
                    { 81, 81, 38 },
                    { 82, 82, 39 },
                    { 83, 83, 40 },
                    { 84, 84, 41 }
                });

            migrationBuilder.InsertData(
                table: "TbFileProduct",
                columns: new[] { "FileProductId", "FileId", "ProductId" },
                values: new object[,]
                {
                    { 85, 85, 42 },
                    { 86, 86, 43 },
                    { 87, 87, 44 },
                    { 88, 88, 45 },
                    { 89, 89, 46 },
                    { 90, 90, 47 },
                    { 91, 91, 48 },
                    { 92, 92, 49 },
                    { 93, 93, 50 },
                    { 94, 94, 51 },
                    { 95, 95, 52 },
                    { 96, 96, 53 },
                    { 97, 97, 54 },
                    { 98, 98, 55 },
                    { 99, 99, 56 },
                    { 100, 100, 57 },
                    { 101, 101, 58 },
                    { 102, 102, 59 },
                    { 103, 103, 60 },
                    { 104, 104, 60 },
                    { 105, 105, 61 },
                    { 106, 106, 61 },
                    { 107, 107, 61 },
                    { 108, 108, 62 },
                    { 109, 109, 63 },
                    { 110, 110, 64 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "TbFileProduct",
                keyColumn: "FileProductId",
                keyValue: 110);

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
        }
    }
}
