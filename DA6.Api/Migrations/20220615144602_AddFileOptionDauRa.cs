using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DA6.Api.Migrations
{
    public partial class AddFileOptionDauRa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "dauras");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "optiondauras",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "optiondauras");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "dauras",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
