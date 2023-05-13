using EcommerceApiWeb.Data.Entity;
using EcommerceApiWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiEcommerceApp.Data;

namespace EcommerceApiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanhMucSanPhamController : ControllerBase
    {
        private readonly EcommerceAppDbContext _context;
        public DanhMucSanPhamController(EcommerceAppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAllSanPham()
        {
            var listDanhMuc = _context.DanhMucSanPhams.ToList();
            return Ok(listDanhMuc);
        }
        [HttpGet("{id}")]
        public IActionResult GetDanhMucById(int id)
        {
            var danhMuc = _context.DanhMucSanPhams.SingleOrDefault(sp => sp.Id == id);
            if (danhMuc == null)
            {
                return NotFound();
            }
            return Ok(danhMuc);
        }
        [HttpPost]
        public IActionResult CreateDanhMuc(DanhMucSanPhamModel model)
        {
            try
            {
                var danhMuc = new DanhMucSanPham
                {
                    TenDanhMuc = model.TenDanhMuc,
                    MoTa = model.MoTa,
                    TrangThai = model.TrangThai,
                };
                _context.Add(danhMuc);
                _context.SaveChanges();
                return Ok(danhMuc);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public IActionResult EditDanhMuc(int id, DanhMucSanPhamModel model)
        {
            var danhMuc = _context.DanhMucSanPhams.SingleOrDefault(sp => sp.Id == id);
            if (danhMuc == null)
            {
                return BadRequest();
            }
            danhMuc.TenDanhMuc = model.TenDanhMuc;
            danhMuc.MoTa = model.MoTa;
            danhMuc.TrangThai = model.TrangThai;
            _context.SaveChanges();
            return NoContent();
        }
    }
}
