using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class updateEntityTrack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "TbUser");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TbUser");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "TbProductGroup");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TbProductGroup");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "TbProduct");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TbProduct");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "TbContent");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TbContent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreateBy",
                table: "TbUser",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdateBy",
                table: "TbUser",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreateBy",
                table: "TbProductGroup",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdateBy",
                table: "TbProductGroup",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreateBy",
                table: "TbProduct",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdateBy",
                table: "TbProduct",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreateBy",
                table: "TbContent",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdateBy",
                table: "TbContent",
                type: "int",
                nullable: true);
        }
    }
}
