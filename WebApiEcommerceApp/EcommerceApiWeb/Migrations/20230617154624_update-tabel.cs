using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceApiWeb.Migrations
{
    public partial class updatetabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "ChiTietDonHang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDonHang = table.Column<int>(type: "int", nullable: false),
                    IdSanPham = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDonHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DonHang",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdUser = table.Column<long>(type: "bigint", nullable: false),
                    NgayMua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TypeNhanHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeThanhToan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaDiemNhanHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaTamTinh = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaDonHang = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdKhoHang = table.Column<long>(type: "bigint", nullable: true),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Modified_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHang", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietDonHang");

            migrationBuilder.DropTable(
                name: "DonHang");

            migrationBuilder.CreateTable(
                name: "ChiTietDatHang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdDonHang = table.Column<int>(type: "int", nullable: false),
                    IdSanPham = table.Column<int>(type: "int", nullable: false),
                    Modified_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Modified_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDatHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DatHang",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Delete_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Delete_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaDiemNhanHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaDonHang = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaTamTinh = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdKhoHang = table.Column<long>(type: "bigint", nullable: true),
                    IdUser = table.Column<long>(type: "bigint", nullable: false),
                    Modified_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Modified_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayMua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeNhanHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeThanhToan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatHang", x => x.Id);
                });
        }
    }
}
