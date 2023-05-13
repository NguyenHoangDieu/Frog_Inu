using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiEcommerceApp.Data.Infrastructure;

namespace WebApiEcommerceApp.Data.Repositories
{
    public interface IKhoHangRepository : IRepository<KhoHang>
    {

    }
    public class KhoHangRepository : RepositoryBase<KhoHang>, IKhoHangRepository
    {
        public KhoHangRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
