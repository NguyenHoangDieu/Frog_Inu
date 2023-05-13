using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiEcommerceApp.Data.Infrastructure;

namespace WebApiEcommerceApp.Data.Repositories
{
    public interface IDatHangRepository : IRepository<DatHang>
    {

    }
    public class DatHangRepository : RepositoryBase<DatHang>, IDatHangRepository
    {
        public DatHangRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
