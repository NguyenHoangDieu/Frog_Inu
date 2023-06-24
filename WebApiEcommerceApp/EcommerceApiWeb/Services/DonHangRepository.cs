using EcommerceApiWeb.Core;
using EcommerceApiWeb.Data.Entity;
using EcommerceApiWeb.Models;
using Nest;
using System;
using System.Data.Entity;
using WebApiEcommerceApp.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EcommerceApiWeb.Services
{
    public class DonHangRepository : IDonHangRepository
    {
        private readonly EcommerceAppDbContext _context;

        public DonHangRepository(EcommerceAppDbContext context)
        {
            _context = context;
        }

        public DonHangDto GetById(int id)
        {
            var donhang = _context.DonHangs.FirstOrDefault(x => x.Id == id);
            var lstChiTietDonHang = _context.ChiTietDonHangs.Where(x => x.IdDonHang == donhang.Id).ToList();
            var idsSanPham = lstChiTietDonHang.Select(x => x.IdSanPham).Distinct().ToList();
            var lstSanPham = _context.SanPhams.Where(p => idsSanPham.Contains(p.Id)).AsEnumerable().ToList();
            var total = 0.0m;
            if (donhang != null)
            {
                foreach (var chitiet in lstChiTietDonHang)
                {

                    var sanpham = lstSanPham.Where(sp => sp.Id == chitiet.IdSanPham).FirstOrDefault();
                    if (lstChiTietDonHang.Count() > 0)
                    {
                        List<ChiTietDonhangDto> listChiTiet = new List<ChiTietDonhangDto>();
                        var chiTietDto = new ChiTietDonhangDto
                        {
                            IdDonHang = donhang.Id,
                            IdSanPham = sanpham.Id,
                            SoLuong = chitiet.SoLuong,
                        };
                        listChiTiet.Add(chiTietDto);
                    }
                    if (sanpham != null)
                    {
                        total += sanpham.GiaSanPham * chitiet.SoLuong;
                    }
                }
                return new DonHangDto
                {
                    Id = donhang.Id,
                    IdUser = donhang.IdUser,
                    Created_at = donhang.Created_at,
                    IdKhoHang = donhang.IdKhoHang,
                    DiaDiemNhanHang = donhang.DiaDiemNhanHang,
                    GiaDonHang = donhang.GiaDonHang,
                    GiaTamTinh = donhang.GiaTamTinh,
                    TypeNhanHang = donhang.TypeNhanHang,
                    TypeThanhToan = donhang.TypeThanhToan,
                    TrangThai = donhang.TrangThai,
                    ChiTietDonHang = lstChiTietDonHang,
                    SoLuong = lstChiTietDonHang.Count(),
                    DonGia = total

                    };
            }
          
            return null;
        }
    }
}
