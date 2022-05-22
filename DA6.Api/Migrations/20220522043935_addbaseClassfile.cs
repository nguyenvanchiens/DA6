using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DA6.Api.Migrations
{
    public partial class addbaseClassfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "files",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "files",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "files",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "files",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "files");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "files");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "files");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "files");
        }
    }
}
