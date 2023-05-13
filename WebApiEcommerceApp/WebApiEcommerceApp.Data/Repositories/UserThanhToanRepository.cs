using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiEcommerceApp.Data.Infrastructure;

namespace WebApiEcommerceApp.Data.Repositories
{
    public interface IUserThanhToanRepository : IRepository<UserThanhToan>
    {

    }
    public class UserThanhToanRepository : RepositoryBase<UserThanhToan>, IUserThanhToanRepository
    {
        public UserThanhToanRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
