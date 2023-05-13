using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiEcommerceApp.Data.Infrastructure;

namespace WebApiEcommerceApp.Data.Repositories
{
    public interface IMenuRepository : IRepository<SanPham>
    {

    }
    public class SanPhamRepository : RepositoryBase<SanPham>, IMenuRepository
    {
        public SanPhamRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
