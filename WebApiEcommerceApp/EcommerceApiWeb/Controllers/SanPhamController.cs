
using EcommerceApiWeb.Core;
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
        [HttpGet("SearchSanPham")]
        public APIResponseDto<List<SanPhamModel>> SearchSanPham(string tenSanPham) 
        {
            var data = _sanPhamRepository.SearchProduct(tenSanPham);
            return data;
        }
        [HttpPost("AddSanPham")]
        public async Task<IActionResult> AddSanPham([FromForm] SanPhamModel model, IFormFile ImageProduct)
        {
            var result = new APIResponseDto<SanPham>();
            if (model != null)
            {
                var product = new SanPham
                {
                    Id = 0,
                    TenSanPham = model.TenSanPham,
                    MoTa = model.MoTa,
                    GiaSanPham = model.GiaSanPham,
                    IdDanhMuc = model.IdDanhMuc,
                    IdGiamGia = model.IdGiamGia,
                    IdKhoHang = model.IdKhoHang,

                };
                if (ImageProduct.Length > 0)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", ImageProduct.FileName);
                    using (var stream = System.IO.File.Create(path))
                    {
                        await ImageProduct.CopyToAsync(stream);
                    }
                    product.Image = "/images/" + ImageProduct.FileName;
                }
                else
                {
                    product.Image = "";
                }
                _context.Add(product);
                _context.SaveChanges();
                //result.Data = product;
                //result.Status = true;
                //result.Message = "Thêm sản phẩm thành công";
                return Ok(product);
            }

            //result.Data = null;
            //result.Status = false;
            //result.Message = "Thêm sản phẩm thất bại";
            return BadRequest("Lỗi");
        }
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
