using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiEcommerceApp.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private WebApiEcommerceAppDbContext dbContext;

        public WebApiEcommerceAppDbContext Init()
        {
            return dbContext ?? (dbContext = new WebApiEcommerceAppDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }

    }
}
