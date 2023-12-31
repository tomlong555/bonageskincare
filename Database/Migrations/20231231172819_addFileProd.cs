using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class addFileProd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TbFileProduct",
                columns: new[] { "FileProductId", "FileId", "IsProduct", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, true, 1 },
                    { 2, 2, true, 2 },
                    { 3, 3, false, 2 },
                    { 4, 4, true, 3 },
                    { 5, 5, false, 3 },
                    { 6, 6, true, 4 },
                    { 7, 7, false, 4 },
                    { 8, 8, true, 5 },
                    { 9, 9, true, 6 },
                    { 10, 10, false, 6 },
                    { 11, 11, true, 7 },
                    { 12, 12, false, 7 },
                    { 13, 13, true, 8 },
                    { 14, 14, false, 8 },
                    { 15, 15, true, 9 },
                    { 16, 16, false, 9 },
                    { 17, 17, true, 10 },
                    { 18, 18, false, 10 },
                    { 19, 19, true, 11 },
                    { 20, 20, false, 11 },
                    { 21, 21, true, 12 },
                    { 22, 22, false, 12 },
                    { 23, 23, true, 13 },
                    { 24, 24, false, 13 },
                    { 25, 25, true, 14 },
                    { 26, 26, false, 14 },
                    { 27, 27, true, 15 },
                    { 28, 28, false, 15 },
                    { 29, 29, true, 16 },
                    { 30, 30, false, 16 },
                    { 31, 31, false, 16 },
                    { 32, 32, true, 17 },
                    { 33, 33, false, 17 },
                    { 34, 34, false, 17 },
                    { 35, 35, true, 18 },
                    { 36, 36, false, 18 },
                    { 37, 37, true, 19 },
                    { 38, 38, false, 19 },
                    { 39, 39, false, 19 },
                    { 40, 40, true, 20 },
                    { 41, 41, false, 20 },
                    { 42, 42, true, 21 }
                });

            migrationBuilder.InsertData(
                table: "TbFileProduct",
                columns: new[] { "FileProductId", "FileId", "IsProduct", "ProductId" },
                values: new object[,]
                {
                    { 43, 43, false, 21 },
                    { 44, 44, true, 22 },
                    { 45, 45, false, 22 },
                    { 46, 46, false, 22 },
                    { 47, 47, false, 22 },
                    { 48, 48, false, 22 },
                    { 49, 49, true, 23 },
                    { 50, 50, false, 23 },
                    { 51, 51, true, 24 },
                    { 52, 52, false, 24 },
                    { 53, 53, true, 25 },
                    { 54, 54, false, 25 },
                    { 55, 55, true, 26 },
                    { 56, 56, false, 26 },
                    { 57, 57, false, 26 },
                    { 58, 58, true, 27 },
                    { 59, 59, true, 28 },
                    { 60, 60, false, 28 },
                    { 61, 61, true, 29 },
                    { 62, 62, false, 29 },
                    { 63, 63, true, 30 },
                    { 64, 64, false, 30 },
                    { 65, 65, true, 31 },
                    { 66, 66, false, 31 },
                    { 67, 67, true, 32 },
                    { 68, 68, false, 32 },
                    { 69, 69, true, 33 },
                    { 70, 70, false, 33 },
                    { 71, 71, true, 34 },
                    { 72, 72, false, 34 },
                    { 73, 73, false, 34 },
                    { 74, 74, true, 35 },
                    { 75, 75, false, 35 },
                    { 76, 76, true, 36 },
                    { 77, 77, false, 36 },
                    { 78, 78, true, 37 },
                    { 79, 79, false, 37 },
                    { 80, 80, false, 37 },
                    { 81, 81, true, 38 },
                    { 82, 82, true, 39 },
                    { 83, 83, true, 40 },
                    { 84, 84, true, 41 }
                });

            migrationBuilder.InsertData(
                table: "TbFileProduct",
                columns: new[] { "FileProductId", "FileId", "IsProduct", "ProductId" },
                values: new object[,]
                {
                    { 85, 85, true, 42 },
                    { 86, 86, true, 43 },
                    { 87, 87, true, 44 },
                    { 88, 88, true, 45 },
                    { 89, 89, true, 46 },
                    { 90, 90, true, 47 },
                    { 91, 91, true, 48 },
                    { 92, 92, true, 49 },
                    { 93, 93, true, 50 },
                    { 94, 94, true, 51 },
                    { 95, 95, true, 52 },
                    { 96, 96, true, 53 },
                    { 97, 97, true, 54 },
                    { 98, 98, true, 55 },
                    { 99, 99, true, 56 },
                    { 100, 100, true, 57 },
                    { 101, 101, true, 58 },
                    { 102, 102, true, 59 },
                    { 103, 103, true, 60 },
                    { 104, 104, false, 60 },
                    { 105, 105, true, 61 },
                    { 106, 106, false, 61 },
                    { 107, 107, false, 61 },
                    { 108, 108, true, 62 },
                    { 109, 109, true, 63 },
                    { 110, 110, true, 64 }
                });

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 17, 28, 18, 253, DateTimeKind.Utc).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 17, 28, 18, 253, DateTimeKind.Utc).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 17, 28, 18, 253, DateTimeKind.Utc).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 17, 28, 18, 253, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 17, 28, 18, 253, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 17, 28, 18, 253, DateTimeKind.Utc).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 17, 28, 18, 253, DateTimeKind.Utc).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 17, 28, 18, 253, DateTimeKind.Utc).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 17, 28, 18, 253, DateTimeKind.Utc).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 17, 28, 18, 253, DateTimeKind.Utc).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 17, 28, 18, 253, DateTimeKind.Utc).AddTicks(3223));
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
                value: new DateTime(2023, 12, 31, 17, 27, 51, 425, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 17, 27, 51, 425, DateTimeKind.Utc).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 17, 27, 51, 425, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 17, 27, 51, 425, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 17, 27, 51, 425, DateTimeKind.Utc).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 17, 27, 51, 425, DateTimeKind.Utc).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 17, 27, 51, 425, DateTimeKind.Utc).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 17, 27, 51, 425, DateTimeKind.Utc).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 17, 27, 51, 425, DateTimeKind.Utc).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 17, 27, 51, 425, DateTimeKind.Utc).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 12, 31, 17, 27, 51, 425, DateTimeKind.Utc).AddTicks(9931));
        }
    }
}
