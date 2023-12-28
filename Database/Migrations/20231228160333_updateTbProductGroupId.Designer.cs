﻿// <auto-generated />
using System;
using Database.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Database.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20231228160333_updateTbProductGroupId")]
    partial class updateTbProductGroupId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Database.Entitys.TbConfiguration", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Key");

                    b.ToTable("TbConfiguration");
                });

            modelBuilder.Entity("Database.Entitys.TbContent", b =>
                {
                    b.Property<int>("ContentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContentId"), 1L, 1);

                    b.Property<string>("ContentBody")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ContentId");

                    b.ToTable("TbContent");
                });

            modelBuilder.Entity("Database.Entitys.TbFile", b =>
                {
                    b.Property<int>("FileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FileId"), 1L, 1);

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FileId");

                    b.ToTable("TbFile");

                    b.HasData(
                        new
                        {
                            FileId = 1,
                            FileName = "Resources//BG_main_29_AHA-and-BHA-2__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 2,
                            FileName = "Resources//main_28_BC2NEW__c-max_w-530_h-480_q-100.jpeg"
                        },
                        new
                        {
                            FileId = 3,
                            FileName = "Resources//BG_main_12_BC2-BOX__c-max_w-530_h-480_q-100.jpeg"
                        },
                        new
                        {
                            FileId = 4,
                            FileName = "Resources//BG_main_8_Flawless-Facial-Toner-2__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 5,
                            FileName = "Resources//BG_main_18_bc1-box__c-max_w-530_h-480_q-100.jpeg"
                        },
                        new
                        {
                            FileId = 6,
                            FileName = "Resources//BG_main_30_BC3-GOOD__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 7,
                            FileName = "Resources//BG_main_58_BC3-box__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 8,
                            FileName = "Resources//main_19_BU6Goldfusioncleansingoil__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 9,
                            FileName = "Resources//main_65_BC8NEW__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 10,
                            FileName = "Resources//BG_main_123_BC8-NEW-BOX-2023__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 11,
                            FileName = "Resources//BG_main_4_BN3__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 12,
                            FileName = "Resources//BG_main_43_BN3-box__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 13,
                            FileName = "Resources//BG_main_5_Collagen-Infused-Day-Cream__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 14,
                            FileName = "Resources//BG_main_60_BN1-box__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 15,
                            FileName = "Resources//BG_main_6_BN7__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 16,
                            FileName = "Resources//BG_main_111_BN6-TRANSFORMED-FROM-BN7-BOX-RUTH__c-max_w-530_h-480_q-100.jpeg"
                        },
                        new
                        {
                            FileId = 17,
                            FileName = "Resources//BG_main_22_Collage-Restore-Night-Cream-2__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 18,
                            FileName = "Resources//BG_main_41_BN2-box__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 19,
                            FileName = "Resources//BG_main_30_BC3-GOOD__c-max_w-530_h-480_q-100-1.jpg"
                        },
                        new
                        {
                            FileId = 20,
                            FileName = "Resources//BG_main_58_BC3-box__c-max_w-530_h-480_q-100-1.jpg"
                        },
                        new
                        {
                            FileId = 21,
                            FileName = "Resources//BG_main_23_BN5__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 22,
                            FileName = "Resources//BG_main_61_BN5-box__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 23,
                            FileName = "Resources//BG_main_24_Moisture-Boost-Eye-Serum__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 24,
                            FileName = "Resources//BG_main_42_BN4-box__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 25,
                            FileName = "Resources//BG_main_4_BN3__c-max_w-530_h-480_q-100-1.jpg"
                        },
                        new
                        {
                            FileId = 26,
                            FileName = "Resources//BG_main_43_BN3-box__c-max_w-530_h-480_q-100-1.jpg"
                        },
                        new
                        {
                            FileId = 27,
                            FileName = "Resources//BG_main_89_Bonage-Laboratories-Wrinkle-Correct__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 28,
                            FileName = "Resources//BG_main_32_BV1__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 29,
                            FileName = "Resources//BG_main_54_Flash-Lift-Cream__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 30,
                            FileName = "Resources//BG_main_50_NEW-BU7-BOX__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 31,
                            FileName = "Resources//BG_main_102_NEW-BU7-FOR-WEBSITE__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 32,
                            FileName = "Resources//BG_main_55_BG1-IMAGE-FOR-WEBSITE-GOOD__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 33,
                            FileName = "Resources//BG_main_36_BG1-box__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 34,
                            FileName = "Resources//BG_main_101_BG1-HOW-TO-OPEN__c-max_w-530_h-480_q-100.jpeg"
                        },
                        new
                        {
                            FileId = 35,
                            FileName = "Resources//BG_main_24_Moisture-Boost-Eye-Serum__c-max_w-530_h-480_q-100-1.jpg"
                        },
                        new
                        {
                            FileId = 36,
                            FileName = "Resources//BG_main_42_BN4-box__c-max_w-530_h-480_q-100-1.jpg"
                        },
                        new
                        {
                            FileId = 37,
                            FileName = "Resources//BG_main_50_Multi-Action-Instant-Lift-Solution-__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 38,
                            FileName = "Resources//BG_main_46_-73A5233__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 39,
                            FileName = "Resources//BG_main_103_BR3-HOW-TO-OPEN__c-max_w-530_h-480_q-100.jpeg"
                        },
                        new
                        {
                            FileId = 40,
                            FileName = "Resources//BG_main_39_Sculpting-Eye-Cream-2__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 41,
                            FileName = "Resources//BG_main_44_BR1-box__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 42,
                            FileName = "Resources//BG_main_37_Volumizing-Eye-Cream-2__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 43,
                            FileName = "Resources//BG_main_45_BR2-box__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 44,
                            FileName = "Resources//BG_main_66_Active-Repair-Beauty-Capsules-2__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 45,
                            FileName = "Resources//BG_main_57_BU8-box__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 46,
                            FileName = "Resources//BG_main_112_Capsules4__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 47,
                            FileName = "Resources//BG_main_113_Capsules5-480-480__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 48,
                            FileName = "Resources//BG_main_117_BU8-WEBIMAGE1__c-max_w-530_h-480_q-100.jpeg"
                        },
                        new
                        {
                            FileId = 49,
                            FileName = "Resources//BG_main_2_Age-Control-Firming-Cream-2__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 50,
                            FileName = "Resources//BG_main_35_BU3-box__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 51,
                            FileName = "Resources//BG_main_3_Age-Control-Firming-Serum-2__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 52,
                            FileName = "Resources//BG_main_49_BU4-box__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 53,
                            FileName = "Resources//BG_main_18_BU5__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 54,
                            FileName = "Resources//BG_main_59_BU5-box__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 55,
                            FileName = "Resources//BG_main_54_Flash-Lift-Cream__c-max_w-530_h-480_q-100-1.jpg"
                        },
                        new
                        {
                            FileId = 56,
                            FileName = "Resources//BG_main_50_NEW-BU7-BOX__c-max_w-530_h-480_q-100-1.jpg"
                        },
                        new
                        {
                            FileId = 57,
                            FileName = "Resources//BG_main_102_NEW-BU7-FOR-WEBSITE__c-max_w-530_h-480_q-100-1.jpg"
                        },
                        new
                        {
                            FileId = 58,
                            FileName = "Resources//main_19_BU6Goldfusioncleansingoil__c-max_w-530_h-480_q-100-1.jpg"
                        },
                        new
                        {
                            FileId = 59,
                            FileName = "Resources//BG_main_16_BU1__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 60,
                            FileName = "Resources//BG_main_47_BU1-box__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 61,
                            FileName = "Resources//BG_main_17_BU2__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 62,
                            FileName = "Resources//BG_main_48_BU2-box__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 63,
                            FileName = "Resources//BG_main_35_75and-HYALURONIC-2__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 64,
                            FileName = "Resources//BG_main_38_BL2-box__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 65,
                            FileName = "Resources//BG_main_36_Boosting-Vitamin-Nectar-2__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 66,
                            FileName = "Resources//BG_main_37_BL1-box__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 67,
                            FileName = "Resources//BG_main_34_LINE-REDUCING-2__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 68,
                            FileName = "Resources//BG_main_40_BL4-box__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 69,
                            FileName = "Resources//BG_main_33_REPAIRING-HYALURONIC-ACID-2__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 70,
                            FileName = "Resources//BG_main_39_BL3-box__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 71,
                            FileName = "Resources//BG_main_50_Multi-Action-Instant-Lift-Solution-__c-max_w-530_h-480_q-100-1.jpg"
                        },
                        new
                        {
                            FileId = 72,
                            FileName = "Resources//BG_main_46_-73A5233__c-max_w-530_h-480_q-100-1.jpg"
                        },
                        new
                        {
                            FileId = 73,
                            FileName = "Resources//BG_main_103_BR3-HOW-TO-OPEN__c-max_w-530_h-480_q-100-1.jpeg"
                        },
                        new
                        {
                            FileId = 74,
                            FileName = "Resources//BG_main_39_Sculpting-Eye-Cream-2__c-max_w-530_h-480_q-100-1.jpg"
                        },
                        new
                        {
                            FileId = 75,
                            FileName = "Resources//BG_main_44_BR1-box__c-max_w-530_h-480_q-100-1.jpg"
                        },
                        new
                        {
                            FileId = 76,
                            FileName = "Resources//BG_main_37_Volumizing-Eye-Cream-2__c-max_w-530_h-480_q-100-1.jpg"
                        },
                        new
                        {
                            FileId = 77,
                            FileName = "Resources//BG_main_45_BR2-box__c-max_w-530_h-480_q-100-1.jpg"
                        },
                        new
                        {
                            FileId = 78,
                            FileName = "Resources//BG_main_55_BG1-IMAGE-FOR-WEBSITE-GOOD__c-max_w-530_h-480_q-100-1.jpg"
                        },
                        new
                        {
                            FileId = 79,
                            FileName = "Resources//BG_main_36_BG1-box__c-max_w-530_h-480_q-100-1.jpg"
                        },
                        new
                        {
                            FileId = 80,
                            FileName = "Resources//BG_main_101_BG1-HOW-TO-OPEN__c-max_w-530_h-480_q-100-1.jpeg"
                        },
                        new
                        {
                            FileId = 81,
                            FileName = "Resources//main_10_BB1bHydraBoostBodybutter__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 82,
                            FileName = "Resources//BG_main_133_BONAGE-NAIL-KIT-BB5-NEW-2023-MARCH__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 83,
                            FileName = "Resources//BG_main_9_main-9-BB1ahydraboostbodybutterb__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 84,
                            FileName = "Resources//main_7_main7BB2bdualactionsaltscrub__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 85,
                            FileName = "Resources//BG_main_9_main-9-BB1ahydraboostbodybutterb__c-max_w-288_h-288_q-100.jpg"
                        },
                        new
                        {
                            FileId = 86,
                            FileName = "Resources//main_13_handcream1__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 87,
                            FileName = "Resources//main_13_handcream1__c-max_w-288_h-288_q-100.jpg"
                        },
                        new
                        {
                            FileId = 88,
                            FileName = "Resources//main_1_main1BM2AftershaveCalmingcream__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 89,
                            FileName = "Resources//main_62_Homme__c-max_w-530_h-480_q-100.jpeg"
                        },
                        new
                        {
                            FileId = 90,
                            FileName = "Resources//main_20_BM1Mineralrestorefaceandeye__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 91,
                            FileName = "Resources//main_49_73A9401__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 92,
                            FileName = "Resources//main_48_73A9377__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 93,
                            FileName = "Resources//main_43_73A9334__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 94,
                            FileName = "Resources//main_42_73A9332__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 95,
                            FileName = "Resources//main_41_73A9337__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 96,
                            FileName = "Resources//main_40_73A9316__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 97,
                            FileName = "Resources//main_45_73A9340__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 98,
                            FileName = "Resources//main_44_73A9352__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 99,
                            FileName = "Resources//main_47_73A9369__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 100,
                            FileName = "Resources//main_46_73A9363__c-max_w-530_h-480_q-100.jpg"
                        },
                        new
                        {
                            FileId = 101,
                            FileName = "Resources//main_62_Homme__c-max_w-530_h-480_q-1001.jpeg"
                        },
                        new
                        {
                            FileId = 102,
                            FileName = "Resources//BG_main_133_BONAGE-NAIL-KIT-BB5-NEW-2023-MARCH__c-max_w-530_h-480_q-1001.jpg"
                        },
                        new
                        {
                            FileId = 103,
                            FileName = "Resources//BG_main_64_EYE-AND-NECK-2__c-max_w-530_h-480_q-100.jpeg"
                        },
                        new
                        {
                            FileId = 104,
                            FileName = "Resources//BG_main_93_EYE-AND-NECK-1__c-max_w-530_h-480_q-100.jpeg"
                        },
                        new
                        {
                            FileId = 105,
                            FileName = "Resources//BG_main_63_RESIZED-FOR-WEBSITE-1__c-max_w-530_h-480_q-100.jpeg"
                        },
                        new
                        {
                            FileId = 106,
                            FileName = "Resources//BG_main_89_FACE-EYE-and-NECK-DEVICE-5__c-max_w-530_h-480_q-100.jpeg"
                        },
                        new
                        {
                            FileId = 107,
                            FileName = "Resources//BG_main_90_FACE-EYE-and-NECK-DEVICE-6__c-max_w-530_h-480_q-100.jpeg"
                        },
                        new
                        {
                            FileId = 108,
                            FileName = "Resources//main_61_WEBWHITENEW__c-max_w-530_h-480_q-100.jpeg"
                        },
                        new
                        {
                            FileId = 109,
                            FileName = "Resources//main_58_WEBGREYNEW__c-max_w-530_h-480_q-100.jpeg"
                        },
                        new
                        {
                            FileId = 110,
                            FileName = "Resources//main_57_WEBPINKNEW__c-max_w-530_h-480_q-100.jpeg"
                        });
                });

            modelBuilder.Entity("Database.Entitys.TbFileProduct", b =>
                {
                    b.Property<int>("FileProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FileProductId"), 1L, 1);

                    b.Property<int>("FileId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("TbFileFileId")
                        .HasColumnType("int");

                    b.Property<int>("TbProductProductId")
                        .HasColumnType("int");

                    b.HasKey("FileProductId");

                    b.HasIndex("TbFileFileId");

                    b.HasIndex("TbProductProductId");

                    b.ToTable("TbFileProduct");
                });

            modelBuilder.Entity("Database.Entitys.TbProduct", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("ContentBody")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentHeader")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPromote")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVegan")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductGroupId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Unit")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId");

                    b.HasIndex("ProductGroupId");

                    b.ToTable("TbProduct");
                });

            modelBuilder.Entity("Database.Entitys.TbProductGroup", b =>
                {
                    b.Property<int>("ProductGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductGroupId"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ProductGroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductGroupId");

                    b.ToTable("TbProductGroup");

                    b.HasData(
                        new
                        {
                            ProductGroupId = 1,
                            CreateDate = new DateTime(2023, 12, 28, 16, 3, 33, 447, DateTimeKind.Utc).AddTicks(819),
                            IsDeleted = false,
                            ProductGroupName = "FLAWLESS CLEANSING"
                        },
                        new
                        {
                            ProductGroupId = 2,
                            CreateDate = new DateTime(2023, 12, 28, 16, 3, 33, 447, DateTimeKind.Utc).AddTicks(833),
                            IsDeleted = false,
                            ProductGroupName = "CLASSIQUE"
                        },
                        new
                        {
                            ProductGroupId = 3,
                            CreateDate = new DateTime(2023, 12, 28, 16, 3, 33, 447, DateTimeKind.Utc).AddTicks(833),
                            IsDeleted = false,
                            ProductGroupName = "EYE CARE"
                        },
                        new
                        {
                            ProductGroupId = 4,
                            CreateDate = new DateTime(2023, 12, 28, 16, 3, 33, 447, DateTimeKind.Utc).AddTicks(834),
                            IsDeleted = false,
                            ProductGroupName = "PRESTIGE"
                        },
                        new
                        {
                            ProductGroupId = 5,
                            CreateDate = new DateTime(2023, 12, 28, 16, 3, 33, 447, DateTimeKind.Utc).AddTicks(834),
                            IsDeleted = false,
                            ProductGroupName = "LUMIÉRE"
                        },
                        new
                        {
                            ProductGroupId = 6,
                            CreateDate = new DateTime(2023, 12, 28, 16, 3, 33, 447, DateTimeKind.Utc).AddTicks(835),
                            IsDeleted = false,
                            ProductGroupName = "RÉVIVE"
                        },
                        new
                        {
                            ProductGroupId = 7,
                            CreateDate = new DateTime(2023, 12, 28, 16, 3, 33, 447, DateTimeKind.Utc).AddTicks(835),
                            IsDeleted = false,
                            ProductGroupName = "GENÉSE"
                        },
                        new
                        {
                            ProductGroupId = 8,
                            CreateDate = new DateTime(2023, 12, 28, 16, 3, 33, 447, DateTimeKind.Utc).AddTicks(837),
                            IsDeleted = false,
                            ProductGroupName = "BODY CARE"
                        },
                        new
                        {
                            ProductGroupId = 9,
                            CreateDate = new DateTime(2023, 12, 28, 16, 3, 33, 447, DateTimeKind.Utc).AddTicks(840),
                            IsDeleted = false,
                            ProductGroupName = "HOMME"
                        },
                        new
                        {
                            ProductGroupId = 10,
                            CreateDate = new DateTime(2023, 12, 28, 16, 3, 33, 447, DateTimeKind.Utc).AddTicks(841),
                            IsDeleted = false,
                            ProductGroupName = "LIMITED EDITION HANDBAGS"
                        },
                        new
                        {
                            ProductGroupId = 11,
                            CreateDate = new DateTime(2023, 12, 28, 16, 3, 33, 447, DateTimeKind.Utc).AddTicks(843),
                            IsDeleted = false,
                            ProductGroupName = "SETS & GIFTS"
                        });
                });

            modelBuilder.Entity("Database.Entitys.TbUser", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("TbUser");
                });

            modelBuilder.Entity("Database.Entitys.TbFileProduct", b =>
                {
                    b.HasOne("Database.Entitys.TbFile", "TbFile")
                        .WithMany("TbFileProducts")
                        .HasForeignKey("TbFileFileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Database.Entitys.TbProduct", "TbProduct")
                        .WithMany("TbFileProducts")
                        .HasForeignKey("TbProductProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TbFile");

                    b.Navigation("TbProduct");
                });

            modelBuilder.Entity("Database.Entitys.TbProduct", b =>
                {
                    b.HasOne("Database.Entitys.TbProductGroup", "TbProductGroup")
                        .WithMany("TbProducts")
                        .HasForeignKey("ProductGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TbProductGroup");
                });

            modelBuilder.Entity("Database.Entitys.TbFile", b =>
                {
                    b.Navigation("TbFileProducts");
                });

            modelBuilder.Entity("Database.Entitys.TbProduct", b =>
                {
                    b.Navigation("TbFileProducts");
                });

            modelBuilder.Entity("Database.Entitys.TbProductGroup", b =>
                {
                    b.Navigation("TbProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
