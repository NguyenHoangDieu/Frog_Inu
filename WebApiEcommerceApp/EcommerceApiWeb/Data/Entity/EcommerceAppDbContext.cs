using Microsoft.EntityFrameworkCore;
using WebApiEcommerceApp.Data;

namespace EcommerceApiWeb.Data.Entity
{
    public partial class EcommerceAppDbContext : DbContext
    {
        public EcommerceAppDbContext(DbContextOptions options) : base(options) { }
        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual DbSet<DanhMucSanPham> DanhMucSanPhams { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<DiaChiUser> DiaChiUsers { get; set; }
        public virtual DbSet<GiamGia> GiamGias { get; set; }
        public virtual DbSet<KhoHang> KhoHangs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>(entity =>
        //    {
        //        entity.HasNoKey();
        //        entity.ToTable("User");
        //        entity.Property(e => e.Id).HasColumnName("Id");
        //        entity.Property(e => e.Username).HasMaxLength(30).IsUnicode(false);
        //        entity.Property(e => e.Password).HasMaxLength(20).IsUnicode(false);
        //    });
        //}

        }
}
