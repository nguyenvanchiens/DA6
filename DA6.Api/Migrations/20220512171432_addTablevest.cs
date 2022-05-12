using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DA6.Api.Migrations
{
    public partial class addTablevest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vests",
                columns: table => new
                {
                    MaVest = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    MaCL = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    KieuNep = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuVe = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuCo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuTuiNguc = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuTuiSuon = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuTay = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuThanTruoc = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuThanSau = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DaiAo = table.Column<float>(type: "float", nullable: false),
                    VongGau = table.Column<float>(type: "float", nullable: false),
                    VongNguc = table.Column<float>(type: "float", nullable: false),
                    DaiTay = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVai1 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KhoVai1 = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVai2 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KhoVai2 = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVai3 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KhoVai3 = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVaiLot1 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KhoVaiLot1 = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVaiLot2 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KhoVaiLot2 = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVaiLot3 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KhoVaiLot3 = table.Column<float>(type: "float", nullable: false),
                    SoSanPhanTrenSoDo = table.Column<int>(type: "int", nullable: false),
                    SoLaoDongTrenDayTruyen = table.Column<int>(type: "int", nullable: false),
                    MucLuongKyVong = table.Column<float>(type: "float", nullable: false),
                    LoiNhuanDuKien = table.Column<float>(type: "float", nullable: false),
                    PhuPhi = table.Column<float>(type: "float", nullable: false),
                    KhoanPhiKhac = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vests", x => x.MaVest);
                    table.ForeignKey(
                        name: "FK_Vests_ChungLoais_MaCL",
                        column: x => x.MaCL,
                        principalTable: "ChungLoais",
                        principalColumn: "MaCL",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Vests_MaCL",
                table: "Vests",
                column: "MaCL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vests");
        }
    }
}
