using Microsoft.EntityFrameworkCore;
using WebApiEcommerceApp.Data;

namespace EcommerceApiWeb.Data.Entity
{
    public class EcommerceAppDbContext : DbContext
    {
        public EcommerceAppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<ChiTietDatHang> ChiTietDatHangs { get; set; }
        public DbSet<ChiTietThanhToan> ChiTietThanhToans { get; set; }
        public DbSet<DanhMucSanPham> DanhMucSanPhams { get; set; }
        public DbSet<DatHang> DatHangs { get; set; }
        public DbSet<DiaChiUser> DiaChiUsers { get; set; }
        public DbSet<GiamGia> GiamGias { get; set; }
        public DbSet<KhoHang> KhoHangs { get; set; }
        public DbSet<PhienMuaSam> PhienMuaSams { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserThanhToan> UserThanhToans {get;set;}

    }
}
