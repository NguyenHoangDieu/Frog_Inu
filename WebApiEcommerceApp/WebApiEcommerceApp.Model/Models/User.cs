using WebApiEcommerceApp.Model.Abstract;

namespace WebApiEcommerceApp.Data
{
    public class User : Auditable
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string HoVaTen { get; set; }
        public string DienThoai { get; set; }
    }
}
