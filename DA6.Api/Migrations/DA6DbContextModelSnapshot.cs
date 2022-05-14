﻿// <auto-generated />
using System;
using DA6.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DA6.Api.Migrations
{
    [DbContext(typeof(DA6DbContext))]
    partial class DA6DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DA6.Api.Entities.DaiQuan", b =>
                {
                    b.Property<string>("MaDaiQuan")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("TenDaiQuan")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MaDaiQuan");

                    b.ToTable("DaiQuans");
                });

            modelBuilder.Entity("DA6.Api.Entities.JacKet", b =>
                {
                    b.Property<Guid>("MaJket")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ChungLoaiMaCL")
                        .HasColumnType("char(36)");

                    b.Property<float>("DaiAo")
                        .HasColumnType("float");

                    b.Property<float>("DaiTay")
                        .HasColumnType("float");

                    b.Property<float>("KhoVaiChinh1")
                        .HasColumnType("float");

                    b.Property<float>("KhoVaiChinh2")
                        .HasColumnType("float");

                    b.Property<float>("KhoVaiChinh3")
                        .HasColumnType("float");

                    b.Property<float>("KhoVaiLot1")
                        .HasColumnType("float");

                    b.Property<float>("KhoVaiLot2")
                        .HasColumnType("float");

                    b.Property<float>("KhoVaiLot3")
                        .HasColumnType("float");

                    b.Property<float>("KhoanPhiKhac")
                        .HasColumnType("float");

                    b.Property<string>("KieuChan")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuCo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuGau")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuKhoaNep")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuMu")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuTay")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuThanTruoc")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuTuiNguc")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuTuiSuon")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("LoiNhuanDuKien")
                        .HasColumnType("float");

                    b.Property<Guid>("MaCL")
                        .HasColumnType("char(36)");

                    b.Property<float>("MucLuongKyVong")
                        .HasColumnType("float");

                    b.Property<float>("PhuPhi")
                        .HasColumnType("float");

                    b.Property<string>("Ruot")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SoLaoDongTrenDayTruyen")
                        .HasColumnType("int");

                    b.Property<int>("SoSanPhanTrenSoDo")
                        .HasColumnType("int");

                    b.Property<string>("ThanhPhanVaiChinh1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ThanhPhanVaiChinh2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ThanhPhanVaiChinh3")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ThanhPhanVaiLot1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ThanhPhanVaiLot2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ThanhPhanVaiLot3")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("VongNguc")
                        .HasColumnType("float");

                    b.HasKey("MaJket");

                    b.HasIndex("ChungLoaiMaCL");

                    b.ToTable("JacKets");
                });

            modelBuilder.Entity("DA6.Api.Entities.KieuCap", b =>
                {
                    b.Property<string>("MaKieuCap")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("TenKieuCap")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MaKieuCap");

                    b.ToTable("KieuCaps");
                });

            modelBuilder.Entity("DA6.Api.Entities.KieuCo", b =>
                {
                    b.Property<string>("MaKieuCo")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("TenKieuCo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MaKieuCo");

                    b.ToTable("KieuCos");
                });

            modelBuilder.Entity("DA6.Api.Entities.KieuCuaQuan", b =>
                {
                    b.Property<string>("MaKieuCuaQuan")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("TenKieuCuaQuan")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MaKieuCuaQuan");

                    b.ToTable("KieuCuaQuans");
                });

            modelBuilder.Entity("DA6.Api.Entities.KieuCuaTay", b =>
                {
                    b.Property<string>("MaKieuCuaTay")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("TenKieuCuaTay")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MaKieuCuaTay");

                    b.ToTable("KieuCuaTays");
                });

            modelBuilder.Entity("DA6.Api.Entities.KieuGau", b =>
                {
                    b.Property<string>("MaKieuGau")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("TenKieuGau")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MaKieuGau");

                    b.ToTable("KieuGaus");
                });

            modelBuilder.Entity("DA6.Api.Entities.KieuNep", b =>
                {
                    b.Property<string>("MaKieuNep")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("TenKieuNep")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MaKieuNep");

                    b.ToTable("KieuNeps");
                });

            modelBuilder.Entity("DA6.Api.Entities.KieuQuan", b =>
                {
                    b.Property<string>("MaKieuQuan")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("TenKieuQuan")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MaKieuQuan");

                    b.ToTable("KieuQuans");
                });

            modelBuilder.Entity("DA6.Api.Entities.KieuTay", b =>
                {
                    b.Property<string>("MaKieuTay")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("TenKieu")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MaKieuTay");

                    b.ToTable("KieuTays");
                });

            modelBuilder.Entity("DA6.Api.Entities.KieuThanSau", b =>
                {
                    b.Property<string>("MaKieuThanSau")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("TenKieuThanSau")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MaKieuThanSau");

                    b.ToTable("KieuThanSaus");
                });

            modelBuilder.Entity("DA6.Api.Entities.KieuThanTruoc", b =>
                {
                    b.Property<string>("MaKieuThanTruoc")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("TenKieuThanTruoc")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MaKieuThanTruoc");

                    b.ToTable("KieuThanTruocs");
                });

            modelBuilder.Entity("DA6.Api.Entities.KieuTui", b =>
                {
                    b.Property<string>("MaKieuTui")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("TenKieuTui")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MaKieuTui");

                    b.ToTable("KieuTuis");
                });

            modelBuilder.Entity("DA6.Api.Entities.KieuTuiGoi", b =>
                {
                    b.Property<string>("MaKieuTuiGoi")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("TenKieuTuiGoi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MaKieuTuiGoi");

                    b.ToTable("KieuTuiGois");
                });

            modelBuilder.Entity("DA6.Api.Entities.KieuTuiSau", b =>
                {
                    b.Property<string>("MaKieuTuiSau")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("TenKieuTuiSau")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MaKieuTuiSau");

                    b.ToTable("KieuTuiSaus");
                });

            modelBuilder.Entity("DA6.Api.Entities.KieuTuiTruoc", b =>
                {
                    b.Property<string>("MaKieuTuiTruoc")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("TenKieuTuiTruoc")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MaKieuTuiTruoc");

                    b.ToTable("KieuTuiTruocs");
                });

            modelBuilder.Entity("DA6.Api.Entities.KieuXe", b =>
                {
                    b.Property<string>("MaKieuXe")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("TenKieuXe")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MaKieuXe");

                    b.ToTable("KieuXes");
                });

            modelBuilder.Entity("DA6.Api.Entities.LoaiVai", b =>
                {
                    b.Property<Guid>("MaVai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ChucNang")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TenVai")
                        .HasColumnType("longtext");

                    b.Property<string>("ThanhPhan")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MaVai");

                    b.ToTable("LoaiVais");
                });

            modelBuilder.Entity("DA6.Api.Entities.NguoiDung", b =>
                {
                    b.Property<Guid>("NguoiDungId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Quyen")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TaiKhoan")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TenNguoiDung")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("NguoiDungId");

                    b.ToTable("NguoiDung");
                });

            modelBuilder.Entity("DA6.Api.Entities.Quan", b =>
                {
                    b.Property<Guid>("MaQuan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ChungLoaiMaCL")
                        .HasColumnType("char(36)");

                    b.Property<string>("DaiQuan")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("KhoVai1")
                        .HasColumnType("float");

                    b.Property<float>("KhoVai2")
                        .HasColumnType("float");

                    b.Property<float>("KhoVai3")
                        .HasColumnType("float");

                    b.Property<float>("KhoVaiLot1")
                        .HasColumnType("float");

                    b.Property<float>("KhoVaiLot2")
                        .HasColumnType("float");

                    b.Property<float>("KhoVaiLot3")
                        .HasColumnType("float");

                    b.Property<float>("KhoanPhiKhac")
                        .HasColumnType("float");

                    b.Property<string>("KieuCap")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuCuaQuan")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuQuan")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuThanSau")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuThanTruoc")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuTuiGoi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuTuiSau")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuTuiTruoc")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("LoiNhuanDuKien")
                        .HasColumnType("float");

                    b.Property<Guid>("MaCL")
                        .HasColumnType("char(36)");

                    b.Property<float>("MucLuongKyVong")
                        .HasColumnType("float");

                    b.Property<float>("PhuPhi")
                        .HasColumnType("float");

                    b.Property<int>("SoLaoDongTrenDayTruyen")
                        .HasColumnType("int");

                    b.Property<int>("SoSanPhanTrenSoDo")
                        .HasColumnType("int");

                    b.Property<string>("ThanhPhanVai1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ThanhPhanVai2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ThanhPhanVai3")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ThanhPhanVaiLot1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ThanhPhanVaiLot2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ThanhPhanVaiLot3")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("VongBung")
                        .HasColumnType("float");

                    b.Property<float>("VongMong")
                        .HasColumnType("float");

                    b.HasKey("MaQuan");

                    b.HasIndex("ChungLoaiMaCL");

                    b.ToTable("Quans");
                });

            modelBuilder.Entity("DA6.Api.Entities.QuyTrinhChiTiet", b =>
                {
                    b.Property<Guid>("MaQuyTrinhChiTiet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("BacTho")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("DonGia")
                        .HasColumnType("float");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NoiDungBuoc")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("STT")
                        .HasColumnType("int");

                    b.Property<string>("ThietBi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ThoiGianCheTao")
                        .HasColumnType("int");

                    b.HasKey("MaQuyTrinhChiTiet");

                    b.ToTable("QuyTrinhChiTiets");
                });

            modelBuilder.Entity("DA6.Api.Entities.QuyTrinhSanPham", b =>
                {
                    b.Property<Guid>("MaQuyTrinhSanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("MaSanPham")
                        .HasColumnType("char(36)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("STT")
                        .HasColumnType("int");

                    b.Property<string>("TenQuyTrinh")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MaQuyTrinhSanPham");

                    b.ToTable("QuyTrinhSanPhams");
                });

            modelBuilder.Entity("DA6.Api.Entities.ThanhPhanVai", b =>
                {
                    b.Property<string>("MaThanhPhanVai")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("TenThanhPhanVai")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MaThanhPhanVai");

                    b.ToTable("ThanhPhanVais");
                });

            modelBuilder.Entity("DA6.Api.Entities.Vest", b =>
                {
                    b.Property<Guid>("MaVest")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ChungLoaiMaCL")
                        .HasColumnType("char(36)");

                    b.Property<float>("DaiAo")
                        .HasColumnType("float");

                    b.Property<float>("DaiTay")
                        .HasColumnType("float");

                    b.Property<float>("KhoVai1")
                        .HasColumnType("float");

                    b.Property<float>("KhoVai2")
                        .HasColumnType("float");

                    b.Property<float>("KhoVai3")
                        .HasColumnType("float");

                    b.Property<float>("KhoVaiLot1")
                        .HasColumnType("float");

                    b.Property<float>("KhoVaiLot2")
                        .HasColumnType("float");

                    b.Property<float>("KhoVaiLot3")
                        .HasColumnType("float");

                    b.Property<float>("KhoanPhiKhac")
                        .HasColumnType("float");

                    b.Property<string>("KieuCo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuNep")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuTay")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuThanSau")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuThanTruoc")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuTuiNguc")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuTuiSuon")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuVe")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("LoiNhuanDuKien")
                        .HasColumnType("float");

                    b.Property<Guid>("MaCL")
                        .HasColumnType("char(36)");

                    b.Property<float>("MucLuongKyVong")
                        .HasColumnType("float");

                    b.Property<float>("PhuPhi")
                        .HasColumnType("float");

                    b.Property<int>("SoLaoDongTrenDayTruyen")
                        .HasColumnType("int");

                    b.Property<int>("SoSanPhanTrenSoDo")
                        .HasColumnType("int");

                    b.Property<string>("ThanhPhanVai1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ThanhPhanVai2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ThanhPhanVai3")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ThanhPhanVaiLot1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ThanhPhanVaiLot2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ThanhPhanVaiLot3")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("VongGau")
                        .HasColumnType("float");

                    b.Property<float>("VongNguc")
                        .HasColumnType("float");

                    b.HasKey("MaVest");

                    b.HasIndex("ChungLoaiMaCL");

                    b.ToTable("Vests");
                });

            modelBuilder.Entity("DA6.Core.Entities.Ao", b =>
                {
                    b.Property<Guid>("MaA")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ChungLoaiMaCL")
                        .HasColumnType("char(36)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("DaiAo")
                        .HasColumnType("float");

                    b.Property<float>("DaiTay")
                        .HasColumnType("float");

                    b.Property<float>("KhoVai1")
                        .HasColumnType("float");

                    b.Property<float>("KhoVai2")
                        .HasColumnType("float");

                    b.Property<float>("KhoVai3")
                        .HasColumnType("float");

                    b.Property<float>("KhoanPhiKhac")
                        .HasColumnType("float");

                    b.Property<string>("KieuCo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuCuaTay")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuGau")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuNep")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuTay")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuThanSau")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuThanTruoc")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuTui")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KieuXe")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("LoiNhuanDuKien")
                        .HasColumnType("float");

                    b.Property<Guid>("MaCL")
                        .HasColumnType("char(36)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("MucLuongKyVong")
                        .HasColumnType("float");

                    b.Property<float>("PhuPhi")
                        .HasColumnType("float");

                    b.Property<int>("SoLaoDongTrenDayTruyen")
                        .HasColumnType("int");

                    b.Property<int>("SoSanPhanTrenSoDo")
                        .HasColumnType("int");

                    b.Property<string>("ThanhPhanVai1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ThanhPhanVai2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ThanhPhanVai3")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("TrongLuongVai1")
                        .HasColumnType("float");

                    b.Property<float>("TrongLuongVai2")
                        .HasColumnType("float");

                    b.Property<float>("TrongLuongVai3")
                        .HasColumnType("float");

                    b.Property<float>("VongMong")
                        .HasColumnType("float");

                    b.Property<float>("VongNguc")
                        .HasColumnType("float");

                    b.HasKey("MaA");

                    b.HasIndex("ChungLoaiMaCL");

                    b.ToTable("Aos");
                });

            modelBuilder.Entity("DA6.Core.Entities.ChungLoai", b =>
                {
                    b.Property<Guid>("MaCL")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Kieu")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MoTa")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Ten")
                        .HasColumnType("longtext");

                    b.HasKey("MaCL");

                    b.ToTable("ChungLoais");
                });

            modelBuilder.Entity("DA6.Core.Entities.LoaiTrangPhuc", b =>
                {
                    b.Property<Guid>("MaTP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MoTa")
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR(50)");

                    b.HasKey("MaTP");

                    b.ToTable("LoaiTrangPhucs");
                });

            modelBuilder.Entity("DA6.Api.Entities.JacKet", b =>
                {
                    b.HasOne("DA6.Core.Entities.ChungLoai", "ChungLoai")
                        .WithMany()
                        .HasForeignKey("ChungLoaiMaCL")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChungLoai");
                });

            modelBuilder.Entity("DA6.Api.Entities.Quan", b =>
                {
                    b.HasOne("DA6.Core.Entities.ChungLoai", "ChungLoai")
                        .WithMany()
                        .HasForeignKey("ChungLoaiMaCL")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChungLoai");
                });

            modelBuilder.Entity("DA6.Api.Entities.Vest", b =>
                {
                    b.HasOne("DA6.Core.Entities.ChungLoai", "ChungLoai")
                        .WithMany()
                        .HasForeignKey("ChungLoaiMaCL")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChungLoai");
                });

            modelBuilder.Entity("DA6.Core.Entities.Ao", b =>
                {
                    b.HasOne("DA6.Core.Entities.ChungLoai", "ChungLoai")
                        .WithMany()
                        .HasForeignKey("ChungLoaiMaCL")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChungLoai");
                });
#pragma warning restore 612, 618
        }
    }
}
