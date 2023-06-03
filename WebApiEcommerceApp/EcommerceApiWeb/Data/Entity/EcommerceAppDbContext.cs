using Microsoft.EntityFrameworkCore;
using WebApiEcommerceApp.Data;

namespace EcommerceApiWeb.Data.Entity
{
    public partial class EcommerceAppDbContext : DbContext
    {
        public EcommerceAppDbContext(DbContextOptions options) : base(options) { }
        public virtual DbSet<ChiTietDatHang> ChiTietDatHangs { get; set; }
        public virtual DbSet<ChiTietThanhToan> ChiTietThanhToans { get; set; }
        public virtual DbSet<DanhMucSanPham> DanhMucSanPhams { get; set; }
        public virtual DbSet<DatHang> DatHangs { get; set; }
        public virtual DbSet<DiaChiUser> DiaChiUsers { get; set; }
        public virtual DbSet<GiamGia> GiamGias { get; set; }
        public virtual DbSet<KhoHang> KhoHangs { get; set; }
        public virtual DbSet<PhienMuaSam> PhienMuaSams { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserThanhToan> UserThanhToans {get;set;}

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
