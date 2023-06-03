
using EcommerceApiWeb.Data.Entity;
using EcommerceApiWeb.Models;
using EcommerceApiWeb.Services;
using Microsoft.AspNetCore.Mvc;
using WebApiEcommerceApp.Data;

namespace EcommerceApiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamController : ControllerBase
    {
        private readonly EcommerceAppDbContext _context;
        private ISanPhamRepository _sanPhamRepository;

        public SanPhamController(
            EcommerceAppDbContext context,
             ISanPhamRepository sanPhamRepository
            )
        {
            _context = context;
            _sanPhamRepository = sanPhamRepository;
        }
        [HttpGet("GetAllProduct")]
        public IActionResult GetAllSanPham()
        {
            try
            {
                return Ok(_sanPhamRepository.GetAllProduct());
            }
            catch (Exception ex)
            {
               return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetSanPhamById")]
        public IActionResult GetSanPhamById(int id) {
            try
            {
                return Ok(_sanPhamRepository.GetProductById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //[HttpPost]
        //public IActionResult CreateSanPham(SanPhamModel model)
        //{
        //    try
        //    {
        //        var sanPham = new SanPham
        //        {
        //            TenSanPham = model.TenSanPham,
        //            GiaSanPham = model.GiaSanPham,
        //            MoTa = model.MoTa,
        //            IdDanhMuc = model.IdDanhMuc,
        //            IdKhoHang = model.IdKhoHang,
        //            IdGiamGia = model.IdGiamGia,
        //        };
        //        _context.Add(sanPham);
        //        _context.SaveChanges();
        //        return Ok(sanPham);

        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
        //[HttpPut("EditSanPham")]
        //public IActionResult EditSanPham(int id, SanPhamModel model)
        //{
        //    var sanPham = _context.SanPhams.SingleOrDefault(sp => sp.Id == id);
        //    if(sanPham == null)
        //    {
        //        return BadRequest();
        //    }
        //    sanPham.TenSanPham = model.TenSanPham;
        //    sanPham.GiaSanPham = model.GiaSanPham;
        //    sanPham.MoTa = model.MoTa;
        //    sanPham.IdKhoHang = model.IdKhoHang;
        //    sanPham.IdDanhMuc = model.IdDanhMuc;
        //    sanPham.IdGiamGia = model?.IdGiamGia;
        //    _context.SaveChanges();
        //    return NoContent();
        //}
    }
}
