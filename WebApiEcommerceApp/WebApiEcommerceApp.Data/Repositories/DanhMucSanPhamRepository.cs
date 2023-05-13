using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiEcommerceApp.Data.Infrastructure;

namespace WebApiEcommerceApp.Data.Repositories
{
    public interface IDanhMucSanPhamRepository : IRepository<DanhMucSanPham>
    {

    }
    public class DanhMucSanPhamRepository : RepositoryBase<DanhMucSanPham>, IDanhMucSanPhamRepository
    {
        public DanhMucSanPhamRepository(IDbFactory dbFactory) :base(dbFactory) 
        {

        }
    }
}
