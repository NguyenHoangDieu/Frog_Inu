namespace WebApiEcommerceApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietDatHang",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Total = c.Double(nullable: false),
                        IdThanhToan = c.Int(nullable: false),
                        TrangThai = c.Boolean(nullable: false),
                        Created_at = c.DateTime(),
                        Created_by = c.String(maxLength: 50),
                        Modified_at = c.DateTime(),
                        Delete_at = c.DateTime(),
                        Modified_by = c.String(maxLength: 50),
                        Delete_by = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        HoVaTen = c.String(),
                        DienThoai = c.String(),
                        Created_at = c.DateTime(),
                        Created_by = c.String(maxLength: 50),
                        Modified_at = c.DateTime(),
                        Delete_at = c.DateTime(),
                        Modified_by = c.String(maxLength: 50),
                        Delete_by = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ChiTietThanhToan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdChiTietDH = c.Int(nullable: false),
                        SoLuong = c.Int(nullable: false),
                        NhaCungCap = c.String(maxLength: 50),
                        TrangThai = c.String(),
                        Created_at = c.DateTime(),
                        Created_by = c.String(maxLength: 50),
                        Modified_at = c.DateTime(),
                        Delete_at = c.DateTime(),
                        Modified_by = c.String(maxLength: 50),
                        Delete_by = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ChiTietDatHang", t => t.IdChiTietDH, cascadeDelete: true)
                .Index(t => t.IdChiTietDH);
            
            CreateTable(
                "dbo.DanhMucSanPham",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenDanhMuc = c.String(nullable: false, maxLength: 50),
                        MoTa = c.String(),
                        TrangThai = c.Boolean(nullable: false),
                        Created_at = c.DateTime(),
                        Created_by = c.String(maxLength: 50),
                        Modified_at = c.DateTime(),
                        Delete_at = c.DateTime(),
                        Modified_by = c.String(maxLength: 50),
                        Delete_by = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DatHang",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdChiTietDH = c.Int(nullable: false),
                        IdSanPham = c.Int(nullable: false),
                        TrangThai = c.Boolean(nullable: false),
                        Created_at = c.DateTime(),
                        Created_by = c.String(maxLength: 50),
                        Modified_at = c.DateTime(),
                        Delete_at = c.DateTime(),
                        Modified_by = c.String(maxLength: 50),
                        Delete_by = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ChiTietDatHang", t => t.IdChiTietDH, cascadeDelete: true)
                .ForeignKey("dbo.SanPham", t => t.IdSanPham, cascadeDelete: true)
                .Index(t => t.IdChiTietDH)
                .Index(t => t.IdSanPham);
            
            CreateTable(
                "dbo.SanPham",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenSanPham = c.String(nullable: false, maxLength: 250),
                        MoTa = c.String(maxLength: 500),
                        SKU = c.String(maxLength: 50),
                        GiaSanPham = c.Double(nullable: false),
                        TrangThai = c.Boolean(nullable: false),
                        Image = c.String(),
                        MoreImage = c.String(),
                        IdDanhMuc = c.Long(nullable: false),
                        IdKhoHang = c.Long(nullable: false),
                        IdGiamGia = c.Long(nullable: false),
                        Created_at = c.DateTime(),
                        Created_by = c.String(maxLength: 50),
                        Modified_at = c.DateTime(),
                        Delete_at = c.DateTime(),
                        Modified_by = c.String(maxLength: 50),
                        Delete_by = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DiaChiUser",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        DiaChi = c.String(nullable: false),
                        ThanhPho = c.String(),
                        DienThoai = c.String(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.GiamGia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenMaGiamGia = c.String(nullable: false),
                        MoTa = c.String(),
                        PhanTramGiamGia = c.Double(nullable: false),
                        isActive = c.Boolean(nullable: false),
                        Created_at = c.DateTime(),
                        Created_by = c.String(maxLength: 50),
                        Modified_at = c.DateTime(),
                        Delete_at = c.DateTime(),
                        Modified_by = c.String(maxLength: 50),
                        Delete_by = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GioHang",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdPhienMuaSam = c.Int(nullable: false),
                        IdSanPham = c.Int(nullable: false),
                        SoLuong = c.Int(nullable: false),
                        TrangThai = c.Boolean(nullable: false),
                        Created_at = c.DateTime(),
                        Created_by = c.String(maxLength: 50),
                        Modified_at = c.DateTime(),
                        Delete_at = c.DateTime(),
                        Modified_by = c.String(maxLength: 50),
                        Delete_by = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PhienMuaSam", t => t.IdPhienMuaSam, cascadeDelete: true)
                .ForeignKey("dbo.SanPham", t => t.IdSanPham, cascadeDelete: true)
                .Index(t => t.IdPhienMuaSam)
                .Index(t => t.IdSanPham);
            
            CreateTable(
                "dbo.PhienMuaSam",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Total = c.Double(nullable: false),
                        TrangThai = c.Boolean(nullable: false),
                        Created_at = c.DateTime(),
                        Created_by = c.String(maxLength: 50),
                        Modified_at = c.DateTime(),
                        Delete_at = c.DateTime(),
                        Modified_by = c.String(maxLength: 50),
                        Delete_by = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KhoHang",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SoLuong = c.Int(nullable: false),
                        TrangThai = c.Boolean(nullable: false),
                        Created_at = c.DateTime(),
                        Created_by = c.String(maxLength: 50),
                        Modified_at = c.DateTime(),
                        Delete_at = c.DateTime(),
                        Modified_by = c.String(maxLength: 50),
                        Delete_by = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserThanhToan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhuongThucThanhToan = c.String(nullable: false, maxLength: 50),
                        HetHan = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GioHang", "IdSanPham", "dbo.SanPham");
            DropForeignKey("dbo.GioHang", "IdPhienMuaSam", "dbo.PhienMuaSam");
            DropForeignKey("dbo.DiaChiUser", "UserId", "dbo.Users");
            DropForeignKey("dbo.DatHang", "IdSanPham", "dbo.SanPham");
            DropForeignKey("dbo.DatHang", "IdChiTietDH", "dbo.ChiTietDatHang");
            DropForeignKey("dbo.ChiTietThanhToan", "IdChiTietDH", "dbo.ChiTietDatHang");
            DropForeignKey("dbo.ChiTietDatHang", "UserId", "dbo.Users");
            DropIndex("dbo.GioHang", new[] { "IdSanPham" });
            DropIndex("dbo.GioHang", new[] { "IdPhienMuaSam" });
            DropIndex("dbo.DiaChiUser", new[] { "UserId" });
            DropIndex("dbo.DatHang", new[] { "IdSanPham" });
            DropIndex("dbo.DatHang", new[] { "IdChiTietDH" });
            DropIndex("dbo.ChiTietThanhToan", new[] { "IdChiTietDH" });
            DropIndex("dbo.ChiTietDatHang", new[] { "UserId" });
            DropTable("dbo.UserThanhToan");
            DropTable("dbo.KhoHang");
            DropTable("dbo.PhienMuaSam");
            DropTable("dbo.GioHang");
            DropTable("dbo.GiamGia");
            DropTable("dbo.DiaChiUser");
            DropTable("dbo.SanPham");
            DropTable("dbo.DatHang");
            DropTable("dbo.DanhMucSanPham");
            DropTable("dbo.ChiTietThanhToan");
            DropTable("dbo.Users");
            DropTable("dbo.ChiTietDatHang");
        }
    }
}
