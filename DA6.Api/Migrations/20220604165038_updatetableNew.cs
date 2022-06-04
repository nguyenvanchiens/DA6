using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DA6.Api.Migrations
{
    public partial class updatetableNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "quanlydauras");

            migrationBuilder.DropColumn(
                name: "TenPhuThuoc",
                table: "phuthuocs");

            migrationBuilder.DropColumn(
                name: "MaDauRa",
                table: "optiondauras");

            migrationBuilder.DropColumn(
                name: "MaPhuThuoc",
                table: "optiondauras");

            migrationBuilder.DropColumn(
                name: "MaQuanLyDauRa",
                table: "optiondauras");

            migrationBuilder.DropColumn(
                name: "QuanLyDauRaId",
                table: "dauras");

            migrationBuilder.RenameColumn(
                name: "TenOption",
                table: "dauras",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "MaDauRa",
                table: "phuthuocs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaLoaiDauRa",
                table: "phuthuocs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaOptionDaura",
                table: "phuthuocs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "optiondauras",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "MaCL",
                table: "optionaos",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "loaidauras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loaidauras", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "loaidauras");

            migrationBuilder.DropColumn(
                name: "MaDauRa",
                table: "phuthuocs");

            migrationBuilder.DropColumn(
                name: "MaLoaiDauRa",
                table: "phuthuocs");

            migrationBuilder.DropColumn(
                name: "MaOptionDaura",
                table: "phuthuocs");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "optiondauras");

            migrationBuilder.DropColumn(
                name: "MaCL",
                table: "optionaos");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "dauras",
                newName: "TenOption");

            migrationBuilder.AddColumn<string>(
                name: "TenPhuThuoc",
                table: "phuthuocs",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "MaDauRa",
                table: "optiondauras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaPhuThuoc",
                table: "optiondauras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaQuanLyDauRa",
                table: "optiondauras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuanLyDauRaId",
                table: "dauras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "quanlydauras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TenDauRa = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quanlydauras", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
