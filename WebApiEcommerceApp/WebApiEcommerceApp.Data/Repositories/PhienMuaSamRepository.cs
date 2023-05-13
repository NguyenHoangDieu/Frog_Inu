using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiEcommerceApp.Data.Infrastructure;

namespace WebApiEcommerceApp.Data.Repositories
{
    public interface IPhienMuaSamRepository : IRepository<PhienMuaSam>
    {

    }
    public class PhienMuaSamRepository : RepositoryBase<PhienMuaSam>, IPhienMuaSamRepository
    {
        public PhienMuaSamRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
