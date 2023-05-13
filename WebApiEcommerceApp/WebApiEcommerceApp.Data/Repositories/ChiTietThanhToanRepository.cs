using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiEcommerceApp.Data.Infrastructure;

namespace WebApiEcommerceApp.Data.Repositories
{
    public interface IChiTietThanhToanRepository : IRepository<ChiTietThanhToan>
    {

    }
    public class ChiTietThanhToanRepository : RepositoryBase<ChiTietThanhToan>, IChiTietThanhToanRepository
    {
        public ChiTietThanhToanRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
