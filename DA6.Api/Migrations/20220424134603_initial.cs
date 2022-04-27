using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DA6.Api.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChungLoai",
                columns: table => new
                {
                    MaCL = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Ten = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MoTa = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kieu = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChungLoai", x => x.MaCL);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LoaiTrangPhuc",
                columns: table => new
                {
                    MaTP = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Ten = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: true),
                    MoTa = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: true),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiTrangPhuc", x => x.MaTP);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LoaiVais",
                columns: table => new
                {
                    MaVai = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TenVai = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ThanhPhan = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ChucNang = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MoTa = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiVais", x => x.MaVai);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "QuyTrinhChiTiets",
                columns: table => new
                {
                    MaQuyTrinhChiTiet = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    STT = table.Column<int>(type: "int", nullable: false),
                    NoiDungBuoc = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ThietBi = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BacTho = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ThoiGianCheTao = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<float>(type: "float", nullable: false),
                    GhiChu = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuyTrinhChiTiets", x => x.MaQuyTrinhChiTiet);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "QuyTrinhSanPhams",
                columns: table => new
                {
                    MaQuyTrinhSanPham = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    STT = table.Column<int>(type: "int", nullable: false),
                    MaSanPham = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TenQuyTrinh = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuyTrinhSanPhams", x => x.MaQuyTrinhSanPham);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ao",
                columns: table => new
                {
                    MaA = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    MaCL = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    KieuTay = table.Column<int>(type: "int", nullable: false),
                    KieuCuaTay = table.Column<int>(type: "int", nullable: false),
                    KieuGau = table.Column<int>(type: "int", nullable: false),
                    KieuCo = table.Column<int>(type: "int", nullable: false),
                    KieuTui = table.Column<int>(type: "int", nullable: false),
                    KieuNep = table.Column<int>(type: "int", nullable: false),
                    KieuThanTruoc = table.Column<int>(type: "int", nullable: false),
                    KieuXe = table.Column<int>(type: "int", nullable: false),
                    KieuThanSau = table.Column<int>(type: "int", nullable: false),
                    DaiAo = table.Column<float>(type: "float", nullable: false),
                    DaiTay = table.Column<float>(type: "float", nullable: false),
                    VongNguc = table.Column<float>(type: "float", nullable: false),
                    VongMong = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVai1 = table.Column<int>(type: "int", nullable: false),
                    TrongLuongVai1 = table.Column<float>(type: "float", nullable: false),
                    KhoVai1 = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVai2 = table.Column<int>(type: "int", nullable: false),
                    TrongLuongVai2 = table.Column<float>(type: "float", nullable: false),
                    KhoVai2 = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVai3 = table.Column<int>(type: "int", nullable: false),
                    TrongLuongVai3 = table.Column<float>(type: "float", nullable: false),
                    KhoVai3 = table.Column<float>(type: "float", nullable: false),
                    SoSanPhanTrenSoDo = table.Column<int>(type: "int", nullable: false),
                    SoLaoDongTrenDayTruyen = table.Column<int>(type: "int", nullable: false),
                    MucLuongKyVong = table.Column<float>(type: "float", nullable: false),
                    LoiNhuanDuKien = table.Column<float>(type: "float", nullable: false),
                    PhuPhi = table.Column<float>(type: "float", nullable: false),
                    KhoanPhiKhac = table.Column<float>(type: "float", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ao", x => x.MaA);
                    table.ForeignKey(
                        name: "FK_Ao_ChungLoai_MaCL",
                        column: x => x.MaCL,
                        principalTable: "ChungLoai",
                        principalColumn: "MaCL",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "JacKets",
                columns: table => new
                {
                    MaJket = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    MaCL = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Ruot = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuChan = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuGau = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuMu = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuCo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuTuiNguc = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuTuiSuon = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuKhoaNep = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuTay = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuThanTruoc = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DaiAo = table.Column<float>(type: "float", nullable: false),
                    VongNguc = table.Column<float>(type: "float", nullable: false),
                    DaiTay = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVaiChinh1 = table.Column<int>(type: "int", nullable: false),
                    KhoVaiChinh1 = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVaiChinh2 = table.Column<int>(type: "int", nullable: false),
                    KhoVaiChinh2 = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVaiChinh3 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KhoVaiChinh3 = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVaiLot1 = table.Column<int>(type: "int", nullable: false),
                    KhoVaiLot1 = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVaiLot2 = table.Column<int>(type: "int", nullable: false),
                    KhoVaiLot2 = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVaiLot3 = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_JacKets", x => x.MaJket);
                    table.ForeignKey(
                        name: "FK_JacKets_ChungLoai_MaCL",
                        column: x => x.MaCL,
                        principalTable: "ChungLoai",
                        principalColumn: "MaCL",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Quans",
                columns: table => new
                {
                    MaQuan = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    MaCL = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    KieuQuan = table.Column<int>(type: "int", nullable: false),
                    KieuCap = table.Column<int>(type: "int", nullable: false),
                    KieuTuiTruoc = table.Column<int>(type: "int", nullable: false),
                    KieuTuiSau = table.Column<int>(type: "int", nullable: false),
                    KieuTuiGoi = table.Column<int>(type: "int", nullable: false),
                    KieuCuaQuan = table.Column<int>(type: "int", nullable: false),
                    KieuThanTruoc = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuThanSau = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DaiQuan = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VongMong = table.Column<float>(type: "float", nullable: false),
                    VongBung = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVai1 = table.Column<int>(type: "int", nullable: false),
                    KhoVai1 = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVai2 = table.Column<int>(type: "int", nullable: false),
                    KhoVai2 = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVai3 = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Quans", x => x.MaQuan);
                    table.ForeignKey(
                        name: "FK_Quans_ChungLoai_MaCL",
                        column: x => x.MaCL,
                        principalTable: "ChungLoai",
                        principalColumn: "MaCL",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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
                    ThanhPhanVai1 = table.Column<int>(type: "int", nullable: false),
                    KhoVai1 = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVai2 = table.Column<int>(type: "int", nullable: false),
                    KhoVai2 = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVai3 = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Vests_ChungLoai_MaCL",
                        column: x => x.MaCL,
                        principalTable: "ChungLoai",
                        principalColumn: "MaCL",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Ao_MaCL",
                table: "Ao",
                column: "MaCL");

            migrationBuilder.CreateIndex(
                name: "IX_JacKets_MaCL",
                table: "JacKets",
                column: "MaCL");

            migrationBuilder.CreateIndex(
                name: "IX_Quans_MaCL",
                table: "Quans",
                column: "MaCL");

            migrationBuilder.CreateIndex(
                name: "IX_Vests_MaCL",
                table: "Vests",
                column: "MaCL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ao");

            migrationBuilder.DropTable(
                name: "JacKets");

            migrationBuilder.DropTable(
                name: "LoaiTrangPhuc");

            migrationBuilder.DropTable(
                name: "LoaiVais");

            migrationBuilder.DropTable(
                name: "Quans");

            migrationBuilder.DropTable(
                name: "QuyTrinhChiTiets");

            migrationBuilder.DropTable(
                name: "QuyTrinhSanPhams");

            migrationBuilder.DropTable(
                name: "Vests");

            migrationBuilder.DropTable(
                name: "ChungLoai");
        }
    }
}
