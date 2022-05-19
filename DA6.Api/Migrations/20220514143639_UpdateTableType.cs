using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DA6.Api.Migrations
{
    public partial class UpdateTableType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ThanhPhanVais",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ThanhPhanVais",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "ThanhPhanVais",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "ThanhPhanVais",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "KieuXes",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "KieuXes",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "KieuXes",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "KieuXes",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "KieuTuiTruocs",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "KieuTuiTruocs",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "KieuTuiTruocs",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "KieuTuiTruocs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "KieuTuiSaus",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "KieuTuiSaus",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "KieuTuiSaus",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "KieuTuiSaus",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "KieuTuis",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "KieuTuis",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "KieuTuis",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "KieuTuis",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "KieuTuiGois",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "KieuTuiGois",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "KieuTuiGois",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "KieuTuiGois",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "KieuThanTruocs",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "KieuThanTruocs",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "KieuThanTruocs",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "KieuThanTruocs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "KieuThanSaus",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "KieuThanSaus",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "KieuThanSaus",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "KieuThanSaus",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "KieuTays",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "KieuTays",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "KieuTays",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "KieuTays",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "KieuQuans",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "KieuQuans",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "KieuQuans",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "KieuQuans",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "KieuNeps",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "KieuNeps",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "KieuNeps",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "KieuNeps",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "KieuGaus",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "KieuGaus",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "KieuGaus",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "KieuGaus",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "KieuCuaTays",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "KieuCuaTays",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "KieuCuaTays",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "KieuCuaTays",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "KieuCuaQuans",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "KieuCuaQuans",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "KieuCuaQuans",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "KieuCuaQuans",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "KieuCos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "KieuCos",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "KieuCos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "KieuCos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "KieuCaps",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "KieuCaps",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "KieuCaps",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "KieuCaps",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "DaiQuans",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "DaiQuans",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "DaiQuans",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "DaiQuans",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ThanhPhanVais");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ThanhPhanVais");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "ThanhPhanVais");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "ThanhPhanVais");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "KieuXes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "KieuXes");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "KieuXes");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "KieuXes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "KieuTuiTruocs");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "KieuTuiTruocs");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "KieuTuiTruocs");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "KieuTuiTruocs");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "KieuTuiSaus");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "KieuTuiSaus");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "KieuTuiSaus");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "KieuTuiSaus");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "KieuTuis");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "KieuTuis");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "KieuTuis");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "KieuTuis");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "KieuTuiGois");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "KieuTuiGois");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "KieuTuiGois");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "KieuTuiGois");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "KieuThanTruocs");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "KieuThanTruocs");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "KieuThanTruocs");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "KieuThanTruocs");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "KieuThanSaus");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "KieuThanSaus");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "KieuThanSaus");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "KieuThanSaus");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "KieuTays");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "KieuTays");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "KieuTays");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "KieuTays");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "KieuQuans");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "KieuQuans");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "KieuQuans");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "KieuQuans");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "KieuNeps");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "KieuNeps");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "KieuNeps");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "KieuNeps");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "KieuGaus");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "KieuGaus");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "KieuGaus");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "KieuGaus");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "KieuCuaTays");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "KieuCuaTays");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "KieuCuaTays");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "KieuCuaTays");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "KieuCuaQuans");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "KieuCuaQuans");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "KieuCuaQuans");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "KieuCuaQuans");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "KieuCos");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "KieuCos");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "KieuCos");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "KieuCos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "KieuCaps");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "KieuCaps");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "KieuCaps");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "KieuCaps");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "DaiQuans");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "DaiQuans");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "DaiQuans");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "DaiQuans");
        }
    }
}
