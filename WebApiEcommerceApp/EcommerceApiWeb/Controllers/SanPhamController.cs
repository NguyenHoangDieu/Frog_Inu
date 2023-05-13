using EcommerceApiWeb.Data.Entity;
using EcommerceApiWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiEcommerceApp.Data;

namespace EcommerceApiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamController : ControllerBase
    {
        private readonly EcommerceAppDbContext _context;
        public SanPhamController(EcommerceAppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAllSanPham()
        {
            var listSanPham = _context.SanPhams.ToList();
            return Ok(listSanPham);
        }
        [HttpGet("{id}")]
        public IActionResult GetSanPhamById(int id) {  
            var sanPham = _context.SanPhams.SingleOrDefault(sp => sp.Id == id);
            if(sanPham == null)
            {
                return NotFound();
            }
            return Ok(sanPham);
        }
        [HttpPost]
        public IActionResult CreateSanPham(SanPhamModel model)
        {
            try
            {
                var sanPham = new SanPham
                {
                    TenSanPham = model.TenSanPham,
                    GiaSanPham = model.GiaSanPham,
                    MoTa = model.MoTa,
                    IdDanhMuc = model.IdDanhMuc,
                    IdKhoHang = model.IdKhoHang,
                    IdGiamGia = model.IdGiamGia,
                };
                _context.Add(sanPham);
                _context.SaveChanges();
                return Ok(sanPham);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public IActionResult EditSanPham(int id, SanPhamModel model)
        {
            var sanPham = _context.SanPhams.SingleOrDefault(sp => sp.Id == id);
            if(sanPham == null)
            {
                return BadRequest();
            }
            sanPham.TenSanPham = model.TenSanPham;
            sanPham.GiaSanPham = model.GiaSanPham;
            sanPham.MoTa = model.MoTa;
            sanPham.IdKhoHang = model.IdKhoHang;
            sanPham.IdDanhMuc = model.IdDanhMuc;
            sanPham.IdGiamGia = model?.IdGiamGia;
            _context.SaveChanges();
            return NoContent();
        }
    }
}
