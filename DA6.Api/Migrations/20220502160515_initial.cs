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
                name: "ChungLoais",
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
                    table.PrimaryKey("PK_ChungLoais", x => x.MaCL);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KieuCos",
                columns: table => new
                {
                    MaKieuCo = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenKieuCo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuCos", x => x.MaKieuCo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KieuCuaTays",
                columns: table => new
                {
                    MaKieuCuaTay = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenKieuCuaTay = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuCuaTays", x => x.MaKieuCuaTay);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KieuGaus",
                columns: table => new
                {
                    MaKieuGau = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenKieuGau = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuGaus", x => x.MaKieuGau);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KieuNeps",
                columns: table => new
                {
                    MaKieuNep = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenKieuNep = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuNeps", x => x.MaKieuNep);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KieuTays",
                columns: table => new
                {
                    MaKieuTay = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenKieu = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuTays", x => x.MaKieuTay);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KieuThanSaus",
                columns: table => new
                {
                    MaKieuThanSau = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenKieuThanSau = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuThanSaus", x => x.MaKieuThanSau);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KieuThanTruocs",
                columns: table => new
                {
                    MaKieuThanTruoc = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenKieuThanTruoc = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuThanTruocs", x => x.MaKieuThanTruoc);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KieuTuis",
                columns: table => new
                {
                    MaKieuTui = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenKieuTui = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuTuis", x => x.MaKieuTui);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KieuXes",
                columns: table => new
                {
                    MaKieuXe = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenKieuXe = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuXes", x => x.MaKieuXe);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LoaiTrangPhucs",
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
                    table.PrimaryKey("PK_LoaiTrangPhucs", x => x.MaTP);
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
                name: "NguoiDung",
                columns: table => new
                {
                    NguoiDungId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TenNguoiDung = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TaiKhoan = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MatKhau = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SoDienThoai = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Quyen = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.NguoiDungId);
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
                name: "ThanhPhanVais",
                columns: table => new
                {
                    MaThanhPhanVai = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenThanhPhanVai = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanhPhanVais", x => x.MaThanhPhanVai);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Aos",
                columns: table => new
                {
                    MaA = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    MaCL = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    KieuTay = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuCuaTay = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuGau = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuCo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuTui = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuNep = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuThanTruoc = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuXe = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KieuThanSau = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DaiAo = table.Column<float>(type: "float", nullable: false),
                    DaiTay = table.Column<float>(type: "float", nullable: false),
                    VongNguc = table.Column<float>(type: "float", nullable: false),
                    VongMong = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVai1 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TrongLuongVai1 = table.Column<float>(type: "float", nullable: false),
                    KhoVai1 = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVai2 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TrongLuongVai2 = table.Column<float>(type: "float", nullable: false),
                    KhoVai2 = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVai3 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                    table.PrimaryKey("PK_Aos", x => x.MaA);
                    table.ForeignKey(
                        name: "FK_Aos_ChungLoais_MaCL",
                        column: x => x.MaCL,
                        principalTable: "ChungLoais",
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
                    ThanhPhanVaiChinh1 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KhoVaiChinh1 = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVaiChinh2 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KhoVaiChinh2 = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVaiChinh3 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KhoVaiChinh3 = table.Column<float>(type: "float", nullable: false),
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
                    table.PrimaryKey("PK_JacKets", x => x.MaJket);
                    table.ForeignKey(
                        name: "FK_JacKets_ChungLoais_MaCL",
                        column: x => x.MaCL,
                        principalTable: "ChungLoais",
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
                    table.PrimaryKey("PK_Quans", x => x.MaQuan);
                    table.ForeignKey(
                        name: "FK_Quans_ChungLoais_MaCL",
                        column: x => x.MaCL,
                        principalTable: "ChungLoais",
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
                    ThanhPhanVai1MaThanhPhanVai = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KhoVai1 = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVai2MaThanhPhanVai = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KhoVai2 = table.Column<float>(type: "float", nullable: false),
                    ThanhPhanVai3MaThanhPhanVai = table.Column<string>(type: "varchar(255)", nullable: true)
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
                name: "IX_Aos_ChungLoaiMaCL",
                table: "Aos",
                column: "MaCL");

            migrationBuilder.CreateIndex(
                name: "IX_JacKets_ChungLoaiMaCL",
                table: "JacKets",
                column: "MaCL");

            migrationBuilder.CreateIndex(
                name: "IX_Quans_ChungLoaiMaCL",
                table: "Quans",
                column: "MaCL");

            migrationBuilder.CreateIndex(
                name: "IX_Vests_ChungLoaiMaCL",
                table: "Vests",
                column: "MaCL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aos");

            migrationBuilder.DropTable(
                name: "JacKets");

            migrationBuilder.DropTable(
                name: "KieuCos");

            migrationBuilder.DropTable(
                name: "KieuCuaTays");

            migrationBuilder.DropTable(
                name: "KieuGaus");

            migrationBuilder.DropTable(
                name: "KieuNeps");

            migrationBuilder.DropTable(
                name: "KieuTays");

            migrationBuilder.DropTable(
                name: "KieuThanSaus");

            migrationBuilder.DropTable(
                name: "KieuThanTruocs");

            migrationBuilder.DropTable(
                name: "KieuTuis");

            migrationBuilder.DropTable(
                name: "KieuXes");

            migrationBuilder.DropTable(
                name: "LoaiTrangPhucs");

            migrationBuilder.DropTable(
                name: "LoaiVais");

            migrationBuilder.DropTable(
                name: "NguoiDung");

            migrationBuilder.DropTable(
                name: "Quans");

            migrationBuilder.DropTable(
                name: "QuyTrinhChiTiets");

            migrationBuilder.DropTable(
                name: "QuyTrinhSanPhams");

            migrationBuilder.DropTable(
                name: "Vests");

            migrationBuilder.DropTable(
                name: "ChungLoais");

            migrationBuilder.DropTable(
                name: "ThanhPhanVais");
        }
    }
}
