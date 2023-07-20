using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceApiWeb.Migrations
{
    public partial class nameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GioHang_ChiTietGioHangs_IdChiTietGioHang",
                table: "GioHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietGioHangs",
                table: "ChiTietGioHangs");

            migrationBuilder.RenameTable(
                name: "ChiTietGioHangs",
                newName: "ChiTietGioHang");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietGioHang",
                table: "ChiTietGioHang",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GioHang_ChiTietGioHang_IdChiTietGioHang",
                table: "GioHang",
                column: "IdChiTietGioHang",
                principalTable: "ChiTietGioHang",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GioHang_ChiTietGioHang_IdChiTietGioHang",
                table: "GioHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietGioHang",
                table: "ChiTietGioHang");

            migrationBuilder.RenameTable(
                name: "ChiTietGioHang",
                newName: "ChiTietGioHangs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietGioHangs",
                table: "ChiTietGioHangs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GioHang_ChiTietGioHangs_IdChiTietGioHang",
                table: "GioHang",
                column: "IdChiTietGioHang",
                principalTable: "ChiTietGioHangs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
