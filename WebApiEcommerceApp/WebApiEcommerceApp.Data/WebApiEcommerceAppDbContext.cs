using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiEcommerceApp.Data
{
    public class WebApiEcommerceAppDbContext : DbContext
    {
        public WebApiEcommerceAppDbContext() : base("DbConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<DanhMucSanPham> DanhMucSanPhams { get; set; }
        public DbSet<DatHang> DatHangs { get; set; }
        public DbSet<ChiTietDatHang> ChiTietDatHangs { get; set; }
        public DbSet<ChiTietThanhToan> ChiTietThanhToans { get; set; }
        public DbSet<DiaChiUser> DiaChiUsers { get; set; }
        public DbSet<GiamGia> GiamGias { get; set; }
        public DbSet<GioHang> GioHangs { get; set;}
        public DbSet<KhoHang> KhoHangs { get; set;}
        public DbSet<PhienMuaSam> PhienMuaSams { get; set; }
        public DbSet<UserThanhToan> UserThanhToans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
