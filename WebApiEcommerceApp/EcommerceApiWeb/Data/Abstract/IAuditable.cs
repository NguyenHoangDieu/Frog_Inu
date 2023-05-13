using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiEcommerceApp.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? Created_at { set; get; }
        string Created_by { set; get; }

        DateTime? Modified_at { set; get; }
        DateTime? Delete_at { set; get; }
        string Modified_by { set; get; }
        string Delete_by { set; get; }
    }
}
