using EcommerceApiWeb.Core;
using EcommerceApiWeb.Data.Entity;
using EcommerceApiWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Nest;
using System.Security.Principal;
using WebApiEcommerceApp.Data;

namespace EcommerceApiWeb.Services
{
    public class SanPhamRepository : ISanPhamRepository
    {
        private readonly EcommerceAppDbContext _context;

        public SanPhamRepository(EcommerceAppDbContext context) 
        {
            _context = context;
        }
        public List<SanPhamModel> GetAllProduct()
        {
            var products = _context.SanPhams.Select(x => new SanPhamModel
            {
                TenSanPham = x.TenSanPham,
                MoTa = x.MoTa,
                GiaSanPham = x.GiaSanPham,
                IdDanhMuc = x.IdDanhMuc,
                IdGiamGia = x.IdGiamGia,
                IdKhoHang = x.IdKhoHang,

            });
            return products.ToList();
        }

        public SanPhamModel GetProductById(int id)
        {
            var product = _context.SanPhams.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                return new SanPhamModel
                {
                    Id = id,
                    TenSanPham = product.TenSanPham,
                    MoTa = product.MoTa,
                    GiaSanPham= product.GiaSanPham,
                    IdKhoHang= product.IdKhoHang,
                    IdDanhMuc= product.IdDanhMuc,
                    IdGiamGia = product.IdGiamGia,
                    Image = product.Image,
                };
          
            }
            return null;
        }
        public APIResponseDto<List<SanPhamModel>> SearchProduct(string tenSanPham)
        {
            var result = new APIResponseDto<List<SanPhamModel>>();
            if(tenSanPham == null)
            {
                var products = _context.SanPhams.Select(x => new SanPhamModel
                {
                    Id = x.Id,
                    TenSanPham = x.TenSanPham,
                    MoTa = x.MoTa,
                    GiaSanPham = x.GiaSanPham,
                    IdDanhMuc = x.IdDanhMuc,
                    IdGiamGia = x.IdGiamGia,
                    IdKhoHang = x.IdKhoHang,
                    Image = x.Image,

                }).ToList();
                result.Data = products;
            }
            else
            {
                var productsSearch = _context.SanPhams.Where(x => x.TenSanPham.Contains(tenSanPham)).Select(x => new SanPhamModel
                {
                    Id = x.Id,
                    TenSanPham = x.TenSanPham,
                    MoTa = x.MoTa,
                    GiaSanPham = x.GiaSanPham,
                    IdDanhMuc = x.IdDanhMuc,
                    IdGiamGia = x.IdGiamGia,
                    IdKhoHang = x.IdKhoHang,
                    Image = x.Image,

                }).ToList(); ;
                result.Data = productsSearch;
            }
            result.Status = true;
            result.Message = string.Empty;
            return result;
        }
        //public async Task<IActionResult> AddSanPham([FromForm] SanPhamModel model)
        //{
        //    var result = new APIResponseDto<SanPham>();
        //    if (model != null)
        //    {
        //        var product = new SanPham
        //        {
        //            Id = model.Id,
        //            TenSanPham = model.TenSanPham,
        //            MoTa = model.MoTa,
        //            GiaSanPham = model.GiaSanPham,
        //            IdDanhMuc = model.IdDanhMuc,
        //            IdGiamGia = model.IdGiamGia,
        //            IdKhoHang = model.IdKhoHang,

        //        };
        //        if(model.ImageProduct.Length > 0)
        //        {
        //            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", model.ImageProduct.FileName);
        //            using (var stream = System.IO.File.Create(path))
        //            {
        //                await model.ImageProduct.CopyToAsync(stream);
        //            }
        //            product.Image = "/images/" + model.ImageProduct.FileName;
        //        }
        //        else
        //        {
        //            product.Image = "";
        //        }
        //        _context.SanPhams.Add(product);
        //        _context.SaveChanges();
        //        //result.Data = product;
        //        //result.Status = true;
        //        //result.Message = "Thêm sản phẩm thành công";
        //    }

        //    //result.Data = null;
        //    //result.Status = false;
        //    //result.Message = "Thêm sản phẩm thất bại";
        //    return null;
        //}
    }
}
