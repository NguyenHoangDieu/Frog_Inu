using EcommerceApiWeb.Core;
using EcommerceApiWeb.Data.Entity;
using EcommerceApiWeb.Models;
using EcommerceApiWeb.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace EcommerceApiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonHangController : ControllerBase
    {
        private readonly EcommerceAppDbContext _context;
        private IDonHangRepository _donHangRepository;
        public DonHangController(EcommerceAppDbContext context, IDonHangRepository donHangRepository)
        {
            _context = context;
            _donHangRepository = donHangRepository;
        }
        [Authorize]
        [HttpGet("DanhSachDonHang")]
        public APIResponseDto<List<DonHang>> ListDonHang(int userId)
        {
            var result = new APIResponseDto<List<DonHang>>();
            result.Status = true;
            result.Message = string.Empty;
            var donHang = _context.DonHangs.Where(x => x.IdUser == userId).ToList();
            result.Data = donHang;
            return result;
        }
        [Authorize]
        [HttpPost("MuaHang")]
        public APIResponseDto<string> DatHang(DonHangModel model)
        {
            var result = new APIResponseDto<string>();
            var isOrderCreated = true;
            var idOrder = 0;
            try
            {
                if (model != null && model.SanPham != null && model.SanPham.Any())
                {
                    var order = new DonHang()
                    {
                        Id = model.Id,
                        IdUser = model.IdUser,
                        TypeNhanHang = model.TypeNhanHang,
                        DiaDiemNhanHang = model.DiaDiemNhanHang,
                        NgayMua = DateTime.Now,
                        IdKhoHang = model.IdKhoHang,
                        GiaTamTinh = model.GiaTamTinh,
                        GiaDonHang = model.GiaDonHang,

                    };
                    _context.Add(order);
                    _context.SaveChanges();

                    var listOrderDetails = new List<ChiTietDonHang>();
                    foreach (var item in model.SanPham)
                    {
                        if (item.SoLuong <= 0)
                        {
                            continue;
                        }
                        var data = new ChiTietDonHang()
                        {
                            IdDonHang = order.Id,
                            IdSanPham = item.IdSanPham,
                            SoLuong = item.SoLuong,
                        };
                        listOrderDetails.Add(data);
                    }

                    if (listOrderDetails.Any())
                    {
                        _context.AddRange(listOrderDetails);
                        _context.Update(order);
                        _context.SaveChanges();
                        idOrder = order.Id;
                    }
                    else
                    {
                        isOrderCreated = false;
                        _context.Remove(order);
                    }
                }

                result.Status = isOrderCreated;
                result.Message = isOrderCreated ? "Success" : "Failed";
                result.Data = isOrderCreated ? idOrder.ToString() : "";
            }
            catch (Exception ex)
            {
                result.Message = "Có lỗi xảy ra " + ex.Message;
                result.Status = false;
            }

            return result;
        }
        [Authorize]
        [Route("DetailDonHang")]
        [HttpPost]
        public async Task<APIResponseDto<DonHangDto>> GetDetailDonHang(int id)
        {
            var result = new APIResponseDto<DonHangDto>();
            try
            {
                var order = _donHangRepository.GetById(id);
                result.Data = order;
                result.Status = true;
                result.Message = "Successfully";
            }
            catch (Exception ex)
            {
                result.Status = false;
                result.Message = ex.Message;
            }
            return result;
        }
    }
}
