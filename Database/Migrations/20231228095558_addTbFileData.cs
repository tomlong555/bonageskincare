using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class addTbFileData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsVegan",
                table: "TbProduct",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "TbFile",
                columns: new[] { "FileId", "FileName" },
                values: new object[,]
                {
                    { 1, "Resources//BG_main_29_AHA-and-BHA-2__c-max_w-530_h-480_q-100.jpg" },
                    { 2, "main_28_BC2NEW__c-max_w-530_h-480_q-100.jpeg" },
                    { 3, "BG_main_12_BC2-BOX__c-max_w-530_h-480_q-100.jpeg" },
                    { 4, "BG_main_8_Flawless-Facial-Toner-2__c-max_w-530_h-480_q-100.jpg" },
                    { 5, "BG_main_18_bc1-box__c-max_w-530_h-480_q-100.jpeg" },
                    { 6, "BG_main_30_BC3-GOOD__c-max_w-530_h-480_q-100.jpg" },
                    { 7, "BG_main_58_BC3-box__c-max_w-530_h-480_q-100.jpg" },
                    { 8, "main_19_BU6Goldfusioncleansingoil__c-max_w-530_h-480_q-100.jpg" },
                    { 9, "main_65_BC8NEW__c-max_w-530_h-480_q-100.jpg" },
                    { 10, "BG_main_123_BC8-NEW-BOX-2023__c-max_w-530_h-480_q-100.jpg" },
                    { 11, "BG_main_4_BN3__c-max_w-530_h-480_q-100.jpg" },
                    { 12, "BG_main_43_BN3-box__c-max_w-530_h-480_q-100.jpg" },
                    { 13, "BG_main_5_Collagen-Infused-Day-Cream__c-max_w-530_h-480_q-100.jpg" },
                    { 14, "BG_main_60_BN1-box__c-max_w-530_h-480_q-100.jpg" },
                    { 15, "BG_main_6_BN7__c-max_w-530_h-480_q-100.jpg" },
                    { 16, "BG_main_111_BN6-TRANSFORMED-FROM-BN7-BOX-RUTH__c-max_w-530_h-480_q-100.jpeg" },
                    { 17, "BG_main_22_Collage-Restore-Night-Cream-2__c-max_w-530_h-480_q-100.jpg" },
                    { 18, "BG_main_41_BN2-box__c-max_w-530_h-480_q-100.jpg" },
                    { 19, "BG_main_30_BC3-GOOD__c-max_w-530_h-480_q-100-1.jpg" },
                    { 20, "BG_main_58_BC3-box__c-max_w-530_h-480_q-100-1.jpg" },
                    { 21, "BG_main_23_BN5__c-max_w-530_h-480_q-100.jpg" },
                    { 22, "BG_main_61_BN5-box__c-max_w-530_h-480_q-100.jpg" },
                    { 23, "BG_main_24_Moisture-Boost-Eye-Serum__c-max_w-530_h-480_q-100.jpg" },
                    { 24, "BG_main_42_BN4-box__c-max_w-530_h-480_q-100.jpg" },
                    { 25, "BG_main_4_BN3__c-max_w-530_h-480_q-100-1.jpg" },
                    { 26, "BG_main_43_BN3-box__c-max_w-530_h-480_q-100-1.jpg" },
                    { 27, "BG_main_89_Bonage-Laboratories-Wrinkle-Correct__c-max_w-530_h-480_q-100.jpg" },
                    { 28, "BG_main_32_BV1__c-max_w-530_h-480_q-100.jpg" },
                    { 29, "BG_main_54_Flash-Lift-Cream__c-max_w-530_h-480_q-100.jpg" },
                    { 30, "BG_main_50_NEW-BU7-BOX__c-max_w-530_h-480_q-100.jpg" },
                    { 31, "BG_main_102_NEW-BU7-FOR-WEBSITE__c-max_w-530_h-480_q-100.jpg" },
                    { 32, "BG_main_55_BG1-IMAGE-FOR-WEBSITE-GOOD__c-max_w-530_h-480_q-100.jpg" },
                    { 33, "BG_main_36_BG1-box__c-max_w-530_h-480_q-100.jpg" },
                    { 34, "BG_main_101_BG1-HOW-TO-OPEN__c-max_w-530_h-480_q-100.jpeg" },
                    { 35, "BG_main_24_Moisture-Boost-Eye-Serum__c-max_w-530_h-480_q-100-1.jpg" },
                    { 36, "BG_main_42_BN4-box__c-max_w-530_h-480_q-100-1.jpg" },
                    { 37, "BG_main_50_Multi-Action-Instant-Lift-Solution-__c-max_w-530_h-480_q-100.jpg" },
                    { 38, "BG_main_46_-73A5233__c-max_w-530_h-480_q-100.jpg" },
                    { 39, "BG_main_103_BR3-HOW-TO-OPEN__c-max_w-530_h-480_q-100.jpeg" },
                    { 40, "BG_main_39_Sculpting-Eye-Cream-2__c-max_w-530_h-480_q-100.jpg" },
                    { 41, "BG_main_44_BR1-box__c-max_w-530_h-480_q-100.jpg" },
                    { 42, "BG_main_37_Volumizing-Eye-Cream-2__c-max_w-530_h-480_q-100.jpg" }
                });

            migrationBuilder.InsertData(
                table: "TbFile",
                columns: new[] { "FileId", "FileName" },
                values: new object[,]
                {
                    { 43, "BG_main_45_BR2-box__c-max_w-530_h-480_q-100.jpg" },
                    { 44, "BG_main_66_Active-Repair-Beauty-Capsules-2__c-max_w-530_h-480_q-100.jpg" },
                    { 45, "BG_main_57_BU8-box__c-max_w-530_h-480_q-100.jpg" },
                    { 46, "BG_main_112_Capsules4__c-max_w-530_h-480_q-100.jpg" },
                    { 47, "BG_main_113_Capsules5-480-480__c-max_w-530_h-480_q-100.jpg" },
                    { 48, "BG_main_117_BU8-WEBIMAGE1__c-max_w-530_h-480_q-100.jpeg" },
                    { 49, "BG_main_2_Age-Control-Firming-Cream-2__c-max_w-530_h-480_q-100.jpg" },
                    { 50, "BG_main_35_BU3-box__c-max_w-530_h-480_q-100.jpg" },
                    { 51, "BG_main_3_Age-Control-Firming-Serum-2__c-max_w-530_h-480_q-100.jpg" },
                    { 52, "BG_main_49_BU4-box__c-max_w-530_h-480_q-100.jpg" },
                    { 53, "BG_main_18_BU5__c-max_w-530_h-480_q-100.jpg" },
                    { 54, "BG_main_59_BU5-box__c-max_w-530_h-480_q-100.jpg" },
                    { 55, "BG_main_54_Flash-Lift-Cream__c-max_w-530_h-480_q-100-1.jpg" },
                    { 56, "BG_main_50_NEW-BU7-BOX__c-max_w-530_h-480_q-100-1.jpg" },
                    { 57, "BG_main_102_NEW-BU7-FOR-WEBSITE__c-max_w-530_h-480_q-100-1.jpg" },
                    { 58, "main_19_BU6Goldfusioncleansingoil__c-max_w-530_h-480_q-100-1.jpg" },
                    { 59, "BG_main_16_BU1__c-max_w-530_h-480_q-100.jpg" },
                    { 60, "BG_main_47_BU1-box__c-max_w-530_h-480_q-100.jpg" },
                    { 61, "BG_main_17_BU2__c-max_w-530_h-480_q-100.jpg" },
                    { 62, "BG_main_48_BU2-box__c-max_w-530_h-480_q-100.jpg" },
                    { 63, "BG_main_35_75and-HYALURONIC-2__c-max_w-530_h-480_q-100.jpg" },
                    { 64, "BG_main_38_BL2-box__c-max_w-530_h-480_q-100.jpg" },
                    { 65, "BG_main_36_Boosting-Vitamin-Nectar-2__c-max_w-530_h-480_q-100.jpg" },
                    { 66, "BG_main_37_BL1-box__c-max_w-530_h-480_q-100.jpg" },
                    { 67, "BG_main_34_LINE-REDUCING-2__c-max_w-530_h-480_q-100.jpg" },
                    { 68, "BG_main_40_BL4-box__c-max_w-530_h-480_q-100.jpg" },
                    { 69, "BG_main_33_REPAIRING-HYALURONIC-ACID-2__c-max_w-530_h-480_q-100.jpg" },
                    { 70, "BG_main_39_BL3-box__c-max_w-530_h-480_q-100.jpg" },
                    { 71, "BG_main_50_Multi-Action-Instant-Lift-Solution-__c-max_w-530_h-480_q-100-1.jpg" },
                    { 72, "BG_main_46_-73A5233__c-max_w-530_h-480_q-100-1.jpg" },
                    { 73, "BG_main_103_BR3-HOW-TO-OPEN__c-max_w-530_h-480_q-100-1.jpeg" },
                    { 74, "BG_main_39_Sculpting-Eye-Cream-2__c-max_w-530_h-480_q-100-1.jpg" },
                    { 75, "BG_main_44_BR1-box__c-max_w-530_h-480_q-100-1.jpg" },
                    { 76, "BG_main_37_Volumizing-Eye-Cream-2__c-max_w-530_h-480_q-100-1.jpg" },
                    { 77, "BG_main_45_BR2-box__c-max_w-530_h-480_q-100-1.jpg" },
                    { 78, "BG_main_55_BG1-IMAGE-FOR-WEBSITE-GOOD__c-max_w-530_h-480_q-100-1.jpg" },
                    { 79, "BG_main_36_BG1-box__c-max_w-530_h-480_q-100-1.jpg" },
                    { 80, "BG_main_101_BG1-HOW-TO-OPEN__c-max_w-530_h-480_q-100-1.jpeg" },
                    { 81, "main_10_BB1bHydraBoostBodybutter__c-max_w-530_h-480_q-100.jpg" },
                    { 82, "BG_main_133_BONAGE-NAIL-KIT-BB5-NEW-2023-MARCH__c-max_w-530_h-480_q-100.jpg" },
                    { 83, "BG_main_9_main-9-BB1ahydraboostbodybutterb__c-max_w-530_h-480_q-100.jpg" },
                    { 84, "main_7_main7BB2bdualactionsaltscrub__c-max_w-530_h-480_q-100.jpg" }
                });

            migrationBuilder.InsertData(
                table: "TbFile",
                columns: new[] { "FileId", "FileName" },
                values: new object[,]
                {
                    { 85, "BG_main_9_main-9-BB1ahydraboostbodybutterb__c-max_w-288_h-288_q-100.jpg" },
                    { 86, "main_13_handcream1__c-max_w-530_h-480_q-100.jpg" },
                    { 87, "main_13_handcream1__c-max_w-288_h-288_q-100.jpg" },
                    { 88, "main_1_main1BM2AftershaveCalmingcream__c-max_w-530_h-480_q-100.jpg" },
                    { 89, "main_62_Homme__c-max_w-530_h-480_q-100.jpeg" },
                    { 90, "main_20_BM1Mineralrestorefaceandeye__c-max_w-530_h-480_q-100.jpg" },
                    { 91, "main_49_73A9401__c-max_w-530_h-480_q-100.jpg" },
                    { 92, "main_48_73A9377__c-max_w-530_h-480_q-100.jpg" },
                    { 93, "main_43_73A9334__c-max_w-530_h-480_q-100.jpg" },
                    { 94, "main_42_73A9332__c-max_w-530_h-480_q-100.jpg" },
                    { 95, "main_41_73A9337__c-max_w-530_h-480_q-100.jpg" },
                    { 96, "main_40_73A9316__c-max_w-530_h-480_q-100.jpg" },
                    { 97, "main_45_73A9340__c-max_w-530_h-480_q-100.jpg" },
                    { 98, "main_44_73A9352__c-max_w-530_h-480_q-100.jpg" },
                    { 99, "main_47_73A9369__c-max_w-530_h-480_q-100.jpg" },
                    { 100, "main_46_73A9363__c-max_w-530_h-480_q-100.jpg" },
                    { 101, "main_62_Homme__c-max_w-530_h-480_q-1001.jpeg" },
                    { 102, "BG_main_133_BONAGE-NAIL-KIT-BB5-NEW-2023-MARCH__c-max_w-530_h-480_q-1001.jpg" },
                    { 103, "BG_main_64_EYE-AND-NECK-2__c-max_w-530_h-480_q-100.jpeg" },
                    { 104, "BG_main_93_EYE-AND-NECK-1__c-max_w-530_h-480_q-100.jpeg" },
                    { 105, "BG_main_63_RESIZED-FOR-WEBSITE-1__c-max_w-530_h-480_q-100.jpeg" },
                    { 106, "BG_main_89_FACE-EYE-and-NECK-DEVICE-5__c-max_w-530_h-480_q-100.jpeg" },
                    { 107, "BG_main_90_FACE-EYE-and-NECK-DEVICE-6__c-max_w-530_h-480_q-100.jpeg" },
                    { 108, "main_61_WEBWHITENEW__c-max_w-530_h-480_q-100.jpeg" },
                    { 109, "main_58_WEBGREYNEW__c-max_w-530_h-480_q-100.jpeg" },
                    { 110, "main_57_WEBPINKNEW__c-max_w-530_h-480_q-100.jpeg" }
                });

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
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 9, 55, 57, 893, DateTimeKind.Utc).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 9, 55, 57, 893, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2023, 12, 28, 9, 55, 57, 893, DateTimeKind.Utc).AddTicks(449));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "TbFile",
                keyColumn: "FileId",
                keyValue: 110);

            migrationBuilder.DropColumn(
                name: "IsVegan",
                table: "TbProduct");

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 12, 27, 15, 13, 44, 322, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 12, 27, 15, 13, 44, 322, DateTimeKind.Utc).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 12, 27, 15, 13, 44, 322, DateTimeKind.Utc).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 12, 27, 15, 13, 44, 322, DateTimeKind.Utc).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 12, 27, 15, 13, 44, 322, DateTimeKind.Utc).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 12, 27, 15, 13, 44, 322, DateTimeKind.Utc).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 12, 27, 15, 13, 44, 322, DateTimeKind.Utc).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 12, 27, 15, 13, 44, 322, DateTimeKind.Utc).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 12, 27, 15, 13, 44, 322, DateTimeKind.Utc).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 12, 27, 15, 13, 44, 322, DateTimeKind.Utc).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "TbProductGroup",
                keyColumn: "ProductGroupId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2023, 12, 27, 15, 13, 44, 322, DateTimeKind.Utc).AddTicks(2609));
        }
    }
}
