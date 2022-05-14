using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DA6.Api.Migrations
{
    public partial class refesTableQuan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vests");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vests",
                columns: table => new
                {
                    MaVest = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ChungLoaiMaCL = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DaiAo = table.Column<float>(type: "float", nullable: false),
                    DaiTay = table.Column<float>(type: "float", nullable: false),
                    KhoVai1 = table.Column<float>(type: "float", nullable: false),
                    KhoVai2 = table.Column<float>(type: "float", nullable: false),
                    KhoVai3 = table.Column<float>(type: "float", nullable: false),
                    KhoVaiLot1 = table.Column<float>(type: "float", nullable: false),
                    KhoVaiLot2 = table.Column<float>(type: "float", nullable: false),
                    KhoVaiLot3 = table.Column<float>(type: "float", nullable: false),
                    KhoanPhiKhac = table.Column<float>(type: "float", nullable: false),
                    KieuCo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuNep = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuTay = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuThanSau = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuThanTruoc = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuTuiNguc = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuTuiSuon = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuVe = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoiNhuanDuKien = table.Column<float>(type: "float", nullable: false),
                    MaCL = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    MucLuongKyVong = table.Column<float>(type: "float", nullable: false),
                    PhuPhi = table.Column<float>(type: "float", nullable: false),
                    SoLaoDongTrenDayTruyen = table.Column<int>(type: "int", nullable: false),
                    SoSanPhanTrenSoDo = table.Column<int>(type: "int", nullable: false),
                    ThanhPhanVai1 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ThanhPhanVai2 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ThanhPhanVai3 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ThanhPhanVaiLot1 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ThanhPhanVaiLot2 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ThanhPhanVaiLot3 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VongGau = table.Column<float>(type: "float", nullable: false),
                    VongNguc = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vests", x => x.MaVest);
                    table.ForeignKey(
                        name: "FK_Vests_ChungLoais_ChungLoaiMaCL",
                        column: x => x.ChungLoaiMaCL,
                        principalTable: "ChungLoais",
                        principalColumn: "MaCL",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Vests_ChungLoaiMaCL",
                table: "Vests",
                column: "ChungLoaiMaCL");
        }
    }
}
