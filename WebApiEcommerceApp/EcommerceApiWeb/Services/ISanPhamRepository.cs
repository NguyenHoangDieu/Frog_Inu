using EcommerceApiWeb.Core;
using EcommerceApiWeb.Models;
using Microsoft.AspNetCore.Mvc;
using WebApiEcommerceApp.Data;

namespace EcommerceApiWeb.Services
{
    public interface ISanPhamRepository
    {
        //Task<IActionResult> AddSanPham([FromForm] SanPhamModel model);
        List<SanPhamModel> GetAllProduct();
        APIResponseDto<List<SanPhamModel>> SearchProduct(string tenSanPham);
        SanPhamModel GetProductById(int id);
       
    }
}
