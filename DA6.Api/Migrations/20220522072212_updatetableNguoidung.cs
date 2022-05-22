using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DA6.Api.Migrations
{
    public partial class updatetableNguoidung : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NguoiDung",
                table: "NguoiDung");

            migrationBuilder.RenameTable(
                name: "NguoiDung",
                newName: "nguoidungs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_nguoidungs",
                table: "nguoidungs",
                column: "NguoiDungId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_nguoidungs",
                table: "nguoidungs");

            migrationBuilder.RenameTable(
                name: "nguoidungs",
                newName: "NguoiDung");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NguoiDung",
                table: "NguoiDung",
                column: "NguoiDungId");
        }
    }
}
