using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiEcommerceApp.Model.Abstract
{
    public abstract class Auditable
    {
        public DateTime? Created_at { set; get; }
        public string Created_by { set; get; }
        public DateTime? Modified_at { set; get; }
        public DateTime? Delete_at { set; get; }
        public string Modified_by { set; get; }
        public string Delete_by { set; get; }
    }
}
