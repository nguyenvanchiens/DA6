using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DA6.Api.Migrations
{
    public partial class refeTableQuan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AddColumn<string>(
                name: "ThanhPhanVai1",
                table: "Vests",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ThanhPhanVai2",
                table: "Vests",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ThanhPhanVai3",
                table: "Vests",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "KieuTuiTruoc",
                table: "Quans",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "KieuTuiSau",
                table: "Quans",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "KieuTuiGoi",
                table: "Quans",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "KieuQuan",
                table: "Quans",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "KieuCuaQuan",
                table: "Quans",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "KieuCap",
                table: "Quans",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DaiQuans",
                columns: table => new
                {
                    MaDaiQuan = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenDaiQuan = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaiQuans", x => x.MaDaiQuan);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KieuCaps",
                columns: table => new
                {
                    MaKieuCap = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenKieuCap = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuCaps", x => x.MaKieuCap);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KieuCuaQuans",
                columns: table => new
                {
                    MaKieuCuaQuan = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenKieuCuaQuan = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuCuaQuans", x => x.MaKieuCuaQuan);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KieuQuans",
                columns: table => new
                {
                    MaKieuQuan = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenKieuQuan = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuQuans", x => x.MaKieuQuan);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KieuTuiGois",
                columns: table => new
                {
                    MaKieuTuiGoi = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenKieuTuiGoi = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuTuiGois", x => x.MaKieuTuiGoi);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KieuTuiSaus",
                columns: table => new
                {
                    MaKieuTuiSau = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenKieuTuiSau = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuTuiSaus", x => x.MaKieuTuiSau);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KieuTuiTruocs",
                columns: table => new
                {
                    MaKieuTuiTruoc = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenKieuTuiTruoc = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuTuiTruocs", x => x.MaKieuTuiTruoc);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DaiQuans");

            migrationBuilder.DropTable(
                name: "KieuCaps");

            migrationBuilder.DropTable(
                name: "KieuCuaQuans");

            migrationBuilder.DropTable(
                name: "KieuQuans");

            migrationBuilder.DropTable(
                name: "KieuTuiGois");

            migrationBuilder.DropTable(
                name: "KieuTuiSaus");

            migrationBuilder.DropTable(
                name: "KieuTuiTruocs");

            migrationBuilder.DropColumn(
                name: "ThanhPhanVai1",
                table: "Vests");

            migrationBuilder.DropColumn(
                name: "ThanhPhanVai2",
                table: "Vests");

            migrationBuilder.DropColumn(
                name: "ThanhPhanVai3",
                table: "Vests");

            

            migrationBuilder.AlterColumn<int>(
                name: "KieuTuiTruoc",
                table: "Quans",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "KieuTuiSau",
                table: "Quans",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "KieuTuiGoi",
                table: "Quans",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "KieuQuan",
                table: "Quans",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "KieuCuaQuan",
                table: "Quans",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "KieuCap",
                table: "Quans",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Vests_ThanhPhanVai1MaThanhPhanVai",
                table: "Vests",
                column: "ThanhPhanVai1MaThanhPhanVai");

            migrationBuilder.CreateIndex(
                name: "IX_Vests_ThanhPhanVai2MaThanhPhanVai",
                table: "Vests",
                column: "ThanhPhanVai2MaThanhPhanVai");

            migrationBuilder.CreateIndex(
                name: "IX_Vests_ThanhPhanVai3MaThanhPhanVai",
                table: "Vests",
                column: "ThanhPhanVai3MaThanhPhanVai");

            migrationBuilder.AddForeignKey(
                name: "FK_Vests_ThanhPhanVais_ThanhPhanVai1MaThanhPhanVai",
                table: "Vests",
                column: "ThanhPhanVai1MaThanhPhanVai",
                principalTable: "ThanhPhanVais",
                principalColumn: "MaThanhPhanVai");

            migrationBuilder.AddForeignKey(
                name: "FK_Vests_ThanhPhanVais_ThanhPhanVai2MaThanhPhanVai",
                table: "Vests",
                column: "ThanhPhanVai2MaThanhPhanVai",
                principalTable: "ThanhPhanVais",
                principalColumn: "MaThanhPhanVai");

            migrationBuilder.AddForeignKey(
                name: "FK_Vests_ThanhPhanVais_ThanhPhanVai3MaThanhPhanVai",
                table: "Vests",
                column: "ThanhPhanVai3MaThanhPhanVai",
                principalTable: "ThanhPhanVais",
                principalColumn: "MaThanhPhanVai");
        }
    }
}
