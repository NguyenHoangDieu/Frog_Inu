using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiEcommerceApp.Data.Infrastructure;

namespace WebApiEcommerceApp.Data.Repositories
{
    public interface IGioHangRepository : IRepository<GioHang>
    {

    }
    public class GioHangRepository : RepositoryBase<GioHang>, IGioHangRepository
    {
        public GioHangRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
