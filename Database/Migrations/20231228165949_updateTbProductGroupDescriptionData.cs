using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class updateTbProductGroupDescriptionData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TbProductGroup",
                columns: new[] { "ProductGroupId", "CreateDate", "IsDeleted", "ProductGroupDescription", "ProductGroupName", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 28, 16, 59, 48, 921, DateTimeKind.Utc).AddTicks(692), false, "<p>Soothe, tone and clear away impurities with our Flawless Cleansing range-designed to cleanse skin deeply, while still leaving it fully hydrated and silky smooth. Feel refreshed, clean and radiant with a range of products that remove oils, make up, dirt and dead skin. Experience truly purifying results through rich, nourishing ingredients that help you fall back in love with bare-faced beauty.</p>", "FLAWLESS CLEANSING", null },
                    { 2, new DateTime(2023, 12, 28, 16, 59, 48, 921, DateTimeKind.Utc).AddTicks(697), false, "<p>The Classique collection of creams and masks has been formulated using an array of powerful ingredients to help target the signs of ageing, including matrixyl 3000-a solution that visibly reduces wrinkles and improves skin elasticity. The line features not only vitamins and luscious plant extracts, but also collagen, which works to restore the skin’s natural youthful complexion. Users will look and feel classically, effortlessly radiant.</p>", "CLASSIQUE", null },
                    { 3, new DateTime(2023, 12, 28, 16, 59, 48, 921, DateTimeKind.Utc).AddTicks(698), false, "<p>The skin around the eyes is much thinner and less oily than the rest of our face, this is the reason it needs extra care and attention. Our innovative eye care collection is specially formulated for the delicate eye area to keep the eyes as beautiful as they are supposed to be.</p>", "EYE CARE", null },
                    { 4, new DateTime(2023, 12, 28, 16, 59, 48, 921, DateTimeKind.Utc).AddTicks(698), false, "<p>Rich in innovative ingredients that soothe and nourish the skin, the Prestige collection features age-controlling products that reduce the visibility of lines and wrinkles. Prestige masks and serums leave the skin feeling totally refreshed, hydrated and moisturised-perfect for a luxurious spa-like home treatment. Enjoy vibrant, youthful-looking skin with total ease.</p>", "PRESTIGE", null },
                    { 5, new DateTime(2023, 12, 28, 16, 59, 48, 921, DateTimeKind.Utc).AddTicks(699), false, "<p>A luxurious line of smoothing, hydrating and lifting treatments, Lumiere contains active ingredients that specifically target the visible signs of ageing. Hyaluronic acid, the powerful rehydrator, has been blended with matrixyl 3000, the age-defying solution that visibly improves skin tone, elasticity and structure. Lumiere also supplies the skin with natural vitamin combinations, helping to promote a younger and firmer appearance.</p>", "LUMIÉRE", null },
                    { 6, new DateTime(2023, 12, 28, 16, 59, 48, 921, DateTimeKind.Utc).AddTicks(700), false, "<p>The Revive collection combines the latest innovations in eye care technology with active, anti-ageing ingredients that work gently on the delicate eye area. Among its plumping and hydrating ingredients, Revive contains VOLUFORM, the natural alternative for lipofilling. VOLUFORM works through multiple layers of the skin to fill lines and wrinkles and leave skin looking youthful and radiant.</p>", "RÉVIVE", null },
                    { 7, new DateTime(2023, 12, 28, 16, 59, 48, 921, DateTimeKind.Utc).AddTicks(700), false, "", "GENÉSE", null },
                    { 8, new DateTime(2023, 12, 28, 16, 59, 48, 921, DateTimeKind.Utc).AddTicks(701), false, "<p>Bonage offers your whole body the sumptuous feeling of complete cleanliness and natural nourishment. Enhance the skin's natural glow and leave it feeling soft, smooth, and pure all day long.</p>", "BODY CARE", null },
                    { 9, new DateTime(2023, 12, 28, 16, 59, 48, 921, DateTimeKind.Utc).AddTicks(701), false, "<p>Specially created for men, Bonage HOMME is designed to support skin's natural health and hydration. Powerful active ingredients combine with state-of-the-art technology for unique formulas with maximum results.</p>", "HOMME", null },
                    { 10, new DateTime(2023, 12, 28, 16, 59, 48, 921, DateTimeKind.Utc).AddTicks(702), false, "<p>Stand out with Bonage’s beautifully hand crafted, leather bags collection. Designed with the busy women in mind, our leather bags are made to be worn day, night and anywhere in between thanks to the functional details of each handbag. All our handbags are 100% Italian made, inspired by the latest fashion trends and crafted to perfection.</p>", "LIMITED EDITION HANDBAGS", null },
                    { 11, new DateTime(2023, 12, 28, 16, 59, 48, 921, DateTimeKind.Utc).AddTicks(703), false, "", "SETS & GIFTS", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
