using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceApiWeb.Migrations
{
    public partial class REMOVE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropTable(
                name: "ChiTietGioHang");

            migrationBuilder.DropTable(
                name: "PhienMuaSam");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChiTietGioHang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdGioHang = table.Column<int>(type: "int", nullable: false),
                    IdSanPham = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietGioHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhienMuaSam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Modified_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total = table.Column<double>(type: "float", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhienMuaSam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdChiTietGioHang = table.Column<int>(type: "int", nullable: false),
                    IdPhienMuaSam = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Modified_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GioHang_ChiTietGioHang_IdChiTietGioHang",
                        column: x => x.IdChiTietGioHang,
                        principalTable: "ChiTietGioHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GioHang_PhienMuaSam_IdPhienMuaSam",
                        column: x => x.IdPhienMuaSam,
                        principalTable: "PhienMuaSam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_IdChiTietGioHang",
                table: "GioHang",
                column: "IdChiTietGioHang");

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_IdPhienMuaSam",
                table: "GioHang",
                column: "IdPhienMuaSam");
        }
    }
}
