using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DA6.Api.Migrations
{
    public partial class AddTableOptionAo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ParenId",
                table: "chungloais",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "optionaos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MaAo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MaKieuTay = table.Column<int>(type: "int", nullable: false),
                    MaKieuCuaTay = table.Column<int>(type: "int", nullable: false),
                    MaKieuGau = table.Column<int>(type: "int", nullable: false),
                    MaKieuCo = table.Column<int>(type: "int", nullable: false),
                    MaKieuTui = table.Column<int>(type: "int", nullable: false),
                    MaKieuNep = table.Column<int>(type: "int", nullable: false),
                    MaKieuThanTruoc = table.Column<int>(type: "int", nullable: false),
                    MaKieuXe = table.Column<int>(type: "int", nullable: false),
                    MaKieuThanSau = table.Column<int>(type: "int", nullable: false),
                    MaThanhPhanVai1 = table.Column<int>(type: "int", nullable: false),
                    MaThanhPhanVai2 = table.Column<int>(type: "int", nullable: false),
                    MaThanhPhanVai3 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_optionaos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "optionaos");

            migrationBuilder.UpdateData(
                table: "chungloais",
                keyColumn: "ParenId",
                keyValue: null,
                column: "ParenId",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ParenId",
                table: "chungloais",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
